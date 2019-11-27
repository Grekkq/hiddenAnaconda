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
    public partial class DodawanieKursu : Form {

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

        public DodawanieKursu() {
            InitializeComponent();
        }
        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e) {
            this.Close();
        }



        private void label7_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void create_Click(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(line_choose.Text))) {
                MessageBox.Show("Nie wybrano numeru lini", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrEmpty(date_name.Text)) {
                MessageBox.Show("Nie wprowadzono nowej daty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrEmpty(c_number.Text)) {
                MessageBox.Show("Nie wprowadzono numeru kursu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrEmpty(hour_name.Text)) {
                MessageBox.Show("Nie wprowadzono poprawnie godziny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                const string message = "Pomyślnie utworzono nowy pojazd";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
        private void DodawanieKursu_Load(object sender, EventArgs e) {

        }
    }
}
