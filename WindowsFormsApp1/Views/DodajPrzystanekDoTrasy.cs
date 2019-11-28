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
    public partial class DodajPrzystanekDoTrasy : Form {
        public DodajPrzystanekDoTrasy() {
            InitializeComponent();
        }

        public DodajPrzystanekDoTrasy(Models.routeElementModel busStop) {
            InitializeComponent();
            this.stopName.Text = busStop.Name;
            this.cityName.Text = busStop.City;
            this.arrivalTime.Text = busStop.ArrivalTime;
        }

        Models.routeElementModel busStop;
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            sharedView.moveWindow(sender, e, Handle);
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.leave_exitbutton(exit);
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

        }

        private void Dodaj_Click(object sender, EventArgs e) {
            busStop = new Models.routeElementModel(this.stopName.Text, this.cityName.Text, this.arrivalTime.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Models.routeElementModel GetStop {
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
            if ((e.KeyChar == '.' && arrivalTime.SelectionStart == 0) || (e.KeyChar == ':' && arrivalTime.SelectionStart == 0))
                e.Handled = true;

        }

        private void cityName_TextChanged(object sender, KeyPressEventArgs e)
        {
           
              e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            
        }

        private void cityName_TextChanged(object sender, EventArgs e)
        {
            cityName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.cityName.Text);
            cityName.Select(cityName.Text.Length, 0);
        }

        private void stopName_TextChanged(object sender, EventArgs e)
        {
            stopName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.stopName.Text);
            stopName.Select(stopName.Text.Length, 0);
        }

        private void arrivalTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
