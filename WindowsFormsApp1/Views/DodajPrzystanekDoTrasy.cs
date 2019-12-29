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
    public partial class DodajPrzystanekDoTrasy : Form
    {
        bool ErrorIsOn = false;
        public DodajPrzystanekDoTrasy()
        {
            InitializeComponent();
        }

        public DodajPrzystanekDoTrasy(Models.routeElementModel busStop)
        {
            InitializeComponent();
            //this.stopName.Text = busStop.Name;
            //this.cityName.Text = busStop.City;
            //this.textbox_time.Text = busStop.ArrivalTime;
        }

        Models.routeElementModel busStop;
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e)
        {
            sharedView.MoveWindow(sender, e, Handle);
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.Leave_exitbutton(exit);
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void TurnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPrzystanekDoTrasy_Load(object sender, EventArgs e)
        {
            //przykładowe dane
            this.comboBox_miasto.Items.Clear();
            this.comboBox_miasto.Items.Add("Sosnowiec");
            this.comboBox_przystanek.Items.Clear();
            this.comboBox_przystanek.Items.Add("Remiza");
            this.comboBox_kierunek.Items.Clear();
            this.comboBox_kierunek.Items.Add("Sosnowiec-Katowice");
            this.comboBox_kierunek.Items.Add("Katowice-Sosnowiec");

            comboBox_miasto.Focus();
            label_przystanek.Visible = false;
            label_kierunek.Visible = false;
            label_czas.Visible = false;
            label_timedescription.Visible = false;

            comboBox_przystanek.Visible = false;
            comboBox_kierunek.Visible = false;
            textbox_time.Visible = false;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textbox_time.Text) && !string.IsNullOrEmpty(comboBox_kierunek.Text) && !string.IsNullOrEmpty(comboBox_przystanek.Text) && !string.IsNullOrEmpty(comboBox_miasto.Text) && ErrorIsOn == false))
            {
                if (MessageBox.Show("Na pewno chcesz dodać przystanek?", "Dodanie przystanku", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    busStop = new Models.routeElementModel(this.comboBox_przystanek.Text, this.comboBox_miasto.Text, this.textbox_time.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                textbox_time.Focus();
                comboBox_miasto.Focus();
                comboBox_kierunek.Focus();
                comboBox_przystanek.Focus();
            }

            
        }

        public Models.routeElementModel GetStop
        {
            get { return busStop; }
        }

        private void arrivalTime_TextChanged(object sender, KeyPressEventArgs e)
        {
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

        private void cityName_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void arrivalTime_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");

            if (string.IsNullOrEmpty(textbox_time.Text))
            {
                errorProvider1.SetError(textbox_time, "Nie wpisano godziny");
                ErrorIsOn = true;
            }
            else if (!r.IsMatch(textbox_time.Text))
            {
                errorProvider1.SetError(textbox_time, "Niepoprawnie wpisana godzina");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(textbox_time, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_miasto_SelectedIndexChanged(object sender, EventArgs e) {
            label_przystanek.Visible = true;
            comboBox_przystanek.Visible = true;
            comboBox_przystanek.Focus();
            comboBox_kierunek.Focus();
            comboBox_kierunek.Visible = true;
            label_kierunek.Visible = true;
        }

        private void comboBox_przystanek_SelectedIndexChanged(object sender, EventArgs e) {
            label_czas.Visible = true;
            textbox_time.Visible = true;
            label_timedescription.Visible = true;
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

        private void comboBox_kierunek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_kierunek_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_kierunek.Text))
            {
                errorProvider2.SetError(comboBox_kierunek, "Nie wybrano kierunku");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider2.SetError(comboBox_kierunek, null);
                ErrorIsOn = false;
            }
        }

    }
}
