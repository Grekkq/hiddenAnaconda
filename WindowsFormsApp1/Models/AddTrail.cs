﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hiddenAnaconda.Constants;

namespace hiddenAnaconda.Models {
    class AddTrail {
        ReportDataContext dc;
        int lineNumber, trailNumber;
        List<StopInTrail> trail = new List<StopInTrail>();

        public AddTrail(int lineNumber, int trailNumber) {
            dc = new ReportDataContext();
            this.lineNumber = lineNumber;
            this.trailNumber = trailNumber;
            GetTrailFromDb();
        }

        public void LoadTrailIntoListBox(ListBox listBox) {
            listBox.Items.Clear();
            foreach (var item in trail)
                new routeElementModel(item.name, item.city, item.arrivalTime, item.way).putInListBox(listBox);
        }

        private void GetTrailFromDb() {
            var data = dc.trasas.Where(t => t.id_linii == lineNumber && t.nr_trasy == trailNumber).OrderBy(t => t.kolejnosc_przystankow).Select(t => new { t.id_trasy, t.id_przystanku, t.kolejnosc_przystankow });
            foreach (var item in data) {
                var busStop = dc.przystaneks.Where(p => p.id_przystanku == item.id_przystanku).First();
                var timeStamp = dc.czas_odjazdus.Where(c => c.id_trasy == item.id_trasy).First();
                trail.Add(new StopInTrail(busStop.miasto, busStop.nazwa, item.kolejnosc_przystankow, item.id_trasy, timeStamp.czas_odjazdu1, busStop.kierunek));
            }
        }

        public void EditExistingTrail(ListBox listBox) {
            if (!DeleteTrailFromDb()) {
                MessageBox.Show("Nie udało się zedytować trasy sprawdź czy nie jest przypisana do jakiegoś kursu.");
                return;
            }
            PutTrailIntoDb(ParseDataFromListBox(listBox));
        }

        public void AddNewTrail(ListBox listBox) {
            // find highest index of trailNumber and add one to it
            this.trailNumber = dc.trasas.Where(t => t.id_linii.Equals(lineNumber)).Select(t => t.nr_trasy).Distinct().OrderByDescending(t => t).First() + 1;
            PutTrailIntoDb(ParseDataFromListBox(listBox));
        }

        public void AddFirstTrail(ListBox listBox) {
            this.trailNumber = 0;
            PutTrailIntoDb(ParseDataFromListBox(listBox));
        }

        private List<StopInTrail> ParseDataFromListBox(ListBox listBox) {
            List<StopInTrail> toAdd = new List<StopInTrail>();
            foreach (var item in listBox.Items) {
                string row = item.ToString();

                int order = Int32.Parse(row.Substring(0, row.IndexOf(Constants.ListBoxNumberDelimiter)));
                row = row.Substring(row.IndexOf(ListBoxNumberDelimiter) + 1).TrimStart();

                string city = row.Substring(0, row.IndexOf(','));
                row = row.Substring(row.IndexOf(',') + 1).TrimStart();


                string name = row.Substring(0, row.IndexOf(", ")).TrimEnd();
                row = row.Substring(row.IndexOf(", ") + 1).TrimStart();

                // wyszukiwanie HH:mm
                int index = Constants.FindArrivalTimeInString.Match(row).Index;
                string way = row.Substring(0, index).Trim();

                DateTime time = DateTime.Parse(Constants.DateElementForArrivalTime + row.Substring(index));
                toAdd.Add(new StopInTrail(city, name, order, 0, time, way));
            }
            return toAdd;
        }

        private void PutTrailIntoDb(List<StopInTrail> trail) {
            // wstawiać po elemencie trasę i czas
            int order = 0;
            foreach (var item in trail) {
                czas_odjazdu czas = new czas_odjazdu();
                czas.czas_odjazdu1 = DateTime.Parse(Constants.DateElementForArrivalTime + item.arrivalTime.ToString());
                trasa trasa = new trasa();
                trasa.id_linii = lineNumber;
                trasa.nr_trasy = trailNumber;
                if (item.way.Equals(Constants.OneWayStop))
                    trasa.id_przystanku = dc.przystaneks.Where(p => p.nazwa.Equals(item.name) && p.miasto.Equals(item.city)).Select(p => p.id_przystanku).First();
                else
                    trasa.id_przystanku = dc.przystaneks.Where(p => p.nazwa.Equals(item.name) && p.miasto.Equals(item.city) && p.kierunek.Equals(item.way)).Select(p => p.id_przystanku).First();
                trasa.kolejnosc_przystankow = order;
                trasa.czas_odjazdus.Add(czas);
                dc.trasas.InsertOnSubmit(trasa);
                dc.SubmitChanges();
                order++;
            }

        }

        private bool DeleteTrailFromDb() {
            try {
                dc.trasas.DeleteAllOnSubmit(dc.trasas.Where(t => t.id_linii.Equals(lineNumber) && t.nr_trasy.Equals(trailNumber)).ToList());
                dc.SubmitChanges();
            } catch (Exception e) {
                Debug.Print("Cannot delete trail. \n{0}", e);
                return false;
            }
            return true;
        }
    }

    class StopInTrail {
        public string city, name, way;
        public TimeSpan arrivalTime;
        public int order, trailId;

        public StopInTrail(string city, string name, int order, int trailId, DateTime time, string way) {
            this.city = city;
            this.name = name;
            this.order = order;
            this.trailId = trailId;
            this.arrivalTime = time.TimeOfDay;
            this.way = way==null?Constants.OneWayStop:way;
        }
    }
}
