using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public string GetUserHash(ref string login) {
            try {
                command.CommandText = "select * from TableName where firstname=@firstname and lastname=@lastname";
            } catch { } finally {
                connection.Close();
            }
            return null;
        }

        //public bool CheckUserPassword(ref string login, ref string hash) {
        //    bool returnvalue = false;
        //    try {
        //        command.CommandText = "select * from TableName where firstname=@firstname and lastname=@lastname";
        //        command.Parameters.Add("firstname", SqlDbType.VarChar).Value = firstname;
        //        command.Parameters.Add("lastname", SqlDbType.VarChar).Value = lastname;
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows) {
        //            while (reader.Read()) {

        //                lastname = reader.GetString(1);
        //                firstname = reader.GetString(2);

        //                age = reader.GetString(3);


        //            }
        //        }
        //        returnvalue = true;
        //    } catch { } finally {
        //        connection.Close();
        //    }
        //    return returnvalue;



        }
}
