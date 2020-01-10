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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void MoveWindow(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void Leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        public DodawanieNowejLinii() {
            InitializeComponent();
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void TurnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void Close_on_click(object sender, EventArgs e) {
            this.Close();
        }

        private void Line_name_TextChanged(object sender, KeyPressEventArgs e) {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        // walidacja pól i zamknięcie okna
        private void CreateClick(object sender, EventArgs e) {

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
                    this.Close();
                } else {
                    line_name.Focus();
                    groupBox1.Focus();
                }
            }
        }

        private void Line_name_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(line_name.Text)) {
                errorProvider1.SetError(line_name, "Nie wpisano linii");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(line_name, null);
                ErrorIsOn = false;
            }
        }
        private void GroupBox1_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(groupBox1.Text) || yes.Checked == false && no.Checked == false) {
                errorProvider1.SetError(groupBox1, "Nie wybrano odpowiedzi");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(groupBox1, null);
                ErrorIsOn = false;
            }
        }

        private void no_CheckedChanged(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
