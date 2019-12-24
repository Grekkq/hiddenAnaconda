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
            foreach (var item in trail) {
                //dc.trasas.InsertOnSubmit();
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
