using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace hiddenAnaconda.Views {
    public partial class DodajPrzystanekDoTrasy : Form {
        Models.routeElementModel busStop = new Models.routeElementModel();
        SharedView sharedView = new SharedView();
        bool ErrorIsOn = false;
        public DodajPrzystanekDoTrasy() {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        public DodajPrzystanekDoTrasy(Models.routeElementModel data) {
            InitializeComponent();
            this.busStop.Name = data.Name;
            this.busStop.City = data.City;
            this.busStop.ArrivalTime = data.ArrivalTime;
            this.busStop.Way = data.Way;
            sharedView.LoadCitiesIntoComboBox(comboBox_miasto);
            sharedView.LoadBusStopsIntoComboBox(comboBox_przystanek, busStop.City);
            sharedView.LoadTrailDirectionIntoComboBox(comboBox_kierunek, busStop.Name, busStop.City);
            comboBox_miasto.SelectedIndex = comboBox_miasto.FindString(busStop.City);
            comboBox_przystanek.SelectedIndex = comboBox_przystanek.FindString(busStop.Name);
            comboBox_kierunek.SelectedIndex = comboBox_kierunek.FindString(busStop.Way);
        }

        private void move_window(object sender, MouseEventArgs e) {
            sharedView.MoveWindow(sender, e, Handle);
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void TurnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void Close_on_click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DodajPrzystanekDoTrasy_Load(object sender, EventArgs e) {
            sharedView.LoadCitiesIntoComboBox(comboBox_miasto);
            comboBox_miasto.Focus();
        }

        private void Dodaj_Click(object sender, EventArgs e) {
            if ((!string.IsNullOrEmpty(textbox_time.Text) && !string.IsNullOrEmpty(comboBox_kierunek.Text) && !string.IsNullOrEmpty(comboBox_przystanek.Text) && !string.IsNullOrEmpty(comboBox_miasto.Text) && ErrorIsOn == false)) {
                if (MessageBox.Show("Na pewno chcesz dodać przystanek?", "Dodanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    busStop = new Models.routeElementModel(this.comboBox_przystanek.Text, this.comboBox_miasto.Text, this.textbox_time.Text, this.comboBox_kierunek.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } else {
                textbox_time.Focus();
                comboBox_miasto.Focus();
                comboBox_kierunek.Focus();
                comboBox_przystanek.Focus();
            }


        }

        public Models.routeElementModel GetStop {
            get { return busStop; }
        }

        private void arrivalTime_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == ':') || (e.KeyChar == '.'))
                base.OnKeyPress(e);
            else
                e.Handled = true;

            // pozwala na tylko jeden przecinek w słowie
            if ((e.KeyChar == '.' && (sender as TextBox).Text.Contains('.')) || (e.KeyChar == ':' && (sender as TextBox).Text.Contains(':')) || (e.KeyChar == '.' && (sender as TextBox).Text.Contains(':')) || (e.KeyChar == ':' && (sender as TextBox).Text.Contains('.')))
                e.Handled = true;

            // nie pozwala na przecinek na początku
            if ((e.KeyChar == '.' && textbox_time.SelectionStart == 0) || (e.KeyChar == ':' && textbox_time.SelectionStart == 0))
                e.Handled = true;

        }

        private void cityName_TextChanged(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void arrivalTime_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(textbox_time.Text)) {
                errorProvider1.SetError(textbox_time, "Nie wpisano godziny");
                ErrorIsOn = true;
            } else if (!Constants.ValidateTimeFormat.IsMatch(textbox_time.Text)) {
                errorProvider1.SetError(textbox_time, "Niepoprawnie wpisana godzina. Akceptowany format czasu: GG:MM");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(textbox_time, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_miasto_SelectedIndexChanged(object sender, EventArgs e) {
            sharedView.LoadBusStopsIntoComboBox(comboBox_przystanek, comboBox_miasto.GetItemText(comboBox_miasto.SelectedItem));
            comboBox_przystanek.Focus();
        }

        private void comboBox_przystanek_SelectedIndexChanged(object sender, EventArgs e) {
            sharedView.LoadTrailDirectionIntoComboBox(comboBox_kierunek, comboBox_przystanek.GetItemText(comboBox_przystanek.SelectedItem), comboBox_miasto.GetItemText(comboBox_miasto.SelectedItem));
            comboBox_kierunek.Focus();
        }

        private void comboBox_przystanek_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_przystanek.Text)) {
                errorProvider1.SetError(comboBox_przystanek, "Nie wybrano przystanku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_przystanek, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_miasto_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_miasto.Text)) {
                errorProvider1.SetError(comboBox_miasto, "Nie wybrano miasta");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_miasto, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_kierunek_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBox_kierunek_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_kierunek.Text)) {
                errorProvider2.SetError(comboBox_kierunek, "Nie wybrano kierunku");
                ErrorIsOn = true;
            } else {
                errorProvider2.SetError(comboBox_kierunek, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_kierunek_SelectedIndexChanged_1(object sender, EventArgs e) {
            textbox_time.Focus();
        }
    }
}
