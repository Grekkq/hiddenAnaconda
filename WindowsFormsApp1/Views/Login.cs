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
            string salt = generateSalt();
            string hash = SHA1(SHA1(passTextBox + salt));
            string hashToDb = salt + hash;
            DbConnectionManager dbConnection = new DbConnectionManager();
            dbConnection.CreateUser(this.loginTextBox.Text, hashToDb);
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

        private void LoginButton_Click(object sender, EventArgs e) {
            string usrLogin = loginTextBox.Text.ToString();
            DbConnectionManager dbConnection = new DbConnectionManager();
            string hash = dbConnection.GetUserHash(usrLogin);
            string salt = hash.Substring(0,32);
            string dupa = salt + SHA1(SHA1(passTextBox + salt));
            if (hash.Equals(dupa))
                MessageBox.Show("Udało się zalogować :D");
            else
                MessageBox.Show("Błędna nazwa użytkownika lub hasło");
        }
    }
}
