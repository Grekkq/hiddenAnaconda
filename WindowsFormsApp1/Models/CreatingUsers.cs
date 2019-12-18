using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace hiddenAnaconda.Models {
    class CreatingUsers {
        ReportDataContext dc;
        public CreatingUsers() {
            dc = new ReportDataContext();
        }

        public bool CheckifUserExitst(string username) {
            try {
                // Throw InvalidOperationException if no element satisfies the condition in predicate.
                dc.logowanies.Where(l => l.login.ToLower() == username.ToLower()).First();
            } catch (InvalidOperationException) {
                return false;
            }
            return true;
            // Wersja Mateusz
            int result = (from l in dc.logowanies
                          where l.login == username
                          select l).Count();

            if (result > 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
