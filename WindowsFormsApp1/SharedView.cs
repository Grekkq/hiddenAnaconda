using System;
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

        ReportDataContext dc;
        private List<String> lines;
        public SharedView() {
            dc = new ReportDataContext();
            lines = new List<string>();
        }

        public void LoadLinesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            if (lines.Count == 0)
                GetLinesFromDb();
            foreach (var line in lines)
                comboBox.Items.Add(line);
        }

        private void GetLinesFromDb() {
            var data = dc.linias;
            foreach (var item in data) {
                lines.Add(item.id_linii.ToString());
            }
        }

        public void LoadRouteNumberIntoComboBox(ComboBox comboBox, int lineNumber) {
            comboBox.Items.Clear();
            foreach (var busStop in GetRouteNumberFromDb(lineNumber))
                comboBox.Items.Add(busStop);
        }

        private List<string> GetRouteNumberFromDb(int lineNumber) {
            return dc.trasas.Where(t => t.id_linii == lineNumber).Select(t => t.nr_trasy.ToString()).Distinct().ToList();
        }

        public void LoadCitiesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var busStop in GetAllCitiesFromDb())
                comboBox.Items.Add(busStop);
        }

        private List<string> GetAllCitiesFromDb() {
            return dc.przystaneks.Select(p => p.miasto).Distinct().ToList();
        }

        public void LoadDayTypesIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var dayType in GetAllDayTypesFromDb())
                comboBox.Items.Add(dayType);
        }

        private List<string> GetAllDayTypesFromDb() {
            return dc.dni_kursowanias.Select(d => d.rodzaj_kursu).Distinct().ToList();
        }

        public void LoadBusStopsIntoComboBox(ComboBox comboBox, string city) {
            comboBox.Items.Clear();
            foreach (var busStop in GetBusStopsFromDb(city))
                comboBox.Items.Add(busStop);
        }

        private List<string> GetBusStopsFromDb(string city) {
            return dc.przystaneks.Where(p => p.miasto.Equals(city)).Select(p => p.nazwa).Distinct().ToList();
        }

        public void LoadTrailDirectionIntoComboBox(ComboBox comboBox, string busStopName) {
            comboBox.Items.Clear();
            foreach (var trailDirection in GetTrailDirectionsFromDb(busStopName))
                comboBox.Items.Add(trailDirection);
        }

        private List<string> GetTrailDirectionsFromDb(string busStopName) {
            var data = dc.przystaneks.Where(p => p.nazwa.Equals(busStopName)).Select(p => p.kierunek).ToList();
            if (data.First() == null)
                return new List<string>() { "Przystanek jednokierunkowy" };
            return data;
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
