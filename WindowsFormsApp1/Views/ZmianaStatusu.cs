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

        SharedView sharedView = new SharedView();
        Models.StatusChange statusChange = new Models.StatusChange();

        private void turnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void hover_helpbutton(object sender, EventArgs e) {
            sharedView.hover_helpbutton(help);
        }

        private void leave_helpbutton(object sender, EventArgs e) {
            sharedView.leave_helpbutton(help);
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.leave_exitbutton(exit);

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

        // TODO: zmienne z aktualnie zaznaczonym statusem
        private void Aktualizuj_Click(object sender, EventArgs e) {
            if (pojazd.Checked == false & kierowca.Checked == false) {
                MessageBox.Show("Nie wypełniono formularza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pojazd.Checked == true & pojazdSelectionComboBox.SelectedIndex == -1) {
                MessageBox.Show("Nie wybrano pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (kierowca.Checked == true & kierowcaSelectionComboBox.SelectedIndex == -1) {
                MessageBox.Show("Nie wybrano kierowcy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (kierowcaSelectionComboBox.SelectedIndex != -1 & (radioButton3.Checked == false & radioButton4.Checked == false)) {
                MessageBox.Show("Nie wybrano statusu kierowcy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (pojazdSelectionComboBox.SelectedIndex != -1 & (radioButton1.Checked == false & radioButton2.Checked == false)) {
                MessageBox.Show("Nie wybrano statusu pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                string obiekt = "";
                if (pojazd.Checked == true) {
                    obiekt = "pojazdu";
                } else {
                    obiekt = "kierowcy";
                    if (radioButton4.Checked == true)
                        statusChange.ChangeDriverStatus(kierowcaSelectionComboBox.Text, true);
                    else
                        statusChange.ChangeDriverStatus(kierowcaSelectionComboBox.Text, false);
                }
                MessageBox.Show("Pomyślnie zmieniono status " + obiekt + ".", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
