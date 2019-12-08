using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenAnaconda.Models {
    class StopInOrder {
        public string stopName;
        public string cityName;
        public int routeNumber;
        public int order;
        public StopInOrder(string stopName, string cityName, int routeNumber, int order) {
            this.stopName = stopName;
            this.cityName = cityName;
            this.routeNumber = routeNumber;
            this.order = order;
        }
    }
}
