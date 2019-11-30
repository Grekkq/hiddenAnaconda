using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace hiddenAnaconda.Models {
    class login {

        public void createUser(string login, string password) {
            string salt = generateSalt();
            string hashToDb = GetSaltedHashedPassword(password, salt);
            logowanie user = new logowanie();
            user.login = login;
            user.hasz = hashToDb;
            user.poziom_uprawnien = 0; // do dopracowania
            user.czy_aktywny = true;
            ReportDataContext dc = new ReportDataContext();
            dc.logowanies.InsertOnSubmit(user);
            dc.SubmitChanges();
            // TODO: sprawdzenie czy się utworzył
            MessageBox.Show("Utworzono użytkownika: " + login);
        }

        public bool loginUser(string login, string password) {

            return false;
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

        private string GetSaltedHashedPassword(string password, string salt) {
            return salt + SHA1(SHA1(password + salt));
        }
    }
}
