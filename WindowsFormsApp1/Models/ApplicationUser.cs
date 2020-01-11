using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;

namespace hiddenAnaconda.Models {
    class ApplicationUser {

        ReportDataContext dc;

        public ApplicationUser() {
            dc = new ReportDataContext();
        }


        public void createUser(string login, string password, int permission_level) {
            string salt = generateSalt();
            string hashToDb = GetSaltedHashedPassword(password, salt);
            logowanie user = new logowanie();
            user.login = login;
            user.hasz = hashToDb;
            user.poziom_uprawnien = permission_level;
            user.czy_aktywny = true;
            try {
                dc.logowanies.InsertOnSubmit(user);
                dc.SubmitChanges();
            } catch {
                MessageBox.Show("Spróbuj jeszcze raz.", "Wystąpił błąd przy tworzeniu użytkownika!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckIfUserExist(login))
                MessageBox.Show("Utworzono użytkownika: " + login);
            else
                MessageBox.Show("Spróbuj jeszcze raz.", "Wystąpił błąd przy sprawdzeniu czy użytkownik istnieje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //zzmienić where na Single????
        public bool CheckIfUserExist(string username) {
            try {
                // Throw InvalidOperationException if no element satisfies the condition in predicate.
                dc.logowanies.Single(l => l.login.ToLower() == username.ToLower());
            } catch (InvalidOperationException) {
                return false;
            }
            return true;
        }

        public bool LoginUser(string login, string password) {
            string hash = GetHashFromDb(login);
            if (hash.Equals("0"))
                return false;
            string salt = hash.Substring(0, 32);
            if (hash.Equals(GetSaltedHashedPassword(password, salt))) {
                Debug.Print("Successfully loged in user: {0}", login);
                return true;
            }
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

        // Return hash from DB if login not found return 0
        // if failed to connect to db return null
        private string GetHashFromDb(string login) {
            logowanie data = null;
            try {
                data = dc.logowanies.Single(l => l.login == login);
            } catch (Exception e) {
                Debug.Print("Failed to get hash from database for login: {0}\n Reason: {1}", (object)login, e);
                return "0";
            }
            return data.hasz;
        }

        public int GetPremissionLevel(string login) {
            logowanie data = null;
            try {
                data = dc.logowanies.Single(l => l.login == login);
            }catch(Exception e) {
                Debug.Print("Failed to get permision level from database for login: {0}\n Reason {1}", (object) login, e);
                return 0;
            }
            return data.poziom_uprawnien;
        }

        public bool GetUserStatus(string login) {
            logowanie data = null;
            try {
                data = dc.logowanies.Single(l => l.login == login);
            }catch(Exception e) {
                Debug.Print("Failed to get user account status from database for login: {0}\n Reason {1}", (object) login, e);
                return false;
            }
            return data.czy_aktywny;
        }


        public bool ChangeUserPermission(string login, int permissionLevel) {
            string username = login.Substring(0, login.IndexOf(' '));
            var update = dc.logowanies.Single(p => p.login == username);
            update.poziom_uprawnien = permissionLevel;
            dc.SubmitChanges();
            return true;
        }

        public bool ChangeUserStatus(string login, bool status) {
            string username = login.Substring(0, login.IndexOf(' '));
            var update = dc.logowanies.Single(p => p.login == username);
            update.czy_aktywny = status;
            dc.SubmitChanges();
            return true;
        }


        public void LoadDataToUserComboBox(ComboBox comboBox) {
            comboBox.Items.Clear();
            foreach (var user in GetUserData())
                comboBox.Items.Add(user.Login + " " + (user.IsActive ? "aktywny" : "nieaktywny") + ", " + Constants.TranslatePermissionLevel(user.AccessLevel));
        }

        private List<UserData> GetUserData() {
            List<UserData> users = new List<UserData>();
            foreach (var item in dc.logowanies.Select(p => new { p.id_uzytkownika, p.login, p.poziom_uprawnien, p.czy_aktywny })) {
                users.Add(new UserData(item.id_uzytkownika, item.login, item.poziom_uprawnien, item.czy_aktywny));
            }
            return users;
        }
    }

    class UserData {
        private int userId;
        private int accessLevel;
        private bool isActive;
        private string login;

        public UserData(int userId, string login, int accessLevel, bool isActive) {
            this.UserId = userId;
            this.AccessLevel = accessLevel;
            this.IsActive = isActive;
            this.Login = login;
        }

        public int UserId { get => userId; set => userId = value; }
        public int AccessLevel { get => accessLevel; set => accessLevel = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string Login { get => login; set => login = value; }
    }
}
