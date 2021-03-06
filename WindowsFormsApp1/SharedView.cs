﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using hiddenAnaconda.Models;
using System.Diagnostics;

namespace hiddenAnaconda {

    class SharedView {
        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ReportDataContext db;

        public SharedView() {
            db = new ReportDataContext();
        }

        // ::TESTED::
        public int GetTrailNumberFromTrailId(int trailId) {
            return db.trasas.Where(t => t.id_trasy.Equals(trailId)).Select(t => t.nr_trasy).Single();
        }
        // ::TESTED::
        public trasa GetFirstStopInTrail(int trailNumber, int line) {
            return db.trasas.Where(t => t.id_linii.Equals(line) && t.nr_trasy.Equals(trailNumber)).OrderBy(t => t.nr_trasy).First();
        }

        public void LoadLinesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var line in GetLinesFromDb())
                comboBox.Items.Add(line);
        }

        public void LoadTrailAssignmentIntoComboBox(ComboBox comboBox, int lineNumber, string dayType, DateTime date) {
            comboBox.Items.Clear();
            foreach (var item in GetTrailAssignmentFromDb(lineNumber, dayType)) {
                // odrzuć kursy które są przypisane tego dnia
                if (!IsRealized(item.id_kursu, date))
                    comboBox.Items.Add(item.ktory_kurs_danego_dnia + ", godz. rozpoczęcia: " + GetArrivalTime(item.id_trasy).czas_odjazdu1.ToString("HH:mm"));
            }
        }

        private bool IsRealized(int trailAssignmentId, DateTime date) {
            return db.realizacja_kursus.Where(r => r.id_kursu.Equals(trailAssignmentId) && r.data_realizacji.Equals(date)).Count() == 0 ? false : true;
        }

        private czas_odjazdu GetArrivalTime(int trailId) {
            return db.czas_odjazdus.Where(c => c.id_trasy.Equals(trailId)).Single();
        }

        private List<kur> GetTrailAssignmentFromDb(int lineNumber, string dayType) {
            return db.kurs.Where(k => k.id_linii.Equals(lineNumber) && k.rodzaj_kursu.Equals(dayType)).OrderBy(k => k.ktory_kurs_danego_dnia).ToList();
        }

        private List<String> GetLinesFromDb() {
            List<String> lines = new List<string>();
            foreach (var item in db.linias) {
                lines.Add(item.id_linii.ToString());
            }
            return lines;
        }

        public void LoadRouteNumberIntoComboBox(ComboBox comboBox, int lineNumber) {
            comboBox.Items.Clear();
            foreach (var busStop in GetRouteNumberFromDb(lineNumber))
                comboBox.Items.Add(busStop);
        }
        public void LoadRouteNumberIntoComboBox(ComboBox comboBox, int lineNumber, string dayType) {
            comboBox.Items.Clear();
            foreach (var busStop in GetRouteNumberFromDb(lineNumber, dayType))
                comboBox.Items.Add(busStop);
        }

        private List<string> GetRouteNumberFromDb(int lineNumber) {
            return db.trasas.Where(t => t.id_linii == lineNumber).Select(t => t.nr_trasy.ToString()).Distinct().ToList();
        }

        private List<string> GetRouteNumberFromDb(int lineNumber, string dayType) {
            var alreadyAssigned = from k in db.kurs
                                  from t in db.trasas
                                  where t.id_trasy == k.id_trasy && t.id_linii == lineNumber && k.rodzaj_kursu.Equals(dayType)
                                  select t.nr_trasy;
            return db.trasas.Where(t => t.id_linii == lineNumber && !alreadyAssigned.Contains(t.nr_trasy)).Select(t => t.nr_trasy.ToString()).Distinct().ToList();
        }

        public void LoadCitiesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var busStop in GetAllCitiesFromDb())
                comboBox.Items.Add(busStop);
        }

        private List<string> GetAllCitiesFromDb() {
            return db.przystaneks.Select(p => p.miasto).Distinct().ToList();
        }

        public void LoadDayTypesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var dayType in GetAllDayTypesFromDb())
                comboBox.Items.Add(dayType);
        }

        private List<string> GetAllDayTypesFromDb() {
            return db.dni_kursowanias.Select(d => d.rodzaj_kursu).Distinct().ToList();
        }

        public void LoadBusStopsIntoComboBox(ComboBox comboBox, string city) {
            comboBox.Items.Clear();
            foreach (var busStop in GetBusStopsFromDb(city))
                comboBox.Items.Add(busStop);
        }

        private List<string> GetBusStopsFromDb(string city) {
            return db.przystaneks.Where(p => p.miasto.Equals(city)).Select(p => p.nazwa).Distinct().ToList();
        }

        public void LoadTrailDirectionIntoComboBox(ComboBox comboBox, string busStopName, string cityName) {
            comboBox.Items.Clear();
            foreach (var trailDirection in GetTrailDirectionsFromDb(busStopName, cityName))
                comboBox.Items.Add(trailDirection);
        }

        private List<string> GetTrailDirectionsFromDb(string busStopName, string cityName) {
            var data = db.przystaneks.Where(p => p.nazwa.Equals(busStopName) && p.miasto.Equals(cityName)).Select(p => p.kierunek).ToList();
            if (data.First() == null)
                return new List<string>() { Constants.OneWayStop };
            return data;
        }

        public string CheckDayType(DateTime date) {
            return db.dni_kursowanias.Where(d => d.od_dnia <= date && d.do_dnia >= date).Select(d => d.rodzaj_kursu).Single();
        }

        public bool EscKeyPressed(Form form, Keys keydata) {
            if (keydata == Keys.Escape) {
                form.Close();
                return true;
            }
            return false;
        }

        public void EscapePressed(Form form, KeyPressEventArgs e) {
            if (e.KeyChar == 27) {
                form.Close();
            }
        }

        // przesuwanie okna
        public void MoveWindow(object sender, MouseEventArgs e, IntPtr Handle) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // zmiana koloru X'a po najechaniu
        public void Hover_exitbutton(Button exit) {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        // zmiana koloru ?'a po najechaniu
        public void Hover_helpbutton(Button help) {
            help.BackColor = Color.FromArgb(0, 99, 183);
        }
        // zmiana koloru ?'a po zjechaniu

        public void Leave_helpbutton(Button help) {
            help.BackColor = Color.FromArgb(0, 99, 183);
        }

        // zmiana koloru X'a po zjechaniu
        public void Leave_exitbutton(Button exit) {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        public void FixIndex(ListBox listBox) {
            int index = 1;
            //List<String> replacmentData = new List<String>();
            List<Models.routeElementModel> busStops = new List<Models.routeElementModel>();
            foreach (object item in listBox.Items) {
                busStops.Add(new Models.routeElementModel((string)item));
                index++;
            }
            listBox.Items.Clear();
            foreach (Models.routeElementModel busStop in busStops) {
                busStop.putInListBox(listBox);
            }
        }
    }
}
