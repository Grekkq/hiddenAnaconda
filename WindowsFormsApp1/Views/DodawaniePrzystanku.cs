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
        }

        private void create_Click(object sender, EventArgs e) {
            {
                if ((yes.Checked == false && no.Checked == false) && (string.IsNullOrEmpty(p_nazwa.Text)) && (string.IsNullOrEmpty(p_miasto.Text)) && (string.IsNullOrEmpty(p_adres.Text))) {
                    MessageBox.Show("Nie wypełniono formularza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(p_nazwa.Text))) {
                    MessageBox.Show("Niewypełniono pola: Nazwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(p_miasto.Text))) {
                    MessageBox.Show("Niewypełniono pola: Miasto.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(p_adres.Text))) {
                    MessageBox.Show("Niewypełniono pola: Adres.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (yes.Checked == false && no.Checked == false) {
                    MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    const string message = "Pomyślnie utworzono nowy przystanek.";
                    const string caption = "Sukces";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) {
                        this.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void p_miasto_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

            private void p_miasto_TextChanged(object sender, EventArgs e)
        {

            p_miasto.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.p_miasto.Text);
            p_miasto.Select(p_miasto.Text.Length, 0);
           
        }

        private void p_adres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
