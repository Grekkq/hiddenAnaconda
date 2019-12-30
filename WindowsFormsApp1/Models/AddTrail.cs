﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hiddenAnaconda.Constants;

namespace hiddenAnaconda.Models {
    class AddTrail {
        ReportDataContext dc;
        int lineNumber, trailNumber;
        List<StopInTrail> trail = new List<StopInTrail>();

        //public AddTrail(int lineNumber, int trailNumber) {
        //    this.lineNumber = lineNumber;
        //    this.trailNumber = trailNumber;
        //    dc = new ReportDataContext();
        //    GetTrailFromDb();
        //}

        public AddTrail(int lineNumber, int trailNumber, bool isNew) {
            dc = new ReportDataContext();
            this.lineNumber = lineNumber;
            this.trailNumber = trailNumber;
            GetTrailFromDb();
            // find highest index of trailNumber and add one to it
            if (isNew)
                this.trailNumber = dc.trasas.Where(t=> t.id_linii.Equals(lineNumber)).Select(t=> t.nr_trasy).Distinct().OrderByDescending(t => t).First()+1;
        }

        public void LoadTrailIntoListBox(ListBox listBox) {
            listBox.Items.Clear();
            foreach (var item in trail)
                new routeElementModel(item.name, item.city, item.arrivalTime).putInListBox(listBox);
        }

        private void GetTrailFromDb() {
            var data = dc.trasas.Where(t => t.id_linii == lineNumber && t.nr_trasy == trailNumber).OrderBy(t => t.kolejnosc_przystankow).Select(t => new { t.id_trasy, t.id_przystanku, t.kolejnosc_przystankow });
            foreach (var item in data) {
                var busStop = dc.przystaneks.Where(p => p.id_przystanku == item.id_przystanku).First();
                var timeStamp = dc.czas_odjazdus.Where(c => c.id_trasy == item.id_trasy).First();
                trail.Add(new StopInTrail(busStop.miasto, busStop.nazwa, item.kolejnosc_przystankow, item.id_trasy, timeStamp.czas_odjazdu1));
            }
        }

        public void EditExistingTrail() {

        }

        public void AddNewTrail(ListBox listBox) {
            List<StopInTrail> toAdd = new List<StopInTrail>();
            foreach(var item in listBox.Items) {
                string row = item.ToString();

                int order = Int32.Parse(row.Substring(0, row.IndexOf(')')));
                row = row.Substring(row.IndexOf(')')+1).TrimStart();

                string city = row.Substring(0, row.IndexOf(','));
                row = row.Substring(row.IndexOf(',')+1).TrimStart();

                // tu będzie problem jak pomiędzy nazwą a godziną nie będzie 3 spacji odstępu
                // w wolnej chwili zmienić na wyszukiwanie HH:mm
                string name = row.Substring(0, row.IndexOf("   ")).TrimEnd();
                row = row.Substring(row.IndexOf("   ") + 3).Trim();

                DateTime time = DateTime.Parse(row.Substring(0, 5));
                toAdd.Add(new StopInTrail(city, name, order, 0, time));
            }
            PutTrailIntoDb(toAdd);
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
                trasa.id_przystanku = dc.przystaneks.Where(p => p.nazwa.Equals(item.name) && p.miasto.Equals(item.city)).Select(p => p.id_przystanku).First();
                trasa.kolejnosc_przystankow = order;
                trasa.czas_odjazdus.Add(czas);
                dc.trasas.InsertOnSubmit(trasa);
                dc.SubmitChanges();
                order++;
            }

        }
    }

    class StopInTrail {
        public string city, name;
        public TimeSpan arrivalTime;
        public int order, trailId;

        public StopInTrail(string city, string name, int order, int trailId, DateTime time) {
            this.city = city;
            this.name = name;
            this.order = order;
            this.trailId = trailId;
            this.arrivalTime = time.TimeOfDay;
        }
    }
}
