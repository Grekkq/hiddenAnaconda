using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class AddTrail {
        ReportDataContext dc;
        int lineNumber, trailNumber;
        List<StopInTrail> trail = new List<StopInTrail>();
        
        public AddTrail(int lineNumber, int trailNumber) {
            this.lineNumber = lineNumber;
            this.trailNumber = trailNumber;
            dc = new ReportDataContext();
            GetTrailFromDb();
        }

        public void LoadTrailIntoListBox(ListBox listBox) {
            listBox.Items.Clear();
            foreach (var item in trail)
                new routeElementModel(item.name, item.city, item.arrivalTime).putInListBox(listBox);
        }

        private void GetTrailFromDb() {
            var data = dc.trasas.Where(t => t.id_linii == lineNumber && t.nr_trasy == trailNumber).OrderBy(t=> t.kolejnosc_przystankow).Select(t=> new { t.id_trasy, t.id_przystanku, t.kolejnosc_przystankow });
            foreach (var item in data) {
                var busStop = dc.przystaneks.Where(p => p.id_przystanku == item.id_przystanku).First();
                var timeStamp = dc.czas_odjazdus.Where(c => c.id_trasy == item.id_trasy).First();
                trail.Add(new StopInTrail(busStop.miasto, busStop.nazwa, item.kolejnosc_przystankow, item.id_trasy, timeStamp.czas_odjazdu1));
            }
        }
    }

    class StopInTrail {
        public string city, name;
        public TimeSpan arrivalTime;
        public int order, trailId, timeStampId;

        public StopInTrail(string city, string name, int order, int trailId, DateTime time) {
            this.city = city;
            this.name = name;
            this.order = order;
            this.trailId = trailId;
            this.arrivalTime = time.TimeOfDay;
        }
    }
}
