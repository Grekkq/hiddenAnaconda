using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views {
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
                if ((yes.Checked == false && no.Checked == false) && (string.IsNullOrEmpty(textBox1.Text)) && (string.IsNullOrEmpty(textBox2.Text)) && (string.IsNullOrEmpty(textBox3.Text))) {
                    MessageBox.Show("Nie wypełniono formularza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(textBox1.Text))) {
                    MessageBox.Show("Niewypełniono pola: Nazwa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(textBox2.Text))) {
                    MessageBox.Show("Niewypełniono pola: Miasto.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if ((string.IsNullOrEmpty(textBox3.Text))) {
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
    }
}
