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
            textbox_kierunek.Visible = false;
        }

        private void create_Click(object sender, EventArgs e) {
            if (no.Checked == true && string.IsNullOrEmpty(textbox_kierunek.Text)) {
                errorProvider1.SetError(textbox_kierunek, "Nie wpisano kierunku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(textbox_kierunek, null);
                ErrorIsOn = false;
            }
            if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                p_miasto.Focus();
                p_nazwa.Focus();
                textbox_kierunek.Focus();
            } else if (!string.IsNullOrEmpty(p_nazwa.Text) && !string.IsNullOrEmpty(p_miasto.Text) && ErrorIsOn == false) {
                var nazwa = p_nazwa.Text;
                var miasto = p_miasto.Text;
                // TODO dodanie możliwości wpisania kierunku
                string direction=null;
                if (no.Checked == true)
                    direction = textbox_kierunek.Text;
                var result = MessageBox.Show("Na pewno chcesz dodać przystanek " + nazwa + " w mieście " + miasto + "?", "Dodanie kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Models.AddingBusStops addingBusStops = new Models.AddingBusStops();
                    addingBusStops.AddBusStop(nazwa, miasto, direction);
                } else {
                    p_miasto.Focus();
                    p_nazwa.Focus();
                    textbox_kierunek.Focus();
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
            textbox_kierunek.Visible = false;
        }

        private void no_CheckedChanged(object sender, EventArgs e) {
            label_kierunek.Visible = true;
            textbox_kierunek.Visible = true;
        }
    }
}

