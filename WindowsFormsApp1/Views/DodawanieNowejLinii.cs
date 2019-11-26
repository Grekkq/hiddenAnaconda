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
    public partial class DodawanieNowejLinii : Form {

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

        private void nazwa_linii_TextChanged(object sender, EventArgs e) {

        }

        // walidacja pól i zamknięcie okna
        private void create_Click(object sender, EventArgs e) {
            if ((yes.Checked == false && no.Checked == false) && (string.IsNullOrEmpty(line_name.Text))) {
                MessageBox.Show("Nie wypełniono formularza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrEmpty(line_name.Text)) {
                MessageBox.Show("Nieprawidłowa nazwa linii.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                const string message = "Pomyślnie utworzono nową linie";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void DodawanieNowejLinii_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
