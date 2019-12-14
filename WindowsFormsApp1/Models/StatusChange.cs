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
        public StatusChange() {
            dc = new ReportDataContext();
            drivers = new List<string>();
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
    }
}
