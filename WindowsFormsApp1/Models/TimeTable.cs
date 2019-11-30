using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class TimeTable {
        Models.ReportDataContext dc;

        public TimeTable() {
            dc = new Models.ReportDataContext();
        }

        // wyciaga id trasy tylko dla weekendu albo normalnego tygodnia 
        private List<int> GetTrasasAtDay(DateTime date, int linia) {
            var data = from k in dc.kurs
                       from d in dc.dni_kursowanias
                       where k.id_linii == linia && (d.od_dnia <= date && d.do_dnia >= date) && k.rodzaj_kursu == d.rodzaj_kursu
                       //where k.id_linii == linia && k.rodzaj_kursu == d.rodzaj_kursu
                       select k.id_trasy;
            List<int> list = new List<int>();
            foreach (var item in data)
                list.Add(item);
            return list;
        }

        public void GetTimeTable(int linia, string przystanek, DateTime date) {
            int[] trasyDnia = GetTrasasAtDay(date, linia).ToArray();
            var cos = from t in dc.trasas
                      where trasyDnia.Contains(t.id_trasy)
                      select t;
            var data = from t in dc.trasas
                       from p in dc.przystaneks
                       from c in dc.czas_odjazdus
                       where trasyDnia.Contains(t.id_trasy) && p.id_przystanku == t.id_przystanku && c.id_trasy == t.id_trasy
                       && t.id_linii == linia && p.nazwa == przystanek
                       select c;
            foreach (var item in data) {
                Console.WriteLine("Czas odjazdu: " + item.czas_odjazdu1);
            }
        }

        public void GetAllBusStops(int linia) {
            var data = from p in dc.przystaneks
                       from t in dc.trasas
                       where t.id_linii == linia && p.id_przystanku == t.id_przystanku
                       orderby t.nr_trasy, t.kolejnosc_przystankow
                       select new {
                           p.nazwa,
                           p.miasto,
                           t.nr_trasy,
                           t.kolejnosc_przystankow,
                       };
            foreach (var item in data) {
                Console.WriteLine("Przystanek: {0}, {1}; Trasa: {2}, Kolejność: {3}", item.miasto, item.nazwa, item.nr_trasy, item.kolejnosc_przystankow);
            }
        }

    }
}
