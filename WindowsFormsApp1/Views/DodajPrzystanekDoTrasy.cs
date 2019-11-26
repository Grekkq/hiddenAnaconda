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

        Models.routeElementModel przystanek;
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
            przystanek = new Models.routeElementModel(this.stopName.Text, this.cityName.Text, this.arrivalTime.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Models.routeElementModel GetStop {
            get { return przystanek; }
        }

    }
}
