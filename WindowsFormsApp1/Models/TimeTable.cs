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

        // Main function generating report
        // TODO: many things xD
        public void GenerateReport(int lineName, string dayType, string stopName) {
            List<StopInOrder> stops = GetAllBusStops(lineName);
            StringBuilder htmlStops = new StringBuilder();
            foreach (var stop in stops) {
                htmlStops.Append(stop.stopName);
                htmlStops.Append(", ");
            }
            SaveToPdf(htmlStops.ToString());
        }
    }
}
