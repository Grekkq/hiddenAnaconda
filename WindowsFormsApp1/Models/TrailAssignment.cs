using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class TrailAssignment {
        ReportDataContext db;
        int LineNumber, TrailNumber;
        string DayType;

        public TrailAssignment(int LineNumber, int TrailNumber, string DayType) {
            this.DayType = DayType;
            this.LineNumber = LineNumber;
            this.TrailNumber = TrailNumber;
            db = new ReportDataContext();
        }

        public void AddTrailAssignment() {
            kur toAdd = new kur();
            toAdd.id_linii = LineNumber;
            toAdd.id_trasy = new SharedView().GetFirstStopInTrail(TrailNumber, LineNumber).id_trasy;
            toAdd.id_czasu_odjazdu = GetArrivalTime(toAdd.id_trasy).id_czasu_odjazdu;
            toAdd.ktory_kurs_danego_dnia = GetNumberOfTrailAssignments() + 1;
            toAdd.rodzaj_kursu = DayType;
            AddTrailAssignmentToDb(toAdd);
            SortArrivalTime();
        }

        private czas_odjazdu GetArrivalTime(int TrailId) {
            return db.czas_odjazdus.Where(c => c.id_trasy.Equals(TrailId)).Single();
        }

        private int GetNumberOfTrailAssignments() {
            return db.kurs.Where(k => k.id_linii.Equals(LineNumber)).Count();
        }

        // TODO: Sortować jakoś te kursy :D
        private void SortArrivalTime() {
            var data = from k in db.kurs
                       from a in db.czas_odjazdus
                       where k.id_czasu_odjazdu == a.id_czasu_odjazdu && k.id_linii == LineNumber && k.rodzaj_kursu == DayType
                       orderby a.czas_odjazdu1 select k;
            int i = 0;
            foreach (var item in data) {
                item.ktory_kurs_danego_dnia = i;
                i++;
            }
            db.SubmitChanges();
        }

        private void AddTrailAssignmentToDb(kur toAdd) {
            db.kurs.InsertOnSubmit(toAdd);
            db.SubmitChanges();
        }
    }
}
