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
    public partial class TworzenieRaportu : Form {
        public TworzenieRaportu() {
            InitializeComponent();
        }

        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        bool ErrorIsOn = false;

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        private void TworzenieRaportu_Load(object sender, EventArgs e) {
            this.AcceptButton = create;
            label_przystanek.Visible = false;
            comboBox_przystanek.Visible = false;
            label_kierunek.Visible = false;
            comboBox_kierunek.Visible = false;

            //przykladowe dane
            this.comboBox_miasto.Items.Clear();
            this.comboBox_przystanek.Items.Clear();
            this.comboBox_kierunek.Items.Clear();
            this.comboBox_miasto.Items.Add("Katowice");
            this.comboBox_miasto.Items.Add("Gliwice");
            this.comboBox_miasto.Items.Add("Knurów");
            this.comboBox_miasto.Items.Add("Zabrze");
            this.comboBox_miasto.Items.Add("Radzionków");
            this.comboBox_przystanek.Items.Add("Szpitalna");
            this.comboBox_przystanek.Items.Add("Cegielnia");
            this.comboBox_przystanek.Items.Add("Wrocławska");
            this.comboBox_przystanek.Items.Add("Nowy Świat");
            this.comboBox_przystanek.Items.Add("Szpitalna");
            this.comboBox_kierunek.Items.Add("Gliwice-Knurów");
            this.comboBox_kierunek.Items.Add("Knurów-Gliwice");
            this.comboBox_kierunek.Items.Add("Gliwice-Zabrze");
            this.comboBox_kierunek.Items.Add("Zabrze-Gliwice");

            sharedView.LoadCitiesIntoComboBox(comboBox_miasto);
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboBox_przystanek_SelectedIndexChanged(object sender, EventArgs e) {
            label_kierunek.Visible = true;
            comboBox_kierunek.Visible = true;
            comboBox_kierunek.Focus();
            sharedView.LoadTrailDirectionIntoComboBox(comboBox_kierunek, comboBox_przystanek.Text, comboBox_miasto.Text);
        }

        private void comboBox_miasto_SelectedIndexChanged(object sender, EventArgs e) {
            label_przystanek.Visible = true;
            comboBox_przystanek.Visible = true;
            comboBox_przystanek.Focus();
            sharedView.LoadBusStopsIntoComboBox(comboBox_przystanek, comboBox_miasto.Text);
            comboBox_kierunek.Items.Clear();
        }

        private void comboBox_miasto_Validating(object sender, CancelEventArgs e) {
            if (comboBox_miasto.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_miasto, "Nie wybrano miasta");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_miasto, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_przystanek_Validating(object sender, CancelEventArgs e) {
            if (comboBox_przystanek.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_przystanek, "Nie wybrano przystanku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_przystanek, null);
                ErrorIsOn = false;
            }
        }

        private void comboBox_kierunek_Validating(object sender, CancelEventArgs e) {
            if (comboBox_kierunek.SelectedIndex == -1) {
                errorProvider1.SetError(comboBox_kierunek, "Nie wybrano kierunku");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_kierunek, null);
                ErrorIsOn = false;
            }
        }

        private void create_Click(object sender, EventArgs e) {
            if (ErrorIsOn == false) {
                Dictionary<string, string> argsForTimeTableConstructor = new Dictionary<string, string>();
                argsForTimeTableConstructor.Add(Constants.BusStopCityName, comboBox_miasto.Text);
                argsForTimeTableConstructor.Add(Constants.BusStopName, comboBox_przystanek.Text);
                argsForTimeTableConstructor.Add(Constants.BusStopWay, comboBox_kierunek.Text);
                using (Views.ZapiszJako InnerForm = new Views.ZapiszJako(argsForTimeTableConstructor)) {
                    if (InnerForm.ShowDialog() == DialogResult.OK) {

                    }
                };
            }
        }
    }
}
