﻿using IronPdf;
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
            try {
                return dc.kurs.Where(k => k.id_trasy.Equals(trailIdForKurs) && k.rodzaj_kursu.Equals(dayType)).Single();
            } catch (InvalidOperationException) {
                Debug.Print("Trasa {0}nie została przypisana do kursu", trailIdForKurs);
                return null;
            }
        }

        // ::TESTED::
        private DateTime GetArrivalTime(int trailId) {
            return dc.czas_odjazdus.Where(c => c.id_trasy.Equals(trailId)).Single().czas_odjazdu1;
        }

        // Main function generating timetable
        public void GenerateTimetable() {
            var idTrasyDlaWszystkichLinii = GetTrasaIdForReport();
            //znajdź wszystkie liniie na przystanku
            List<int> lineName = new List<int>();
            foreach (var item in idTrasyDlaWszystkichLinii) {
                if (!lineName.Contains(item.Item1))
                    lineName.Add(item.Item1);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<html><head><style>.CityBusStop{font-size:20px;color:gainsboro;}#busstop{font-weight:bolder;font-size:25px;color:white;}.przystanek{font-size:18px;color:white;text-align:left;}th{background-color:black;color:white;} #lineName{width:70px;font-size:30px;} #arrows{font-size:28px;color:white;} #way{color:white;text-align:left;width:280px;} th.rotate{background-color:white;height:140px;white-space:nowrap;} th.rotate>div{-webkit-transform: rotate(315deg) translate(-17px,54px);width:30px;} th.rotate>div>span{border-bottom:1px solid #ccc;padding:4px 15px;color:black;} th.arrow{width:40px;text-align:center;border-radius:2px;} .ar{padding-right:10px;width:22px;} #first{background-color:white;} #przys{border-collapse:separate;border-spacing:0px;} #firstb{border-radius:5px 0px 0px 5px;} #lastb{border-radius: 0px 5px 5px 0px;} th.time{background-color:white;color:black;font-size:30px;padding:4px;} #period{background-color:rgb(187,188,182);width:650px;font-size:20px;font-weight:bold;margin:2px;} sup{padding:2px;font-size:25px;} #selected{background-color:yellow;border-radius:10px;}</style></head><body>");

            List<int> idTrasyDlaLinii = new List<int>();
            // dla każdej linii na przystanku
            foreach (var singleLine in lineName) {
                sb.Append("<table> <tr> <th id='lineName' style='font-family: MS PGothic'>");
                sb.Append("&nbsp");
                sb.Append(singleLine);
                sb.Append("&nbsp");
                sb.Append("</th> <th> <div class='przystanek' style='font-family: MS PGothic'> &nbsp przystanek: <br> </div> <span class='CityBusStop' id='city' style='font-family: MS PGothic'> &nbsp;");
                sb.Append("&nbsp");
                sb.Append(city);
                sb.Append("&nbsp");
                sb.Append("<span id='busstop'>");
                sb.Append(stopName);
                sb.Append("&nbsp");
                sb.Append("</span> <span id='arrows' style='font-family: Bahnschrift Condensed'> &nbsp;&nbsp;> >&nbsp;&nbsp; </span> <br> </span> </th> <th> <div class='przystanek' style='font-family: MS PGothic'>&nbsp kierunek: </div> <div class='CityBusStop' id='way' style='font-family: MS PGothic'> &nbsp;");
                if (!way.Equals(Constants.OneWayStop)) {
                    sb.Append("&nbsp");
                    sb.Append(way);
                } else {
                    sb.Append("&nbsp");
                    sb.Append("Jednokierunkowy");
                }
                sb.Append("<span id='arrows'> &nbsp; </span> <br> </div> </th> </tr> </table><br><br><br><br><br>");
                sb.Append("<table id='przys'> <tr>");


                // przystanki dla najdłuższej trasy
                int counter = 0;
                foreach (var stop in GetAllBusStops(singleLine)) {
                    sb.Append("<th class='rotate'>");
                    if (stop.nazwa == stopName) { //jesli przystanek jest tym, dla ktorego generuje raport to ostaczam go koloruje go na zolto
                        sb.Append("<div><span id='selected' style='font-family: MS PGothic'>");
                    } else {
                        sb.Append("<div><span style='font-family: MS PGothic'>");
                    }
                    sb.Append(stop.nazwa);
                    sb.Append(", ");
                    sb.Append(stop.miasto);
                    sb.Append("</span></div></th>");
                    counter++;
                }
                sb.Append("</tr>");
                sb.Append("<th class='ar' id='first'> <div><span></span></div> </th> "); //niewidzialny element przed paskiem, pierwszy kawalek paska z zaokraglonymi rogami
                for (int i = 0; i < counter; i++) { //rysowanie kolejnych czesci paska
                    if (i == 0) {
                        sb.Append("<th class='ar' id='firstb'> <div><span>></span></div> </th>");
                    } else if (i == counter - 1) {
                        sb.Append("<th class='ar' id='lastb'> <div><span>></span></div> </th>");
                    } else
                        sb.Append("<th class='ar'><div><span>></span></div></th>");
                }
                sb.Append("</tr></table><br><br><br>"); // ostatni element paska z zaokraglonymi rogami
                // koniec drukowania trasy teraz czasy z podzialem na dni specjalne


                idTrasyDlaLinii = idTrasyDlaWszystkichLinii.Where(t => t.Item1.Equals(singleLine)).Select(t => t.Item2).ToList();
                StringBuilder daytypeString = new StringBuilder();
                foreach (var dayType in GetAllDayTypeForLine(singleLine)) {
                    daytypeString.Clear();
                    daytypeString.Append("<table><tr>");
                    daytypeString.Append("<p id='period' style='font-family: Arial'>");
                    if (dayType == Constants.WorkDays) {
                        daytypeString.Append(Constants.WorkDaysAlias);
                    } else if (dayType == Constants.DaysOff) {
                        daytypeString.Append(Constants.DaysOffAlias);
                    } else if (dayType == Constants.Holidays) {
                        daytypeString.Append(Constants.HolidaysAlias);
                    }
                    daytypeString.Append("</p></tr>");
                    // weź z lisy sprawdź czy jest w danym rodzaju dnia jeśli tak wypisz // i wyrzuć z listy
                    List<ArrivalTimeInOrder> arrivalTimeInOrder = new List<ArrivalTimeInOrder>();
                    foreach (var kurs in idTrasyDlaLinii) {
                        var temp = GetKursFromTrailId(kurs, singleLine, dayType);
                        // skip record if trail is not assigned to any kurs
                        if (temp == null)
                            continue;
                        if (temp.rodzaj_kursu.Equals(dayType)) {
                            // jak chcemy optymalizować to można by usuwać te elementy po kazdym rodzaju dnia
                            arrivalTimeInOrder.Add(new ArrivalTimeInOrder(temp.ktory_kurs_danego_dnia, GetArrivalTime(kurs)));
                        }
                    }
                    if (arrivalTimeInOrder.Count == 0)
                        continue;
                    sb.Append(daytypeString);
                    arrivalTimeInOrder.Sort((pair1, pair2) => pair1.order.CompareTo(pair2.order));
                    int timeCounter = 0;
                    sb.Append("<tr>");
                    foreach (var timestamp in arrivalTimeInOrder) {
                        timeCounter++;
                        if (timeCounter == 8) {
                            timeCounter = 0;
                            sb.Append("</tr><tr>");
                        }
                        sb.Append("<th class='time' style='font-family: MS PGothic'>");
                        sb.Append(timestamp.time.Hour);
                        sb.Append("<sup>");
                        sb.Append(timestamp.time.Minute);
                        sb.Append("</sup>&nbsp</th>");
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><div style='page-break-after: always;'></div>");
            }
            sb.Append("</body></html>");
            SaveToPdf(sb.ToString());
        }

        // ::TESTED:: wyciągnij informacje o wszystkich trasach na tym przystanku
        private List<Tuple<int, int>> GetTrasaIdForReport() {
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
            List<Tuple<int, int>> idTrasyDlaLinii = new List<Tuple<int, int>>();
            foreach (var item in data) {
                idTrasyDlaLinii.Add(Tuple.Create(item.id_linii, item.id_trasy));
            }
            return idTrasyDlaLinii;
        }

        // ::TESTED:: Get every stop for one line from logest trail
        private List<przystanek> GetAllBusStops(int line) {

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

            var tempTrasa = dc.trasas.Where(t => t.id_linii.Equals(line) && t.id_przystanku.Equals(busStopId)).Select(t => t.nr_trasy).ToList();

            // wyciągnij tylko te trasy które zawierają przystanek
            var allTrasasInLane = dc.trasas.Where(t => t.id_linii.Equals(line) && tempTrasa.Contains(t.nr_trasy))
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
            if (tempNumber > maxNumber) {
                maxNumber = tempNumber;
                maxId = tempId;
            }

            var stopsId = allTrasasInLane.Where(t => t.nr_trasy.Equals(maxId))
                .OrderBy(t => t.kolejnosc_przystankow)
                .Select(t => t.id_przystanku).ToList();

            return dc.przystaneks.Where(p => stopsId.Contains(p.id_przystanku)).AsEnumerable().OrderBy(p => stopsId.IndexOf(p.id_przystanku)).ToList();
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
