﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class EdycjaUzytkownikow : Form {
        public EdycjaUzytkownikow() {
            InitializeComponent();
        }

        bool ErrorIsOn, ErrorUprawnieIsOn = true;

        SharedView sharedView = new SharedView();
        Models.ApplicationUser ApplicationUser = new Models.ApplicationUser();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        private void EdycjaUżytkowników_Load(object sender, EventArgs e) {
            this.AcceptButton = create;
            this.comboBox_uzytkownik.Items.Clear();
            ApplicationUser.LoadDataToUserComboBox(this.comboBox_uzytkownik);
            groupBox_status_uprawnienia.Visible = false;
            radio_status.Visible = false;
            radio_uprawnienia.Visible = false;

            groupBox_status.Visible = false;
            radioButton_aktywne.Visible = false;
            radioButton_nieaktywne.Visible = false;

            label_uprawnienia.Visible = false;
            comboBox_uprawnienia.Visible = false;
        }

        private void radio_status_CheckedChanged(object sender, EventArgs e) {

            label_uprawnienia.Visible = false;
            comboBox_uprawnienia.Visible = false;

            groupBox_status.Visible = true;
            radioButton_aktywne.Visible = true;
            radioButton_nieaktywne.Visible = true;
        }

        private void comboBox_uzytkownik_SelectedIndexChanged(object sender, EventArgs e) {
            groupBox_status_uprawnienia.Visible = true;
            groupBox_status_uprawnienia.Focus();
            radio_status.Visible = true;
            radio_uprawnienia.Visible = true;
        }

        private void comboBox_uzytkownik_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_uzytkownik.Text)) {
                errorProvider1.SetError(comboBox_uzytkownik, "Nie wybrano użytkownika");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_uzytkownik, null);
                ErrorIsOn = false;
            }
        }
        private void radio_uprawnienia_CheckedChanged(object sender, EventArgs e) {
            groupBox_status.Visible = false;
            radioButton_aktywne.Visible = false;
            radioButton_nieaktywne.Visible = false;

            label_uprawnienia.Visible = true;
            comboBox_uprawnienia.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void create_Click(object sender, EventArgs e) {
            comboBox_uzytkownik.Focus();
            label1.Focus();
            comboBox_uzytkownik.Focus();
            if ((!string.IsNullOrWhiteSpace(comboBox_uzytkownik.Text) && ErrorIsOn == false)) {
                if (radio_status.Checked == false && radio_uprawnienia.Checked == false) {
                    MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (radio_status.Checked == false && radio_uprawnienia.Checked == true) {
                    comboBox_uprawnienia.Focus();
                    comboBox_uzytkownik.Focus();
                    comboBox_uprawnienia.Focus();
                    if ((!string.IsNullOrWhiteSpace(comboBox_uprawnienia.Text) && ErrorUprawnieIsOn == false)) {
                        var result = MessageBox.Show("Na pewno chcesz zmienić poziom uprawnień użytkownika ''" + comboBox_uzytkownik.Text + "'' na: " + comboBox_uprawnienia.SelectedText + "?", "Zmiana uprawnień", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            //DOANIE DO BAZY
                            ApplicationUser.ChangeUserPermission(comboBox_uzytkownik.Text, Constants.TranslatePermissionLevel(comboBox_uprawnienia.Text));
                            MessageBox.Show("Pełna zmiana uprawnień nastąpi po ponownym zalogowaniu.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        } else {
                            comboBox_uprawnienia.Focus();
                            comboBox_uzytkownik.Focus();
                            comboBox_uprawnienia.Focus();
                        }
                    }
                } else if (radio_status.Checked == true && radio_uprawnienia.Checked == false) {
                    if (radioButton_aktywne.Checked == true) {
                        var result = MessageBox.Show("Na pewno chcesz zmienić status konta ''" + comboBox_uzytkownik.Text + "'' na aktywne?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            //DOANIE DO BAZY
                            ApplicationUser.ChangeUserStatus(comboBox_uzytkownik.Text, true);
                            this.Close();
                        } else {
                            comboBox_uzytkownik.Focus();
                        }
                        //Wpisz do bazy
                    } else if (radioButton_nieaktywne.Checked == true) {
                        var result = MessageBox.Show("Na pewno chcesz zmienić status konta ''" + comboBox_uzytkownik.Text + "'' na nieaktywne?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            //DOANIE DO BAZY
                            ApplicationUser.ChangeUserStatus(comboBox_uzytkownik.Text, false);
                            this.Close();
                        } else {
                            comboBox_uzytkownik.Focus();
                        }
                    } else
                         if (radioButton_nieaktywne.Checked == false && radioButton_aktywne.Checked == false) {
                        MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void help_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Constants.HelpPath, HelpNavigator.Topic, "Edycja%20uzytkownikow.htm");
        }

        private void comboBox_uprawnienia_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_uprawnienia.Text)) {
                errorProvider1.SetError(comboBox_uprawnienia, "Nie wybrano poziomu uprawnień");
                ErrorUprawnieIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_uprawnienia, null);
                ErrorUprawnieIsOn = false;
            }
        }
    }
}
