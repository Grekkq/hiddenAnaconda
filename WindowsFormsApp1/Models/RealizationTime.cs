using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class RealizationTime {
        ReportDataContext db;
        public RealizationTime() {
            db = new ReportDataContext();
        }

        public void LoadTrailRealizationIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach(var item in GetTrailRealizationFromDb()) {
                comboBox.Items.Add(item.Date.ToShortDateString() + Constants.ComboBoxRealizationTimeDelimiter + " " + item.DayType + Constants.ComboBoxRealizationTimeDelimiter + " " + item.LineNumber + Constants.ComboBoxRealizationTimeDelimiter + " " + item.TrailNumber);
            }
        }

        public void LoadDriversIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var driver in GetAllActiveDrivers())
                comboBox.Items.Add(driver.nazwisko + " " + driver.imie);
        }

        private List<TimeAssignmentComboBox> GetTrailRealizationFromDb() {
            var data = db.realizacja_kursus.Where(r => r.id_wykonujacego_kierowcy.HasValue != true);
            List<TimeAssignmentComboBox> timeAssignments = new List<TimeAssignmentComboBox>();
            foreach (var item in data) {
                timeAssignments.Add(new TimeAssignmentComboBox(item.data_realizacji, CheckDayType(item.data_realizacji)
                    , GetTrailAssignment(item.id_kursu).id_linii, GetTrailNumberFromTrailId(GetTrailAssignment(item.id_kursu).id_trasy)));
            }
            return timeAssignments;
        }

        private string CheckDayType(DateTime date) {
            return db.dni_kursowanias.Where(d => d.od_dnia <= date && d.do_dnia >= date).Select(d => d.rodzaj_kursu).Single();
        }

        private kur GetTrailAssignment(int trailAssignmentId) {
            return db.kurs.Where(k => k.id_kursu.Equals(trailAssignmentId)).Single();
        }

        private int GetTrailNumberFromTrailId(int trailId) {
            return db.trasas.Where(t => t.id_trasy.Equals(trailId)).Select(t => t.nr_trasy).Single();
        }

        private List<kierowca> GetAllActiveDrivers() {
            return db.kierowcas.Where(k => k.czy_pracuje.Equals(true)).ToList();
        }
    }
    class TimeAssignmentComboBox {
        private DateTime date;
        private string dayType;
        private int lineNumber;
        private int trailNumber;

        public TimeAssignmentComboBox(DateTime date, string dayType, int lineNumber, int trailNumber) {
            this.Date = date;
            this.DayType = dayType;
            this.LineNumber = lineNumber;
            this.TrailNumber = trailNumber;
        }

        public DateTime Date { get => date; set => date = value; }
        public string DayType { get => dayType; set => dayType = value; }
        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        public int TrailNumber { get => trailNumber; set => trailNumber = value; }
    }
}
