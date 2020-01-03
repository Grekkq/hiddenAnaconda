using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class StatusChange {
        ReportDataContext dc;
        private List<String> drivers;
        private List<String> vehicles;
        public StatusChange() {
            dc = new ReportDataContext();
            drivers = new List<string>();
            vehicles = new List<string>();
        }

        // jakoś wybierać żeby dane wczytywać tylko raz i po zmianie?
        public void LoadDataToDriverComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            if (drivers.Count() == 0)
                GetDriverData();
            foreach(var driver in drivers)
                comboBox.Items.Add(driver);
        }

        private void GetDriverData() {
            foreach (var item in dc.kierowcas.Select(d => new { d.id_kierowcy, d.nazwisko, d.imie, d.czy_pracuje })) {
                drivers.Add(item.id_kierowcy + ". " + item.nazwisko + " " + item.imie + ", " + (item.czy_pracuje ? "pracuje" : "nie pracuje"));
            }
        }

        public bool ChangeDriverStatus(string driver, bool status) {
            int driverId = Int32.Parse(driver.Split('.')[0]);
            var update = dc.kierowcas.Single(k => k.id_kierowcy == driverId);
            update.czy_pracuje = status;
            dc.SubmitChanges();
            return true;
        }

        // jakoś wybierać żeby dane wczytywać tylko raz i po zmianie?
        public void LoadDataToVehicleComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            if (vehicles.Count() == 0)
                GetVehicleData();
            foreach (var vehicle in vehicles)
                comboBox.Items.Add(vehicle);
        }

        private void GetVehicleData() {
            foreach (var item in dc.pojazds.Select(p => new { p.id_pojazdu, p.marka, p.model, p.czy_sprawny, p.nr_rejestracyjny })) {
                vehicles.Add(item.id_pojazdu + ". " + item.marka + " " + item.model + " " + item.nr_rejestracyjny + ", " + (item.czy_sprawny ? "sprawny" : "niesprawny"));
            }
        }

        public bool ChangeVehicleStatus(string vehicle, bool status) {
            int vehicleId = Int32.Parse(vehicle.Split('.')[0]);
            var update = dc.pojazds.Single(p => p.id_pojazdu == vehicleId);
            update.czy_sprawny = status;
            dc.SubmitChanges();
            return true;
        }
    }
}
