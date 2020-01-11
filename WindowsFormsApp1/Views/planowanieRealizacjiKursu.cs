using hiddenAnaconda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class planowanieRealizacjiKursu : Form {

        bool ErrorIsOn, ErrorKursIsOn, ErrorKierIsOn, ErrorPojIsOn = true;
        string selectetDayType;
        TrailRealization trailRealization = new TrailRealization();

        public planowanieRealizacjiKursu() {
            InitializeComponent();
            kursSelectionLabel.Hide();
            kursSelectionComboBox.Hide();
            kierowcaSelectionLabel.Hide();
            kierowcaSelectionComboBox.Hide();
            pojazdSelectionLabel.Hide();
            pojazdSelectionComboBox.Hide();
            sharedView.LoadLinesIntoComboBox(this.liniaSelectionComboBox);
            try {
                selectetDayType = sharedView.CheckDayType(dataKursuPicker.SelectionRange.Start);
            } catch (Exception exception) {
                Debug.Print("Failed to read day type for picked date.\n{0}", exception);
                MessageBox.Show("Uwaga! \nDla dzisiejszego dnia nie został przypisany jego rodzaj.");
            }

        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        // przesuwanie okna
        private void Move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        // akcje po wjechaniu na przycisk X
        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.Hover_exitbutton(exit);

        // ajkcje po zjechaniu z przycisku X
        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.Leave_exitbutton(exit);

        // akcje po kliknięciu Anuluj
        private void Cancel_Click(object sender, EventArgs e) => this.Close();

        // akcje po kliknięciu przycisku X
        private void Exit_Click(object sender, EventArgs e) => this.Close();

        private void PrzypisywanieKierowcowPojazdowDoRealizacji_Load(object sender, EventArgs e) {
            this.AcceptButton = save;
        }

        // akcje po kliknięciu Przypisz
        private void Save_Click(object sender, EventArgs e) {
            pojazdSelectionComboBox.Focus();
            liniaSelectionComboBox.Focus();
            kierowcaSelectionComboBox.Focus();
            kursSelectionComboBox.Focus();
            liniaSelectionComboBox.Focus();

            if ((!string.IsNullOrEmpty(pojazdSelectionComboBox.Text) && !string.IsNullOrEmpty(kierowcaSelectionComboBox.Text) && !string.IsNullOrEmpty(liniaSelectionComboBox.Text) && !string.IsNullOrEmpty(kursSelectionComboBox.Text)) && ErrorPojIsOn == false && ErrorKursIsOn == false && ErrorKierIsOn == false && ErrorIsOn == false) {
                var result = MessageBox.Show("Czy na pewno chcesz przypisać linię: ''" + liniaSelectionComboBox.Text + "'' z kierowcą: ''" + kierowcaSelectionComboBox.Text + "'' o pojeździe: ''" + pojazdSelectionComboBox.Text + "'' do kursu: ''" + kursSelectionComboBox.Text + "'' w dniu " + dataKursuPicker.SelectionStart + "?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    //WPISANIE DO 
                    trailRealization.AddTrailRealizationToDb(Int32.Parse(liniaSelectionComboBox.Text), Int32.Parse(kursSelectionComboBox.Text.Substring(0, kursSelectionComboBox.Text.IndexOf(','))), kierowcaSelectionComboBox.Text, pojazdSelectionComboBox.Text, dataKursuPicker.SelectionRange.Start);
                    this.Close();
                }
            } else {
                pojazdSelectionComboBox.Focus();
                liniaSelectionComboBox.Focus();
                kierowcaSelectionComboBox.Focus();
                kursSelectionComboBox.Focus();
                liniaSelectionComboBox.Focus();
            }

        }


        // pokazywanie wybierania kursu po wybraniu linii
        private void LiniaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kursSelectionLabel.Show();
            kursSelectionComboBox.Show();
            kursSelectionComboBox.SelectedIndex = -1;
            sharedView.LoadTrailAssignmentIntoComboBox(kursSelectionComboBox, Int32.Parse(liniaSelectionComboBox.Text), selectetDayType, dataKursuPicker.SelectionRange.Start);
        }

        private void kierowcaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void kierowcaSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(kierowcaSelectionComboBox.Text)) {
                errorProvider1.SetError(kierowcaSelectionComboBox, "Nie wybrano kierowcy");
                ErrorKierIsOn = true;
            } else {
                errorProvider1.SetError(kierowcaSelectionComboBox, null);
                ErrorKierIsOn = false;
            }
        }

        private void pojazdSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(pojazdSelectionComboBox.Text)) {
                errorProvider1.SetError(pojazdSelectionComboBox, "Nie wybrano pojazdu");
                ErrorPojIsOn = true;
            } else {
                errorProvider1.SetError(pojazdSelectionComboBox, null);
                ErrorPojIsOn = false;
            }
        }

        private void dataKursuPicker_DateChanged(object sender, DateRangeEventArgs e) {
            try {
                selectetDayType = sharedView.CheckDayType(dataKursuPicker.SelectionRange.Start);
            } catch (Exception exception) {
                Debug.Print("Failed to read day type for picked date.\n{0}", exception);
                MessageBox.Show("Upewnij się że do wybranego dnia został przypisany rodzaj dnia.");
            }
            kursSelectionComboBox.SelectedIndex = -1;
            if (liniaSelectionComboBox.SelectedIndex!=-1)
                sharedView.LoadTrailAssignmentIntoComboBox(kursSelectionComboBox, Int32.Parse(liniaSelectionComboBox.Text), selectetDayType, dataKursuPicker.SelectionRange.Start);
        }

        private void LiniaSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(liniaSelectionComboBox.Text)) {
                errorProvider1.SetError(liniaSelectionComboBox, "Nie wybrano linii");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(liniaSelectionComboBox, null);
                ErrorIsOn = false;
            }
        }
        // pokazywanie wyboru kierowcy i pojazdu po wybraniu kursu
        private void KursSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            kierowcaSelectionLabel.Show();
            kierowcaSelectionComboBox.Show();
            pojazdSelectionLabel.Show();
            pojazdSelectionComboBox.Show();
            if(kursSelectionComboBox.SelectedIndex!=-1) {
                trailRealization.LoadDriversIntoComboBox(kierowcaSelectionComboBox, Int32.Parse(liniaSelectionComboBox.Text), Int32.Parse(kursSelectionComboBox.Text.Substring(0, kursSelectionComboBox.Text.IndexOf(','))), dataKursuPicker.SelectionRange.Start);
                trailRealization.LoadVehiclesIntoComboBox(pojazdSelectionComboBox, Int32.Parse(liniaSelectionComboBox.Text), Int32.Parse(kursSelectionComboBox.Text.Substring(0, kursSelectionComboBox.Text.IndexOf(','))), dataKursuPicker.SelectionRange.Start);
            }
        }

        private void KursSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(kursSelectionComboBox.Text)) {
                errorProvider1.SetError(kursSelectionComboBox, "Nie wybrano numeru kursu");
                ErrorKursIsOn = true;
            } else {
                errorProvider1.SetError(kursSelectionComboBox, null);
                ErrorKursIsOn = false;
            }
        }


    }
}


