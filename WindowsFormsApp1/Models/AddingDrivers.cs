using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace hiddenAnaconda.Models {
    class AddingDrivers {
        ReportDataContext dc;
        public AddingDrivers() {
            dc = new ReportDataContext();
        }

        public bool AddDriver(string name,string surname,Int64 pesel) {
            kierowca driver = new kierowca();
            driver.imie = name;
            driver.nazwisko = surname;
            driver.czy_pracuje = true;
            driver.PESEL = pesel;

            if (chceckIfDriverExitst(pesel)) {
                MessageBox.Show("Kierowca o podanym numerze PESEL istnieje już w bazie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                try {
                    dc.kierowcas.InsertOnSubmit(driver);
                    dc.SubmitChanges();
                } catch {
                    MessageBox.Show("Nie udało się utworzyć kierowcy. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pomyślnie utworzono nowego kierowcę.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        } 

        private bool chceckIfDriverExitst(Int64 pesel) {
            if (dc.kierowcas.Any(u => u.PESEL == pesel))
                return true;
            return false;
        }

    }
}
