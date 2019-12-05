using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace hiddenAnaconda.Models
{
    class CreatingUsers
    {
        ReportDataContext dc;
        public CreatingUsers()
        {
            dc = new ReportDataContext();
        }

        public bool isUserExitst(string username)
        {
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
