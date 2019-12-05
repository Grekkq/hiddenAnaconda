using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using hiddenAnaconda.Models;

namespace hiddenAnaconda.Views
{
    public partial class DodawanieUzytkownikow : Form
    {
        public DodawanieUzytkownikow()
        {
            InitializeComponent();
        }
        bool ErrorIsOn = true;
        SharedView sharedView = new SharedView();

        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        private void username_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(username.Text)) {
                errorProvider1.SetError(username, "Nie wpisano nazwy użytkownika.");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(username, null);
                ErrorIsOn = false;
            }
        }

        private void password_re_Validating(object sender, CancelEventArgs e)
        {
            if (password_re.Text!=password.Text) {
                errorProvider3.SetError(password_re, "Podane hasła nie są identyczne");
                ErrorIsOn = true;
            } else {
                errorProvider3.SetError(password_re, null);
                ErrorIsOn = false;
            }
        }
        

        private void password_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,20}$");
            if (!r.IsMatch(password.Text)) {
                errorProvider2.SetError(password, "Podane hasła nie spełnia wymogów.");
                ErrorIsOn = true;
            } else {
                errorProvider2.SetError(password, null);
                ErrorIsOn = false;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (permissions_level.SelectedIndex == -1) {
                errorProvider4.SetError(permissions_level, "Nie wybrano poziomu uprawnień");
                ErrorIsOn = true;
            } else {
                errorProvider3.SetError(password_re, null);
                ErrorIsOn = false;
            }
            if (ErrorIsOn == true) {
                MessageBox.Show("Podano niepoprawne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                CreatingUsers creating = new CreatingUsers();
                if (creating.isUserExitst(username.Text)) {
                    MessageBox.Show("Podany user istnieje");
                } else {
                    Login login = new Login();
                    login.createUser(username.Text, password.Text,Constants.TranslatePermissionLevel(permissions_level.Text));
                }
            }
                
        }

        

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodawanieUzytkownikow_Load(object sender, EventArgs e)
        {
            this.permissions_level.Items.Clear();
            this.permissions_level.Items.Add(Constants.AdminPermission);
            this.permissions_level.Items.Add(Constants.RoutePlannerPermission);
            this.permissions_level.Items.Add(Constants.MenagerPermission);
            this.permissions_level.Items.Add(Constants.DriverPermission);
        }
    }
}
