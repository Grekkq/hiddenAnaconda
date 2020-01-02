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
            // TODO: jakoś obliczać który kurs danego dnia
            toAdd.ktory_kurs_danego_dnia = 0;
            toAdd.rodzaj_kursu = DayType;
            AddTrailAssignmentToDb(toAdd);
        }

        private czas_odjazdu GetArrivalTime(int TrailId) {
            return db.czas_odjazdus.Where(c => c.id_trasy.Equals(TrailId)).Single();
        }

        private void AddTrailAssignmentToDb(kur toAdd) {
            db.kurs.InsertOnSubmit(toAdd);
            db.SubmitChanges();
        }
    }
}
