using IronPdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class TimeTable {
        Models.ReportDataContext dc;

        public TimeTable() {
            dc = new Models.ReportDataContext();
        }

        // Get rodzajKursu at specific day
        private string CheckDayTypeAtDate(DateTime date) {
            var result = dc.dni_kursowanias.Where(dni => dni.od_dnia <= date & dni.do_dnia >= date);
            return result.First().rodzaj_kursu;
        }

        // Get all trasaId for specific line at specific day
        // to chyba wyciąga tylko pierwszy przystanek?
        private List<int> GetTrasasNumberAtDay(DateTime date, int linia) {
            var data = from k in dc.kurs
                       from t in dc.trasas
                       where k.id_linii == linia &&
                       k.rodzaj_kursu.Equals(CheckDayTypeAtDate(date)) &&
                       t.id_trasy == k.id_trasy
                       select t.nr_trasy;

            List<int> list = new List<int>();
            foreach (var item in data)
                list.Add(item);
            return list;
        }

        // juz nie pamiętam :/
        public void GetTimeTable(int linia, string przystanek, DateTime date, int kierunek) {
            var petla = from l in dc.linias
                        where l.id_linii == linia
                        select l.czy_zapetla;
            int[] trasyDnia;
            if (petla.First() == true)
                trasyDnia = GetTrasasNumberAtDay(date, linia).Where(x => x % 2 == kierunek).ToArray();
            else
                trasyDnia = GetTrasasNumberAtDay(date, linia).ToArray();

            var data = from t in dc.trasas
                       from p in dc.przystaneks
                       from c in dc.czas_odjazdus
                       where trasyDnia.Contains(t.nr_trasy) && p.id_przystanku == t.id_przystanku && c.id_trasy == t.id_trasy
                       && t.id_linii == linia && p.nazwa == przystanek
                       select c;
            foreach (var item in data) {
                Console.WriteLine("Czas odjazdu: " + item.czas_odjazdu1);
            }
        }

        // Get every stop for one line no matter what
        public List<StopInOrder> GetAllBusStops(int linia) {
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
            List<Models.StopInOrder> stopList = new List<StopInOrder>();
            Debug.Print("List all stops for line number: {0}", linia);
            foreach (var item in data) {
                Models.StopInOrder singleStop = new StopInOrder(item.nazwa, item.miasto, item.nr_trasy, item.kolejnosc_przystankow);
                stopList.Add(singleStop);
                Debug.Print("\tPrzystanek: {0}, {1}; Trasa: {2}, Kolejność: {3}", item.miasto, item.nazwa, item.nr_trasy, item.kolejnosc_przystankow);
            }
            return stopList;
        }

        // Save file on disk
        public void SaveToPdf(string content) {
            var htmlToPdf = new HtmlToPdf();
            var pdf = htmlToPdf.RenderHtmlAsPdf(content);
            pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "Report" + ".pdf"));
        }

        // Main function generating timetable
        // TODO: many things xD
        public void GenerateTimetable(string stopName, int kierunek) {
            var idTrasyDlaWszystkichLinii = GetTrasaIdForReport(stopName, kierunek);
            //znajdź wszystkie liniie na przystanku
            List<int> lineName = new List<int>();
            foreach (var item in idTrasyDlaWszystkichLinii) {
                if (!lineName.Contains(item.id_linii))
                    lineName.Add(item.id_linii);
            }

            List<int> idTrasyDlaLinii = new List<int>();
            StringBuilder sb = new StringBuilder();

            // dla każdej linii na przystanku
            foreach (var singleLine in lineName) {
                sb.Append("<b>");
                sb.Append(singleLine);
                sb.Append("</b><br/>");
                // lista przystnaków niezależnie od dnia...
                foreach (var stop in GetAllBusStops(singleLine).Where()) {
                    sb.Append(stop.stopName);
                    sb.Append(", ");
                }

                idTrasyDlaLinii.Clear();
                foreach (var item in idTrasyDlaWszystkichLinii) {
                    if (item.id_linii.Equals(singleLine))
                        idTrasyDlaLinii.Add(item.id_trasy);
                }
                sb.Append(ArrivalTimeInHtml(singleLine, idTrasyDlaLinii));

            }
            SaveToPdf(sb.ToString());
        }

        public List<LiniaITrasa> GetTrasaIdForReport(string stopName, int kierunek) {
            // najwpier id trasy i linii
            var data = from p in dc.przystaneks
                       join t in dc.trasas on p.id_przystanku equals t.id_przystanku
                       join l in dc.linias on t.id_linii equals l.id_linii
                       where p.nazwa.Contains(stopName)
                       orderby t.id_linii
                       select new {
                           t.id_linii,
                           t.id_trasy,
                           t.nr_trasy,
                           l.czy_zapetla,
                       };
            // jeśli jednokierunkowy zwróć wszystko, jeśli nie to zwróć co drugi chyba że linia się nie zapętla
            var isOneWay = dc.przystaneks.Where(p => p.nazwa == stopName).First().czy_jednokierunkowy;
            List<LiniaITrasa> list = new List<LiniaITrasa>();
            if (isOneWay) {
                foreach (var item in data) {
                    list.Add(new LiniaITrasa(item.id_linii, item.id_trasy));
                }
            } else {
                data = data.Where(d => d.nr_trasy % 2 == kierunek || d.czy_zapetla == false);
                foreach (var item in data) {
                    list.Add(new LiniaITrasa(item.id_linii, item.id_trasy));
                }
            }
            return list;
        }

        // daj html'a z czsami przyjazdu dla danych idTrasy
        public string ArrivalTimeInHtml(int lineId, List<int> routeId) {
            var times = from c in dc.czas_odjazdus
                        where routeId.Contains(c.id_trasy)
                        select new { c.id_czasu_odjazdu, c.czas_odjazdu1 };
            StringBuilder sb = new StringBuilder();
            sb.Append("<p>");
            foreach (var item in times) {
                sb.Append("\t");
                sb.Append(item.czas_odjazdu1.TimeOfDay.Hours);
                sb.Append(":");
                sb.Append(item.czas_odjazdu1.TimeOfDay.Minutes);
            }
            sb.Append("</p>");
            return sb.ToString();
        }
    }




    class LiniaITrasa {
        public int id_linii;
        public int id_trasy;
        public LiniaITrasa(int id_linii, int id_trasy) { this.id_linii = id_linii; this.id_trasy = id_trasy; }
    }
}
