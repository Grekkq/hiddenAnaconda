using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class planowanieRealizacjiKursu : Form {

        public planowanieRealizacjiKursu() {
            InitializeComponent();
            kursSelectionLabel.Hide();
            kursSelectionComboBox.Hide();
            kierowcaSelectionLabel.Hide();
            kierowcaSelectionComboBox.Hide();
            pojazdSelectionLabel.Hide();
            pojazdSelectionComboBox.Hide();
        }

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

        private void przypisywanieKierowcowPojazdowDoRealizacji_Load(object sender, EventArgs e) {

        }


        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(liniaSelectionComboBox.Text))
                MessageBox.Show("Nie wybrano lini", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(kursSelectionComboBox.Text))
                MessageBox.Show("Nie wybrano kursu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(kierowcaSelectionComboBox.Text))
                MessageBox.Show("Nie wybrano kierowcy", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(pojazdSelectionComboBox.Text))
                MessageBox.Show("Nie wybrano pojazdu", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                var result = MessageBox.Show("Pomyślnie przypisano <kierowca> i <pojazd> do <kurs>", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    this.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void liniaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kursSelectionLabel.Show();
            kursSelectionComboBox.Show();
        }

        private void kursSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kierowcaSelectionLabel.Show();
            kierowcaSelectionComboBox.Show();
            pojazdSelectionLabel.Show();
            pojazdSelectionComboBox.Show();
        }
    }
}
