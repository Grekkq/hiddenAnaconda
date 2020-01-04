using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class TrailRealization {
        private ReportDataContext db;
        public TrailRealization() {
            db = new ReportDataContext();
        }


        //public checkAvalabilityForDriver()

        public List<String> GetAvailableDrivers(int lineNumber, int order, DateTime date) {
            var selectedTrailHours = GetTrailHours(GetTrailAssignment(lineNumber, order, CheckDayType(date)).id_kursu);
            List<string> drivers = new List<string>();
            bool isFree = true;
            foreach (var driver in GetAllActiveDrivers()) {
                isFree = true;
                var driverAssignmentsId = GetAllTrailAssignmentIdForDriver(driver.id_kierowcy, date);
                foreach (var driverAssignmentId in driverAssignmentsId) {
                    if (GetTrailHours(driverAssignmentId).CheckIfHoursCollide(selectedTrailHours))
                        isFree = false;
                }
                if (isFree)
                    drivers.Add(driver.nazwisko + " " + driver.imie);
            }
            return drivers;
        }



        private List<int> GetAllTrailAssignmentIdForDriver(int driverId, DateTime date) {
            return db.realizacja_kursus.Where(r => r.id_przypisanego_kierowcy.Equals(driverId) && r.data_realizacji.Equals(date)).Select(r => r.id_kursu).ToList();
        }


        // ::TESTED::
        private List<kierowca> GetAllActiveDrivers() {
            return db.kierowcas.Where(k => k.czy_pracuje.Equals(true)).ToList();
        }
        private kur GetTrailAssignment(int lineNumber, int order, string dayType) {
            return db.kurs.Where(k => k.id_linii.Equals(lineNumber) && k.ktory_kurs_danego_dnia.Equals(order) && k.rodzaj_kursu.Equals(dayType)).Single();
        }

        private string CheckDayType(DateTime date) {
            return db.dni_kursowanias.Where(d => d.od_dnia <= date && d.do_dnia >= date).Select(d => d.rodzaj_kursu).Single();
        }

        private TrailTime GetTrailHours(int TrailAssignmentId) {
            var TrailAssignment = db.kurs.Where(k => k.id_kursu.Equals(TrailAssignmentId)).Single();
            var lastStop = GetLastStopInTrail(TrailAssignment.id_linii, GetTrailNumberFromTrailId(TrailAssignment.id_trasy));
            return new TrailTime(GetArrivalTimeFromArrivalTimeId(TrailAssignment.id_czasu_odjazdu).czas_odjazdu1, GetArrivalTimeFromTrailId(lastStop.id_trasy).czas_odjazdu1, 1);
        }

        private int GetTrailNumberFromTrailId(int trailId) {
            return db.trasas.Where(t => t.id_trasy.Equals(trailId)).Select(t => t.nr_trasy).Single();
        }

        private trasa GetLastStopInTrail(int lineNumebr, int trailNumber) {
            return db.trasas.Where(t => t.id_linii.Equals(lineNumebr) && t.nr_trasy.Equals(trailNumber)).OrderByDescending(t => t.kolejnosc_przystankow).First();
        }

        private czas_odjazdu GetArrivalTimeFromArrivalTimeId(int arrivalTimeId) {
            return db.czas_odjazdus.Where(c => c.id_czasu_odjazdu.Equals(arrivalTimeId)).Single();
        }

        private czas_odjazdu GetArrivalTimeFromTrailId(int trailId) {
            return db.czas_odjazdus.Where(c => c.id_trasy.Equals(trailId)).Single();
        }

    }

    class TrailTime {
        private DateTime startTime;
        private DateTime endTime;
        private int trailAssignmentId;

        public TrailTime(DateTime startStime, DateTime endTime, int trailAssignmentId) {
            this.StartTime = startStime;
            this.EndTime = endTime;
            this.TrailAssignmentId = trailAssignmentId;
        }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int TrailAssignmentId { get => trailAssignmentId; set => trailAssignmentId = value; }

        public bool CheckIfHoursCollide(TrailTime otherTime) {
            if (StartTime < otherTime.EndTime && otherTime.StartTime < EndTime) 
                return true;
            return false;
        }
    }
}
