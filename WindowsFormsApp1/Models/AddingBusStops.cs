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
    class AddingBusStops {
        ReportDataContext dc;
        public AddingBusStops() {
            dc = new ReportDataContext();
        }

        public bool AddDoubleBusStop(string name,string city,string directionTo,string directionFrom) {
            przystanek busStop = new przystanek();
            przystanek busStop2 = new przystanek();
            busStop.nazwa = name;
            busStop.miasto = city;
            busStop.kierunek = directionFrom + "-" + directionTo;
            busStop2.nazwa = name;
            busStop2.miasto = city;
            busStop2.kierunek = directionTo + "-" + directionFrom;
            if (chceckIfBusStopExist(name, city)) {
                MessageBox.Show("Przystanek " + city + " \"" + name + "\" istnieje już w bazie!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                try {
                    dc.przystaneks.InsertOnSubmit(busStop);
                    dc.przystaneks.InsertOnSubmit(busStop2);
                    dc.SubmitChanges();
                } catch {
                    MessageBox.Show("Nie udało się utworzyć przystanku. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Pomyślnie utworzono nowy przystanek.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        public bool AddBusStop(string name, string city, string direction) {
            przystanek busStop = new przystanek();
            busStop.nazwa = name;
            busStop.miasto = city;
            busStop.kierunek = direction;

            if (chceckIfBusStopExist(name, city)) {
                MessageBox.Show("Przystanek "+city+ " \"" + name + "\" istnieje już w bazie!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                try {
                    dc.przystaneks.InsertOnSubmit(busStop);
                    dc.SubmitChanges();
                } catch {
                    MessageBox.Show("Nie udało się utworzyć przystanku. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Pomyślnie utworzono nowy przystanek.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool chceckIfBusStopExist(string name, string city) {
            if (dc.przystaneks.Any(u => u.miasto == city && u.nazwa == name))
                return true;
            return false;
        }
    }
}
