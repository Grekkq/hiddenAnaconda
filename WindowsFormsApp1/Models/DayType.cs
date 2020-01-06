using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace hiddenAnaconda.Models {
    class DayType {
        ReportDataContext dc;
        public DayType() {
            dc = new ReportDataContext();
        }

        public bool addDate(string type, DateTime start, DateTime end) {
            dni_kursowania dni = new dni_kursowania();
            dni.od_dnia = start;
            dni.do_dnia = end;
            dni.rodzaj_kursu = type;
            var inserting = new DayTypeModel(start, end);
            foreach(var item in GetAllDays()) {
                if (item.CheckIfDaysCollide(inserting))
                    return false;
            }
            try {
                dc.dni_kursowanias.InsertOnSubmit(dni);
                dc.SubmitChanges();
            } catch (Exception e) {
                Debug.Print("{3}\nNie udało się dodać recordu z kursem: {0}, od dnia: {1}, do dnia: {2}\n", (object)type, start, end, e);
                return false;
            }
            Debug.Print("Udało się dodać record z kursem: {0}, od dnia: {1}, do dnia: {2}\n", (object)type, start, end);
            return true;
        }

        public IQueryable<dni_kursowania> selectDataForDataGrid() {
            try {
                var dataTable = dc.dni_kursowanias.OrderBy(d => d.od_dnia)
                    .AsQueryable();
                return dataTable;
            } catch {
                Debug.Print("Failed to get data from: dni_kursowania");
                return null;
            }
        }

        public List<DayTypeModel> GetAllDays() {
            var data = dc.dni_kursowanias.Select(d=> new { d.od_dnia, d.do_dnia });
            List<DayTypeModel> list = new List<DayTypeModel>();
            foreach (var item in data)
                list.Add(new DayTypeModel(item.od_dnia, item.do_dnia));
            return list;
        }
    }
    class DayTypeModel {
        private DateTime startTime;
        private DateTime endTime;

        public DayTypeModel(DateTime startStime, DateTime endTime) {
            this.StartTime = startStime;
            this.EndTime = endTime;
        }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        public bool CheckIfDaysCollide(DayTypeModel otherTime) {
            if (StartTime < otherTime.EndTime && otherTime.StartTime < EndTime)
                return true;
            return false;
        }
    }
}
