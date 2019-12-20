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
    public partial class DodawaniePojazdow : Form {
        bool ErrorIsOn = false;
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

        public DodawaniePojazdow() {
            InitializeComponent();
            year_number.Format = DateTimePickerFormat.Custom;
            year_number.CustomFormat = "yyyy";
            year_number.ShowUpDown = true;
        }
        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e) {
            this.Close();
        }
        private void mark_name_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char) Keys.Back || (e.KeyChar == '-'))
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }
        private void mark_name_TextChanged(object sender, EventArgs e) {
            mark_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.mark_name.Text);
            mark_name.Select(mark_name.Text.Length, 0);
        }
        private void mark_name_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(mark_name.Text)) {
                errorProvider1.SetError(mark_name, "Nie wpisano marki");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(mark_name, null);
                ErrorIsOn = false;
            }
        }
        private void create_Click(object sender, EventArgs e) {
            var marka = mark_name.Text;
            var model = model_name.Text;
            var numerRejestracyjny = plate_numer.Text;

            if (yes.Checked == false && no.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                model_name.Focus();
                vin_number.Focus();
                plate_numer.Focus();
                year_number.Focus();
                mark_name.Focus();
            } else if (yes2.Checked == false && no1.Checked == false) {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                model_name.Focus();
                vin_number.Focus();
                plate_numer.Focus();
                year_number.Focus();
                mark_name.Focus();
            }
            if ((!string.IsNullOrEmpty(vin_number.Text) && !string.IsNullOrEmpty(plate_numer.Text) && (yes2.Checked == true || no1.Checked == true) && (yes.Checked == true || no.Checked == true) && !string.IsNullOrEmpty(model_name.Text) && ErrorIsOn == false)) {
                var plate = plate_numer.Text;
                var vin = vin_number.Text;
                var modelNumber = model_name.Text;
                var brand = mark_name.Text;
                var year = year_number.Value.Date;
                var isLow = false;
                var isWork = false;

                if (yes.Checked == true)
                    isLow = true;
                if (yes2.Checked == true)
                    isWork = true;

                var result = MessageBox.Show("Na pewno chcesz utworzyć pojazd " + brand + " " + modelNumber + " rocznik " + year_number.Value.Year + ", numer rejestracyjny: " + plate + ", numer VIN: " + vin + " ?", "Dodanie kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Models.AddingVehicles addingVehicles = new Models.AddingVehicles();
                    addingVehicles.AddVehicle(plate, vin, modelNumber, brand, year, isLow, isWork);
                } else {
                    model_name.Focus();
                    vin_number.Focus();
                    plate_numer.Focus();
                    mark_name.Focus();
                }
            }
        }

        private void vin_number_TextChanged(object sender, KeyPressEventArgs e) {
            if ((e.KeyChar == 'I') || (e.KeyChar == 'i') || (e.KeyChar == 'o') || (e.KeyChar == 'O') || (e.KeyChar == 'q') || (e.KeyChar == 'Q'))
                e.Handled = true;
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void year_number_Validating(object sender, CancelEventArgs e) {
            if (year_number.Value.Year > DateTime.Today.Year) {
                errorProvider1.SetError(year_number, "Nieprawidłowy rok produkcji");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(year_number, null);
                ErrorIsOn = false;
            }
        }

        private void vin_number_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(vin_number.Text)) {
                errorProvider1.SetError(vin_number, "Nie wpisano numeru VIN");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(vin_number, null);
                ErrorIsOn = false;
            }
        }

        private void plate_number_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void model_name_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back || (e.KeyChar == ' ') || (e.KeyChar == '-') || (e.KeyChar == '+'))
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void model_name_TextChanged(object sender, EventArgs e) {
            model_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.model_name.Text);
            model_name.Select(model_name.Text.Length, 0);
        }

        private void model_name_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(model_name.Text)) {
                errorProvider1.SetError(model_name, "Nie wpisano modelu");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(model_name, null);
                ErrorIsOn = false;
            }
        }

        private void plate_numer_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(plate_numer.Text)) {
                errorProvider1.SetError(plate_numer, "Nie wpisano rejestracji");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(plate_numer, null);
                ErrorIsOn = false;
            }
        }
    }
}