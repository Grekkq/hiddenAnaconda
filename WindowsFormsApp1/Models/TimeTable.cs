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
        private string city, stopName, way, fileName, filePath;

        public TimeTable(string city, string name, string way, string fileName, string filePath) {
            dc = new Models.ReportDataContext();
            this.city = city;
            this.stopName = name;
            this.way = way;
            this.fileName = fileName;
            this.filePath = filePath;
        }

        // Get rodzajKursu at specific day
        public string CheckDayTypeAtDate(DateTime date) {
            var result = dc.dni_kursowanias.Where(dni => dni.od_dnia <= date & dni.do_dnia >= date);
            return result.First().rodzaj_kursu;
        }

        // Get all trasaId for specific line at specific day
        // to chyba wyciąga tylko pierwszy przystanek?
        public List<int> GetTrasasNumberAtDay(DateTime date, int linia) {
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

        // ::TESTED::
        private int GetTrailNumberFromTrailId(int trailId) {
            return dc.trasas.Where(t => t.id_trasy.Equals(trailId)).Select(t => t.nr_trasy).Single();
        }

        // ::TESTED::
        private trasa GetFirstStopInTrail(int trailNumber, int line) {
            return dc.trasas.Where(t => t.id_linii.Equals(line) && t.nr_trasy.Equals(trailNumber)).OrderBy(t => t.nr_trasy).First();
        }

        // bez pozwalania na ten sam kurs w różne rodzaje dni
        //public kur GetKursFromTrailId(int trailId, int line) {
        //    int trailIdForKurs = GetFirstStopInTrail(GetTrailNumberFromTrailId(trailId), line).id_trasy;
        //    return dc.kurs.Where(k => k.id_trasy.Equals(trailIdForKurs)).Single();
        //}

        // z pozwalaniem na tą sama trasę dla różnych dni
        public kur GetKursFromTrailId(int trailId, int line, string dayType) {
            int trailIdForKurs = GetFirstStopInTrail(GetTrailNumberFromTrailId(trailId), line).id_trasy;
            return dc.kurs.Where(k => k.id_trasy.Equals(trailIdForKurs) && k.rodzaj_kursu.Equals(dayType)).Single();
        }

        // ::TESTED::
        private DateTime GetArrivalTime(int arrivalTimeId) {
            return dc.czas_odjazdus.Where(c => c.id_czasu_odjazdu.Equals(arrivalTimeId)).Single().czas_odjazdu1;
        }

        // Main function generating timetable
        // TODO: many things xD
        public void GenerateTimetable() {
            var idTrasyDlaWszystkichLinii = GetTrasaIdForReport();
            //znajdź wszystkie liniie na przystanku
            List<int> lineName = new List<int>();
            foreach (var item in idTrasyDlaWszystkichLinii) {
                if (!lineName.Contains(item.Item1))
                    lineName.Add(item.Item1);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<h1>");
            sb.Append(city);
            sb.Append(", ");
            sb.Append(stopName);
            if (!way.Equals(Constants.OneWayStop)) {
                sb.Append(", ");
                sb.Append(way);
            }
            sb.Append("</h1>");

            List<int> idTrasyDlaLinii = new List<int>();
            // dla każdej linii na przystanku
            foreach (var singleLine in lineName) {
                sb.Append("<p>");
                sb.Append("<h3><b>");
                sb.Append(singleLine);
                sb.Append("</b></h3><br/>");
                // przystanki dla najdłuższej trasy
                foreach (var stop in GetAllBusStops(singleLine)) {
                    sb.Append(stop.miasto);
                    sb.Append(", ");
                    sb.Append(stop.nazwa);
                    sb.Append("&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp");
                }
                // koniec drukowania trasy teraz czasy z podzialem na dni specjalne


                idTrasyDlaLinii = idTrasyDlaWszystkichLinii.Where(t => t.Item1.Equals(singleLine)).Select(t => t.Item2).ToList();

                foreach (var dayType in GetAllDayTypeForLine(singleLine)) {
                    sb.Append("<h4>");
                    sb.Append(dayType);
                    sb.Append("</h4>");
                    // weź z lisy sprawdź czy jest w danym rodzaju dnia jeśli tak wypisz // i wyrzuć z listy
                    List<ArrivalTimeInOrder> arrivalTimeInOrder = new List<ArrivalTimeInOrder>();
                    foreach (var kurs in idTrasyDlaLinii) {
                        var temp = GetKursFromTrailId(kurs, singleLine, dayType);
                        if (temp.rodzaj_kursu.Equals(dayType)) {
                            // jak chcemy optymalizować to można by usuwać te elementy po kazdym rodzaju dnia
                            //idTrasyDlaLinii.Remove(kurs);
                            arrivalTimeInOrder.Add(new ArrivalTimeInOrder(temp.ktory_kurs_danego_dnia, GetArrivalTime(temp.id_czasu_odjazdu)));
                        }
                    }
                    //arrivalTimeInOrder.Add(new ArrivalTimeInOrder(4, DateTime.Today));
                    //arrivalTimeInOrder.Add(new ArrivalTimeInOrder(2, DateTime.Today));
                    //arrivalTimeInOrder.Add(new ArrivalTimeInOrder(3, DateTime.Today));
                    //sortowanie przetestowane działa w teorii korzysta tylko z kolejności i olewa datę ale nie jestem pewny :D
                    arrivalTimeInOrder.Sort((pair1, pair2) => pair1.order.CompareTo(pair2.order));
                    sb.Append("<br />");
                    foreach(var timestamp in arrivalTimeInOrder) {
                        sb.Append(timestamp.time.Hour);
                        sb.Append(":");
                        sb.Append(timestamp.time.Minute);
                        sb.Append("&nbsp &nbsp");
                    }
                }
                sb.Append("</p>");
            }
            SaveToPdf(sb.ToString());
        }

        // ::TESTED:: wyciągnij informacje o wszystkich trasach na tym przystanku
        public List<Tuple<int, int>> GetTrasaIdForReport() {
            int busStopId = -1;
            if (way.Equals(Constants.OneWayStop))
                try {
                    busStopId = dc.przystaneks
                        .Where(p => p.miasto.Equals(city) && p.nazwa.Equals(stopName))
                         .Select(p => p.id_przystanku).Single();
                } catch (Exception e) {
                    Debug.Print("Propably failed to get single stop for given input\n" + e);
                } else
                try {
                    busStopId = dc.przystaneks
                        .Where(p => p.miasto.Equals(city) && p.nazwa.Equals(stopName) && p.kierunek.Equals(way))
                         .Select(p => p.id_przystanku).Single();
                } catch (Exception e) {
                    Debug.Print("Propably failed to get single stop for given input\n" + e);
                }

            var data = dc.trasas.Where(t => t.id_przystanku.Equals(busStopId)).Select(t => new { t.id_linii, t.id_trasy });
            // linia, idTrasy
            //Tuple<int, int> idTrasyDlaLinii = new Tuple<int, int>(1,1);
            List<Tuple<int, int>> idTrasyDlaLinii = new List<Tuple<int, int>>();
            foreach (var item in data) {
                idTrasyDlaLinii.Add(Tuple.Create(item.id_linii, item.id_trasy));
            }
            return idTrasyDlaLinii;
        }

        // ::TESTED:: Get every stop for one line from logest trail
        private List<przystanek> GetAllBusStops(int line) {

            var allTrasasInLane = dc.trasas.Where(t => t.id_linii.Equals(line))
                .Select(t => new { t.kolejnosc_przystankow, t.nr_trasy, t.id_przystanku })
                .OrderBy(t => t.nr_trasy);

            //znajduje najdluzsza linie
            int maxNumber = 0, maxId = -1;
            int tempNumber = 0, tempId = allTrasasInLane.First().nr_trasy;
            foreach (var item in allTrasasInLane) {
                if (item.nr_trasy.Equals(tempId)) {
                    tempNumber++;
                } else {
                    if (tempNumber > maxNumber) {
                        maxNumber = tempNumber;
                        maxId = tempId;
                    }
                    tempNumber = 0;
                    tempId = item.nr_trasy;
                }
            }

            var stopsId = allTrasasInLane.Where(t => t.nr_trasy.Equals(maxId))
                .OrderBy(t => t.kolejnosc_przystankow)
                .Select(t => t.id_przystanku);

            return dc.przystaneks.Where(p => stopsId.Contains(p.id_przystanku)).ToList();
        }

        // ::TESTED:: zwróć wszystkie rodziaje dni dla których są kursy
        private List<string> GetAllDayTypeForLine(int line) {
            return dc.kurs.Where(k => k.id_linii.Equals(line)).Select(k => k.rodzaj_kursu).Distinct().ToList();
        }

        // ::TESTED:: Save file on disk
        private void SaveToPdf(string content) {
            var htmlToPdf = new HtmlToPdf();
            var pdf = htmlToPdf.RenderHtmlAsPdf(content);
            pdf.SaveAs(Path.Combine(filePath, fileName.Trim() + ".pdf"));
        }
    }

    class ArrivalTimeInOrder {
        public int order;
        public DateTime time;
        public ArrivalTimeInOrder(int order, DateTime time) {
            this.time = time;
            this.order = order;
        }

    }
}
