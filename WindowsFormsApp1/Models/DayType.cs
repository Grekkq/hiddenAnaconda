using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;

namespace hiddenAnaconda.Models {
    class DayType {
        ReportDataContext dc;
        public DayType() {
            dc = new ReportDataContext();
        }

        // TODO: zmienić rodzaj kursu na string
        public bool addDate(string type, DateTime start, DateTime end) {
            dni_kursowania dni = new dni_kursowania();
            dni.od_dnia = start;
            dni.do_dnia = end;
            dni.rodzaj_kursu = type;
            try {
                dc.dni_kursowanias.InsertOnSubmit(dni);
                dc.SubmitChanges();
            } catch {
                Debug.Print("Nie udało się dodać recordu z kursem: {0}, od dnia: {1}, do dnia: {2}\n", (object)type, start, end);
                return false;
            }
            Debug.Print("Udało się dodać record z kursem: {0}, od dnia: {1}, do dnia: {2}\n", (object) type, start, end);
            return true;
        }
    }
}
