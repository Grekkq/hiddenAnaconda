using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class RealizationTime {
        ReportDataContext db;
        List<DataInDataGrid> dataInDataGrid;
        List<TimeAssignmentComboBox> timeAssignments;
        List<kierowca> drivers;
        public RealizationTime() {
            db = new ReportDataContext();
            dataInDataGrid = new List<DataInDataGrid>();
            timeAssignments = new List<TimeAssignmentComboBox>();
            drivers = new List<kierowca>();
        }

        public void AddRealizationTime(DataGridView dataGridView, ComboBox driverComboBox, ComboBox timeAssignmentComboBox) {
            int dataGridIterator = 0;
            DateTime parsedRealizationTime;
            foreach (DataGridViewRow row in dataGridView.Rows) {
                parsedRealizationTime = DateTime.Parse(row.Cells[1].Value.ToString());
                dataInDataGrid.ElementAt(dataGridIterator).RealizationTime = parsedRealizationTime;
                dataGridIterator++;
            }
            SetCarryOutDriver(drivers.ElementAt(driverComboBox.SelectedIndex).id_kierowcy, timeAssignments.ElementAt(timeAssignmentComboBox.SelectedIndex).TrailRealizationId);
            czas_realizacji temp;
            foreach(var timeAssignment in dataInDataGrid) {
                temp = new czas_realizacji();
                temp.id_czasu_odjazdu = timeAssignment.TimeId;
                temp.id_realizacji_kursu = timeAssignments.ElementAt(timeAssignmentComboBox.SelectedIndex).TrailRealizationId;
                temp.faktyczny_czas_odjazdu = timeAssignment.RealizationTime;
                db.czas_realizacjis.InsertOnSubmit(temp);
            }
            db.SubmitChanges();
        }

        private void SetCarryOutDriver(int driverId, int trailRealizationId) {
            db.realizacja_kursus.Where(r => r.id_realizacji_kursu.Equals(trailRealizationId)).Single().id_wykonujacego_kierowcy = driverId;
            db.SubmitChanges();
        }

        public void LoadDataIntoDataGridView(DataGridView dataGridView, string selectedTrailAssignment) {
            selectedTrailAssignment = selectedTrailAssignment.Substring(selectedTrailAssignment.IndexOf(Constants.ComboBoxRealizationTimeDelimiter) + Constants.ComboBoxRealizationTimeDelimiter.Length);
            int lineNumebr = Int32.Parse(selectedTrailAssignment.Substring(0, selectedTrailAssignment.IndexOf(Constants.ComboBoxRealizationTimeDelimiter)).Trim());
            int trailNumber = Int32.Parse(selectedTrailAssignment.Substring(selectedTrailAssignment.IndexOf(Constants.ComboBoxRealizationTimeDelimiter) + Constants.ComboBoxRealizationTimeDelimiter.Length).Trim());
            dataGridView.Rows.Clear();
            GetStopAndAssignedTime(lineNumebr, trailNumber);
            foreach (var row in dataInDataGrid)
                dataGridView.Rows.Add(row.City + ", " + row.Name, "", row.Time.ToString("HH:mm"));
        }

        private void GetStopAndAssignedTime(int lineNumber, int trailNumber) {
            var data = from p in db.przystaneks
                       from t in db.trasas
                       from c in db.czas_odjazdus
                       where p.id_przystanku == t.id_przystanku && t.id_trasy == c.id_trasy
                       && t.id_linii == lineNumber && t.nr_trasy == trailNumber
                       orderby t.kolejnosc_przystankow
                       select new { p.miasto, p.nazwa, c.czas_odjazdu1, c.id_czasu_odjazdu };
            foreach (var item in data)
                dataInDataGrid.Add(new DataInDataGrid(item.miasto, item.nazwa, item.czas_odjazdu1, item.id_czasu_odjazdu));
        }

        public void LoadTrailRealizationIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            GetTrailRealizationFromDb();
            foreach (var item in timeAssignments) {
                comboBox.Items.Add(
                    item.Date.ToShortDateString() + " " + Constants.ComboBoxRealizationTimeDateDelimiter + " " 
                    + item.DayType + Constants.ComboBoxRealizationTimeDelimiter + " "
                    + item.LineNumber + Constants.ComboBoxRealizationTimeDelimiter + " "
                    + item.TrailNumber);
            }
        }

        public void LoadDriversIntoComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            GetAllActiveDrivers();
            foreach (var driver in drivers)
                comboBox.Items.Add(driver.nazwisko + " " + driver.imie);
        }

        private void GetTrailRealizationFromDb() {
            var data = db.realizacja_kursus.Where(r => r.id_wykonujacego_kierowcy.HasValue != true);
            foreach (var item in data) {
                timeAssignments.Add(new TimeAssignmentComboBox(item.data_realizacji, CheckDayType(item.data_realizacji)
                    , GetTrailAssignment(item.id_kursu).id_linii, GetTrailNumberFromTrailId(GetTrailAssignment(item.id_kursu).id_trasy), item.id_realizacji_kursu));
            }
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

        private void GetAllActiveDrivers() {
            drivers = db.kierowcas.Where(k => k.czy_pracuje.Equals(true)).ToList();
        }
    }
    class TimeAssignmentComboBox {
        private DateTime date;
        private string dayType;
        private int lineNumber;
        private int trailNumber;
        private int trailRealizationId;

        public TimeAssignmentComboBox(DateTime date, string dayType, int lineNumber, int trailNumber, int trailRealizationId) {
            this.Date = date;
            this.DayType = dayType;
            this.LineNumber = lineNumber;
            this.TrailNumber = trailNumber;
            this.TrailRealizationId = trailRealizationId;
        }

        public DateTime Date { get => date; set => date = value; }
        public string DayType { get => dayType; set => dayType = value; }
        public int LineNumber { get => lineNumber; set => lineNumber = value; }
        public int TrailNumber { get => trailNumber; set => trailNumber = value; }
        public int TrailRealizationId { get => trailRealizationId; set => trailRealizationId = value; }
    }

    class DataInDataGrid {
        private string city;
        private string name;
        private DateTime time;
        private int timeId;
        private DateTime realizationTime;

        public DataInDataGrid(string city, string name, DateTime time, int timeId) {
            this.city = city;
            this.name = name;
            this.time = time;
            this.timeId = timeId;
        }

        public string City { get => city; set => city = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Time { get => time; set => time = value; }
        public int TimeId { get => timeId; set => timeId = value; }
        public DateTime RealizationTime { get => realizationTime; set => realizationTime = value; }
    }
}
