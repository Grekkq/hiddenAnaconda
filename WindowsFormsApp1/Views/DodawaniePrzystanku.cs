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
    public partial class DodawaniePrzystanku : Form {
        bool ErrorIsOn = false;
        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.hover_exitbutton(this.exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.leave_exitbutton(this.exit);
        }

        // Wyłączenie fokusu
        private void turnoff_focus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        public DodawaniePrzystanku() {
            InitializeComponent();
            label_kierunek.Visible = false;
            textbox_kierunekZ.Visible = false;
        }

        private void create_Click(object sender, EventArgs e) {
            if (no.Checked == true && string.IsNullOrEmpty(textbox_kierunekZ.Text) && string.IsNullOrEmpty(textBox_kierunekDo.Text)) {
                errorProvider1.SetError(label_kierunek, "Nie wpisano kierunku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(textbox_kierunekZ, null);
                ErrorIsOn = false;
            }
            if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                p_miasto.Focus();
                p_nazwa.Focus();
                textbox_kierunekZ.Focus();
            } else if (ErrorIsOn == false) {
                var nazwa = p_nazwa.Text;
                var miasto = p_miasto.Text;
                string direction = null;

                if (yes.Checked == true) {
                    var result = MessageBox.Show("Czy na pewno chcesz dodać w mieście " + miasto + " przystanek \"" + nazwa +"\"?", "Dodanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        Models.AddingBusStops addingBusStops = new Models.AddingBusStops();
                        addingBusStops.AddBusStop(nazwa, miasto, direction);
                    } else {
                        p_miasto.Focus();
                        p_nazwa.Focus();
                    }
                } else {
                    direction = textbox_kierunekZ.Text + "-" + textBox_kierunekDo.Text;
                    var directionTo = textBox_kierunekDo.Text;
                    var directionFrom = textbox_kierunekZ.Text;
                    var result2 = MessageBox.Show("Czy na pewno chcesz dodać w mieście " + miasto + " przystanek \"" + nazwa + "\" kierunek " + direction + "?", "Dodawanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes) {
                        Models.AddingBusStops addingBusStops = new Models.AddingBusStops();
                        addingBusStops.AddDoubleBusStop(nazwa, miasto, directionTo, directionFrom);
                    } else {
                        p_miasto.Focus();
                        p_nazwa.Focus();
                    }
                }

            }
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e) {

        }
        private void p_miasto_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char) Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void p_miasto_TextChanged(object sender, EventArgs e) {

            p_miasto.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.p_miasto.Text);
            p_miasto.Select(p_miasto.Text.Length, 0);

        }

        private void p_adres_TextChanged(object sender, EventArgs e) {

        }

        private void p_nazwa_TextChanged(object sender, EventArgs e) {

        }
        private void p_nazwa_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(p_nazwa.Text)) {
                errorProvider1.SetError(p_nazwa, "Nie wpisano nazwy");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(p_nazwa, null);
                ErrorIsOn = false;
            }
        }
        private void p_miasto_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(p_miasto.Text)) {
                errorProvider1.SetError(p_miasto, "Nie wpisano miasta");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(p_miasto, null);
                ErrorIsOn = false;
            }
        }

        private void yes_CheckedChanged(object sender, EventArgs e) {
            label_kierunek.Visible = false;
            label_Z.Visible = false;
            label_Do.Visible = false;
            textBox_kierunekDo.Visible = false;
            textbox_kierunekZ.Visible = false;
        }

        private void no_CheckedChanged(object sender, EventArgs e) {
            label_kierunek.Visible = true;
            label_Z.Visible = true;
            label_Do.Visible = true;
            textBox_kierunekDo.Visible = true;
            textbox_kierunekZ.Visible = true;
        }

        private void DodawaniePrzystanku_Load(object sender, EventArgs e) {
            label_Z.Visible = false;
            label_Do.Visible = false;
            textBox_kierunekDo.Visible = false;
            textbox_kierunekZ.Visible = false;
        }
    }
}

