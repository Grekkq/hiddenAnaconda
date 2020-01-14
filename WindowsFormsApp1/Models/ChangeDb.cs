using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace hiddenAnaconda.Models {
    static class ChangeDb {
        public static void ChangeCurrentDb(string ip, string dbName) {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["hiddenAnaconda.Properties.Settings.hiddenAnacondaDBConnectionString"].ConnectionString = "Data Source=" + ip + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void ChangeCurrentDb(string ip, string dbName, string username, string password) {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["hiddenAnaconda.Properties.Settings.hiddenAnacondaDBConnectionString"].ConnectionString = "Data Source=" + ip + ";Initial Catalog=" + dbName + ";UID="+username+";password="+password;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static Dictionary<string, string> GetCurentConnectionString() {
            Dictionary<string, string> data = new Dictionary<string, string>();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            string rawConnectionString = connectionStringsSection.ConnectionStrings["hiddenAnaconda.Properties.Settings.hiddenAnacondaDBConnectionString"].ConnectionString;

            string ip = rawConnectionString.Substring(rawConnectionString.IndexOf("Data Source=")+12, rawConnectionString.IndexOf(";")-12);
            rawConnectionString = rawConnectionString.Substring(rawConnectionString.IndexOf(";")+1);

            string dbName = rawConnectionString.Substring(rawConnectionString.IndexOf("Initial Catalog=") + 16, rawConnectionString.IndexOf(";")-16);
            rawConnectionString = rawConnectionString.Substring(rawConnectionString.IndexOf(";") + 1);

            data.Add("IP", ip);
            data.Add("DbName", dbName);
            if (rawConnectionString.Contains("Integrated Security")) {
                data.Add("Security", "Integrated Security");
            } else {
                data.Add("Security", "User/Pass");
                string userName = rawConnectionString.Substring(rawConnectionString.IndexOf("UID=") + 4, rawConnectionString.IndexOf(";")-4);
                rawConnectionString = rawConnectionString.Substring(rawConnectionString.IndexOf(";") + 1);
                data.Add("UserName", userName);
                string password;
                if (rawConnectionString.Contains(";"))
                     password = rawConnectionString.Substring(rawConnectionString.IndexOf("password=") + 9, rawConnectionString.IndexOf(";"));
                else
                    password = rawConnectionString.Substring(rawConnectionString.IndexOf("password=") + 9);
                data.Add("Password", password);
            }

            return data;
        }
    }
}
