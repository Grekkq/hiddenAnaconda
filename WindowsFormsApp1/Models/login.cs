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
            user.poziom_uprawnien = 0; // TODO: zdecydowanie jak ustalamy poziomy uprawnień
            user.czy_aktywny = true;
            ReportDataContext dc = new ReportDataContext();
            try {
                dc.logowanies.InsertOnSubmit(user);
                dc.SubmitChanges();
            } catch {
                MessageBox.Show("Spróbuj jeszcze raz.", "Wystąpił błąd przy tworzeniu użytkownika!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chceckIfUserExist(login))
                MessageBox.Show("Utworzono użytkownika: " + login);
            else
                MessageBox.Show("Spróbuj jeszcze raz.", "Wystąpił błąd przy sprawdzeniu czy użytkownik istnieje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool chceckIfUserExist(string login) {
            ReportDataContext dc = new ReportDataContext();
            if (dc.logowanies.Any(u => u.login == login))
                return true;
            return false;
        }

        public bool loginUser(string login, string password) {
            string hash = GetHashFromDb(login);
            string salt = hash.Substring(0,32);
            if (hash.Equals(GetSaltedHashedPassword(password, salt)))
                return true;
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

        private string GetHashFromDb(string login) {
            ReportDataContext dc = new ReportDataContext();
            logowanie data;
            try {
                data = dc.logowanies.Single(l => l.login == login);
            } catch {
                MessageBox.Show("Nie istnieje taki użytkownik!", "Wystąpił błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return data.hasz;
        }
    }
}
