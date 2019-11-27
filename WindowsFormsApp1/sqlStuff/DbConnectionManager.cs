using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace hiddenAnaconda.sqlStuff {
    class DbConnectionManager {
        SqlConnection connection;
        SqlCommand command;

        public DbConnectionManager() {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hiddenAnacondaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        public string GetUserHash(string login) {
            string hash = "";
            try {
                command.CommandText = "select Hash from Security where Login=@login";
                command.Parameters.Add("login", SqlDbType.VarChar).Value = login;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        hash = reader.GetString(0);
                    }
                }
            } catch {
                MessageBox.Show("Coś poszło nie tak :(");
            } finally {
                connection.Close();
            }
            return hash;
        }
    }
}
