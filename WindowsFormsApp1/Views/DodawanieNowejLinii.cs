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
    public partial class DodawanieNowejLinii : Form {
        bool ErrorIsOn = false;
        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.leave_exitbutton(exit);
        }

        public DodawanieNowejLinii() {
            InitializeComponent();
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e) {
            this.Close();
        }

        private void line_name_TextChanged(object sender, KeyPressEventArgs e) {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        // walidacja pól i zamknięcie okna
        private void create_Click(object sender, EventArgs e) {

            if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if ((!string.IsNullOrEmpty(line_name.Text) && !string.IsNullOrEmpty(groupBox1.Text) && ErrorIsOn == false)) {
                var lineNumber = int.Parse(line_name.Text);
                var isLooping = false;
                if (yes.Checked == true)
                    isLooping = true;
                var result = MessageBox.Show("Na pewno chcesz utworzyć linię " + lineNumber + "?", "Dodawanie linii", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Models.AddingLine addingLine = new Models.AddingLine();
                    addingLine.AddLine(lineNumber, isLooping);
                } else {
                    line_name.Focus();
                    groupBox1.Focus();
                }

            }
        }

        private void DodawanieNowejLinii_Load(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void line_name_TextChanged(object sender, EventArgs e) {

        }

        private void line_name_TextChanged_1(object sender, EventArgs e) {

        }
        private void line_name_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(line_name.Text)) {
                errorProvider1.SetError(line_name, "Nie wpisano linii");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(line_name, null);
                ErrorIsOn = false;
            }
        }
        private void groupBox1_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(line_name.Text)) {
                errorProvider1.SetError(groupBox1, "Nie wybrano odpowiedzi");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(groupBox1, null);
                ErrorIsOn = false;
            }
        }
    }
}
