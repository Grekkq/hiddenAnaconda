﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace hiddenAnaconda.Views {
    public partial class DodawanieKierowcy : Form {
        bool ErrorIsOn = true;
        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();
        public DodawanieKierowcy() {
            InitializeComponent();
        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void powrot_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e) {
            DriverFirstName.ResetText();
            DriverLastName.ResetText();
            DriverPesel.ResetText();
            DriverBirthDate.ResetText();
        }

        private void Zapisz_Click(object sender, EventArgs e) {
            if ((!string.IsNullOrEmpty(DriverLastName.Text) && !string.IsNullOrEmpty(DriverFirstName.Text) && !string.IsNullOrEmpty(DriverBirthDate.Text) && !string.IsNullOrEmpty(DriverPesel.Text)) && ErrorIsOn==false)
            {
                if (MessageBox.Show("Na pewno chcesz zapisać dane kierowcy?", "Zapis Kierowcy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show("Zapisano Kierowcę");
               
            }
            else
            { 
                DriverLastName.Focus();
                DriverPesel.Focus();
                DriverBirthDate.Focus();
                DriverFirstName.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        private void leave_helpbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(help);
        }

        private void hover_helpbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(help);
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void DodawanieKierowcy_Load(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DriverName_TextChanged(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void DriverFirstName_TextChanged(object sender, EventArgs e)
        {
            DriverFirstName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.DriverFirstName.Text);
            DriverFirstName.Select(DriverFirstName.Text.Length, 0);
        }

        private void DriverFirstName_Validating(object sender, CancelEventArgs e)
        {
           if (string.IsNullOrEmpty(DriverFirstName.Text))
            {
                errorProvider1.SetError(DriverFirstName, "Nie wpisano imienia");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(DriverFirstName, null);
                ErrorIsOn = false;
            }
        }

        private void DriverLastName_TextChanged(object sender, EventArgs e)
        {
            DriverLastName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.DriverLastName.Text);
            DriverLastName.Select(DriverLastName.Text.Length, 0);
        }

        private void DriverLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DriverLastName.Text))
            {
                errorProvider1.SetError(DriverLastName, "Nie wpisano nazwiska");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(DriverLastName, null);
                ErrorIsOn = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DriverBirthDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DriverPesel_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void DriverPesel_TextChanged(object sender, EventArgs e)
        {

        }
        private void DriverPesel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DriverPesel.Text))
            {
                errorProvider1.SetError(DriverPesel, "Nie wpisano PESEL");
                ErrorIsOn = true;
            }
            else if (DriverPesel.TextLength<11)
            {

                errorProvider1.SetError(DriverPesel, "Niepoprawnie wpisany PESEL");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(DriverPesel, null);
                ErrorIsOn = false;
            }
        }
        private void DriverBirthDate_Validating(object sender, CancelEventArgs e)
        {
           
            {
                Regex r = new Regex(@"((0?[13578]|10|12)(-|\/)((0[0-9])|([12])([0-9]?)|(3[01]?))(-|\/)((\d{4})|(\d{2}))|(0?[2469]|11)(-|\/)((0[0-9])|([12])([0-9]?)|(3[0]?))(-|\/)((\d{4}|\d{2})))");

                if (string.IsNullOrEmpty(DriverBirthDate.Text))
                {
                    errorProvider1.SetError(DriverBirthDate, "Nie wpisano daty");
                    ErrorIsOn = true;
                }
                else if (!r.IsMatch(DriverBirthDate.Text))
                {
                    errorProvider1.SetError(DriverBirthDate, "Niepoprawnie wpisana data");
                    ErrorIsOn = true;
                }
                else
                {
                    errorProvider1.SetError(DriverBirthDate, null);
                    ErrorIsOn = false;
                }
            }
        }
    }
}
