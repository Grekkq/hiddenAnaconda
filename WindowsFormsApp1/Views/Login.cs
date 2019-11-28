using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using hiddenAnaconda.sqlStuff;

namespace hiddenAnaconda.Views {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e) {
            string usrLogin = loginTextBox.Text.ToString();
            string usrPassword = passTextBox.Text;
            string salt = generateSalt();
            string hashToDb = GetSaltedHashedPassword(usrPassword, salt);
            DbConnectionManager dbConnection = new DbConnectionManager();
            dbConnection.CreateUser(usrLogin, hashToDb);
            MessageBox.Show("Utworzono użytkownika");
        }

        private string generateSalt() {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var sb = new StringBuilder();
            foreach (byte b in salt)
                sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        

        private void LoginButton_Click(object sender, EventArgs e) {
            string usrLogin = loginTextBox.Text.ToString();
            string usrPassword = passTextBox.Text;
            DbConnectionManager dbConnection = new DbConnectionManager();
            string hash = dbConnection.GetUserHash(usrLogin);
            //delete dbConnection;
            string salt = hash.Substring(0,32);
            if (hash.Equals(GetSaltedHashedPassword(usrPassword, salt)))
                MessageBox.Show("Udało się zalogować :D");
            else
                MessageBox.Show("Błędna nazwa użytkownika lub hasło");
        }

        private string SHA1(string input) {
            byte[] hash;
            using (var sha1 = new SHA1CryptoServiceProvider()) {
                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            var sb = new StringBuilder();
            foreach (byte b in hash)
                sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        private string GetSaltedHashedPassword(string password, string salt) {
            return salt + SHA1(SHA1(password + salt));
        }
    }
}
