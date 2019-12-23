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
        bool ErrorIsOn, ErrorNazwaIsOn = true;
        bool ErrorKierIsOn = false;
        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(this.exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(this.exit);
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
            p_miasto.Focus();
            p_nazwa.Focus();
            p_miasto.Focus();
            if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            } else if (ErrorIsOn == false && ErrorNazwaIsOn == false) {
                var nazwa = p_nazwa.Text;
                var miasto = p_miasto.Text;
                string direction = null;

                if (yes.Checked == true) {
                   
                    var result = MessageBox.Show("Czy na pewno chcesz dodać w mieście " + miasto + " przystanek \"" + nazwa +"\"?", "Dodanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Models.AddingBusStops addingBusStops = new Models.AddingBusStops();
                            addingBusStops.AddBusStop(nazwa, miasto, direction);
                        }
                     else {
                        p_miasto.Focus();
                        p_nazwa.Focus();
                        p_miasto.Focus();
                    }
                } else {
                    textbox_kierunekZ.Focus();
                    textBox_kierunekDo.Focus();
                    if ((!string.IsNullOrEmpty(p_miasto.Text) && !string.IsNullOrEmpty(p_nazwa.Text) && !string.IsNullOrEmpty(textBox_kierunekDo.Text) && !string.IsNullOrEmpty(textbox_kierunekZ.Text) && ErrorKierIsOn == false && ErrorIsOn == false))
                    {
                        direction = textbox_kierunekZ.Text + "-" + textBox_kierunekDo.Text;
                    var directionTo = textBox_kierunekDo.Text;
                    var directionFrom = textbox_kierunekZ.Text;
                    var result2 = MessageBox.Show("Czy na pewno chcesz dodać w mieście " + miasto + " przystanek \"" + nazwa + "\" kierunek " + direction + "?", "Dodawanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result2 == DialogResult.Yes)
                        {
                            Models.AddingBusStops addingBusStops = new Models.AddingBusStops();
                            addingBusStops.AddDoubleBusStop(nazwa, miasto, directionTo, directionFrom);
                        }
                    } else {
                        p_miasto.Focus();
                        p_nazwa.Focus();
                        textbox_kierunekZ.Focus();
                        textBox_kierunekDo.Focus();
                        p_miasto.Focus();
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
                ErrorNazwaIsOn = true;
            } else {
                errorProvider1.SetError(p_nazwa, null);
                ErrorNazwaIsOn = false;
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

        private void textbox_kierunekZ_TextChanged(object sender, EventArgs e)
        {
            textbox_kierunekZ.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.textbox_kierunekZ.Text);
            textbox_kierunekZ.Select(textbox_kierunekZ.Text.Length, 0);

        }
        private void textbox_kierunekZ_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_kierunekZ.Text))
            {
                errorProvider1.SetError(textbox_kierunekZ, "Nie wpisano miasta wyjściowego");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(textbox_kierunekZ, null);
                ErrorIsOn = false;
            }
        }

            private void textBox_kierunekDo_TextChanged(object sender, EventArgs e)
            {
            textBox_kierunekDo.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.textBox_kierunekDo.Text);
            textBox_kierunekDo.Select(textBox_kierunekDo.Text.Length, 0);

             }

        private void textBox_kierunekDo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_kierunekDo.Text))
            {
                errorProvider1.SetError(textBox_kierunekDo, "Nie wpisano miasta docelowego");
                ErrorKierIsOn = true;
            }
            else
            {
                errorProvider1.SetError(textBox_kierunekDo, null);
                ErrorKierIsOn = false;
            }

        }
    }
}

