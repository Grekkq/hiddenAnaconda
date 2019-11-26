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

        // przesuwanie okna
        private void Move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        // akcje po wjechaniu na przycisk X
        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.hover_exitbutton(exit);

        // ajkcje po zjechaniu z przycisku X
        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.leave_exitbutton(exit);

        // akcje po kliknięciu Anuluj
        private void Cancel_Click(object sender, EventArgs e) => this.Close();

        // akcje po kliknięciu przycisku X
        private void Exit_Click(object sender, EventArgs e) => this.Close();

        private void PrzypisywanieKierowcowPojazdowDoRealizacji_Load(object sender, EventArgs e) {

        }

        // akcje po kliknięciu Przypisz
        private void Save_Click(object sender, EventArgs e) {
            // walidacja danych i zmykanie okna w wypadku powodzenia
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


        // pokazywanie wybierania kursu po wybraniu linii
        private void LiniaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kursSelectionLabel.Show();
            kursSelectionComboBox.Show();
        }

        // pokazywanie wyboru kierowcy i pojazdu po wybraniu kursu
        private void KursSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kierowcaSelectionLabel.Show();
            kierowcaSelectionComboBox.Show();
            pojazdSelectionLabel.Show();
            pojazdSelectionComboBox.Show();
        }
    }
}
