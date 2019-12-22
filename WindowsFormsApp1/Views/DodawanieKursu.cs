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

    public partial class DodawanieKursu : Form {
        bool ErrorIsOn = false;
        SharedView sharedView = new SharedView();
        Models.AddTrail addTrail = new Models.AddTrail();

        private void Move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(exit);
        }

        private void Leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(exit);
        }

        public DodawanieKursu() {
            InitializeComponent();
        }
        private void TurnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void Close_on_click(object sender, EventArgs e) {
            this.Close();
        }

        private void DodawanieKursu_Load(object sender, EventArgs e) {
            label_trasa.Visible = false;
            label_rodzajKursu.Visible = false;
            comboBox_trasa.Visible = false;
            comboBox_rodzajKursu.Visible = false;

            this.comboBox_rodzajKursu.Items.Clear();
            this.comboBox_rodzajKursu.Items.Add("wolny");
            this.comboBox_rodzajKursu.Items.Add("roboczy");
            this.comboBox_rodzajKursu.Items.Add("świąteczny");
            //dane testowe
            this.comboBox_trasa.Items.Clear();
            this.comboBox_trasa.Items.Add("1");
            // wczytaj linie do wyboru
            sharedView.LoadLinesIntoComboBox(comboBox_linia);
            sharedView.LoadDayTypesIntoComboBox(comboBox_rodzajKursu);
        }

        private void Create_Click(object sender, EventArgs e) {
            if (ErrorIsOn == false) {
                if (MessageBox.Show("Na pewno chcesz dodać kurs?", "Dodanie kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    const string message = "Pomyślnie utworzono nowy kurs";
                    const string caption = "Sukces";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK) {
                        this.Close();
                    }
                }
            } else {
                comboBox_linia.Focus();
                comboBox_rodzajKursu.Focus();
                comboBox_trasa.Focus();
            }
        }

        private void C_number_TextChanged(object sender, KeyPressEventArgs e) {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void ComboBox_linia_SelectedIndexChanged(object sender, EventArgs e) {
            label_trasa.Visible = true;
            comboBox_trasa.Visible = true;
            comboBox_trasa.Focus();
            sharedView.LoadRouteNumberIntoComboBox(comboBox_trasa, Int32.Parse(comboBox_linia.Text));
        }

        private void ComboBox_trasa_SelectedIndexChanged(object sender, EventArgs e) {
            label_rodzajKursu.Visible = true;
            comboBox_rodzajKursu.Visible = true;
            comboBox_rodzajKursu.Focus();
        }

        private void Line_choose_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_linia.Text)) {
                errorProvider1.SetError(comboBox_linia, "Nie wybrano linii");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_linia, null);
                ErrorIsOn = false;
            }
        }

        private void ComboBox_trasa_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_trasa.Text)) {
                errorProvider1.SetError(comboBox_trasa, "Nie wybrano trasy");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_trasa, null);
                ErrorIsOn = false;
            }
        }

        private void ComboBox_rodzajKursu_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(comboBox_rodzajKursu.Text)) {
                errorProvider1.SetError(comboBox_rodzajKursu, "Nie wybrano rodzaju kursu");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(comboBox_rodzajKursu, null);
                ErrorIsOn = false;
            }
        }
    }
}
