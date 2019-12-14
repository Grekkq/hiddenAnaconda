using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class AddingVehicles {
        ReportDataContext dc;
        public AddingVehicles() {
            dc = new ReportDataContext();
        }

        public bool AddVehicle(string plateNumber, string vinNumber, string model, string brand, DateTime productionDate, bool isLowFloor, bool isWorking) {
            pojazd vehicle = new pojazd();
            return true;
        }
    }
}
