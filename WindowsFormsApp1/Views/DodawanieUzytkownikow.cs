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
        bool ErrorIsOn, ErrorPermIsOn, ErrorPassIsOn = true;


        SharedView sharedView = new SharedView();
        ApplicationUser applicationUser = new ApplicationUser();

        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.Leave_exitbutton(exit);
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
            if (string.IsNullOrEmpty(password_re.Text))
            {
                errorProvider1.SetError(password_re, "Nie wpisano hasła");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(password_re, null);
                ErrorIsOn = false;
            }

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
                ErrorPassIsOn = true;
            } else {
                errorProvider2.SetError(password, null);
                ErrorPassIsOn = false;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            username.Focus();
            password.Focus();
            password_re.Focus();
            permissions_level.Focus();
            username.Focus();

            if ((!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(password_re.Text)) && !string.IsNullOrWhiteSpace(permissions_level.Text) && ErrorIsOn == false && ErrorPassIsOn == false && ErrorPermIsOn == false)
            {
                username.Focus();
                if (applicationUser.CheckIfUserExist(username.Text))
                {
                    MessageBox.Show("Podany user istnieje");
                }
                else
                {
                    var result = MessageBox.Show("Czy na pewno chcesz utworzyć użytkownika: " + username.Text + "?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        applicationUser.createUser(username.Text, password.Text, Constants.TranslatePermissionLevel(permissions_level.Text));
                        username.ResetText();
                        password.ResetText();
                        password_re.ResetText();
                        permissions_level.ResetText();
                    }
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

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_re_TextChanged(object sender, EventArgs e)
        {

        }

        private void permissions_level_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void permissions_level_Validating(object sender, CancelEventArgs e)
        {

            if (permissions_level.SelectedIndex == -1)
            {
                errorProvider4.SetError(permissions_level, "Nie wybrano poziomu uprawnień");
                ErrorPermIsOn = true;
            }
            else
            {
                errorProvider4.SetError(permissions_level, null);
                ErrorPermIsOn = false;
            }
        }


    }
}
