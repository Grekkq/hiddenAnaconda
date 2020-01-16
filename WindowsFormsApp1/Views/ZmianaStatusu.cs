using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class ZmianaStatusu : Form {
        public ZmianaStatusu() {
            InitializeComponent();
        }

        bool ErrorIsOn, ErrorKierIsOn = true;

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        Models.StatusChange statusChange = new Models.StatusChange();

        private void turnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void hover_helpbutton(object sender, EventArgs e) {
            sharedView.Hover_helpbutton(help);
        }

        private void leave_helpbutton(object sender, EventArgs e) {
            sharedView.Leave_helpbutton(help);
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.Hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.Leave_exitbutton(exit);

        private void kierowca_CheckedChanged(object sender, EventArgs e) {
            if (kierowca.Checked == true) {
                // dynamiczne wyświetlanie
                kierowcaSelectionLabel.Visible = true;
                kierowcaSelectionComboBox.Visible = true;
                pojazdSelectionLabel.Visible = false;
                pojazdSelectionComboBox.Visible = false;

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radio_pojazd.Visible = false;

                radio_pracownik.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                // wczytanie danych do listy kierowców
                statusChange.LoadDataToDriverComboBox(this.kierowcaSelectionComboBox);
            }
        }

        private void pojazd_CheckedChanged(object sender, EventArgs e) {
            if (pojazd.Checked == true) {
                kierowcaSelectionLabel.Visible = false;
                kierowcaSelectionComboBox.SelectedIndex = -1;
                kierowcaSelectionComboBox.Visible = false;

                pojazdSelectionLabel.Visible = true;
                pojazdSelectionComboBox.SelectedIndex = -1;
                pojazdSelectionComboBox.Visible = true;

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radio_pojazd.Visible = false;

                radio_pracownik.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                // wczytanie danych do listy pojazdów
                statusChange.LoadDataToVehicleComboBox(this.pojazdSelectionComboBox);
            }
        }

        private void pojazdSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //czyszczenie wcześniej zaznaczonych opcji
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            //wyświetlanie radio dla pojazdu
            radio_pojazd.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;

            //wyłaczenia radio dla pracownika
            radio_pracownik.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void pojazdSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(pojazdSelectionComboBox.Text)) {
                errorProvider1.SetError(pojazdSelectionComboBox, "Nie wybrano pojazdu");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(pojazdSelectionComboBox, null);
                ErrorIsOn = false;
            }
        }

        private void kierowcaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            //czyszczenie wcześniej zaznaczonych opcji
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            //wyświetlanie radio dla pracownika
            radio_pracownik.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            //wyłączenie radio dla pojazdu
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radio_pojazd.Visible = false;
        }


        private void kierowcaSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(kierowcaSelectionComboBox.Text)) {
                errorProvider1.SetError(kierowcaSelectionComboBox, "Nie wybrano kierowcy");
                ErrorKierIsOn = true;
            } else {
                errorProvider1.SetError(kierowcaSelectionComboBox, null);
                ErrorKierIsOn = false;
            }
        }

        private void ZmianaStatusu_Load(object sender, EventArgs e) {
            this.AcceptButton = Aktualizuj;
        }

        private void help_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Constants.HelpPath, HelpNavigator.Topic, "Zmiana%20statusu.htm");
        }

        // TODO: zmienne z aktualnie zaznaczonym statusem
        private void Aktualizuj_Click(object sender, EventArgs e) {

            if (kierowca.Checked == false && pojazd.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if (kierowca.Checked == true && pojazd.Checked == false) {
                kierowcaSelectionComboBox.Focus();
                label2.Focus();
                kierowcaSelectionComboBox.Focus();

                if ((!string.IsNullOrEmpty(kierowcaSelectionComboBox.Text) && ErrorKierIsOn == false)) {
                    if (radioButton4.Checked == true || radioButton3.Checked == true) {
                        if (radioButton4.Checked == true) {
                            var result = MessageBox.Show("Na pewno chcesz zmienić status kierowcy na: " + radioButton4.Text + "?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) {
                                statusChange.ChangeDriverStatus(kierowcaSelectionComboBox.Text, true);
                                this.Close();
                            }
                        } else {
                            var result = MessageBox.Show("Na pewno chcesz zmienić status kierowcy na: " + radioButton3.Text + "?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) {
                                statusChange.ChangeDriverStatus(kierowcaSelectionComboBox.Text, false);
                                this.Close();
                            }
                        }
                    } else {
                        MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } else if (kierowca.Checked == false && pojazd.Checked == true) {
                pojazdSelectionComboBox.Focus();
                label2.Focus();
                pojazdSelectionComboBox.Focus();
                if ((!string.IsNullOrEmpty(pojazdSelectionComboBox.Text) && ErrorIsOn == false)) {
                    if (radioButton2.Checked == true || radioButton1.Checked == true) {
                        if (radioButton1.Checked == true) {
                            var result = MessageBox.Show("Na pewno chcesz zmienić status pojazdu na: " + radioButton1.Text + "?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) {
                                statusChange.ChangeVehicleStatus(pojazdSelectionComboBox.Text, true);
                                this.Close();
                            }
                        } else {
                            var result = MessageBox.Show("Na pewno chcesz zmienić status pojazdu na: " + radioButton2.Text + "?", "Zmiana statusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes) {
                                statusChange.ChangeVehicleStatus(pojazdSelectionComboBox.Text, false);
                                this.Close();
                            }
                        }

                    } else {
                        MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
