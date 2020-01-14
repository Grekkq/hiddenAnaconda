using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace hiddenAnaconda.Models {
    static class ChangeDb {
        public static void ChangeCurrentDb() {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["hiddenAnaconda.Properties.Settings.hiddenAnacondaDBConnectionString"].ConnectionString = "Data Source=blah;Initial Catalog=blah;UID=blah;password=blah";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
