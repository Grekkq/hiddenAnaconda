using System;
using System.ComponentModel;
using System.Windows.Forms;



namespace hiddenAnaconda.Views {

    public partial class DodawanieKursu : Form {
        bool ErrorIsOn = false;
        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

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
            sharedView.LoadLinesIntoComboBox(comboBox_linia);
            sharedView.LoadDayTypesIntoComboBox(comboBox_rodzajKursu);
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

            this.AcceptButton = create;
        }

        private void Create_Click(object sender, EventArgs e) {
            comboBox_linia.Focus();
            comboBox_rodzajKursu.Focus();
            comboBox_trasa.Focus();
            if (!string.IsNullOrEmpty(comboBox_linia.Text) && !string.IsNullOrEmpty(comboBox_trasa.Text) && !string.IsNullOrEmpty(comboBox_rodzajKursu.Text) && ErrorIsOn == false) {
                if (MessageBox.Show("Na pewno chcesz dodać kurs?", "Dodanie kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    new Models.TrailAssignment(Int32.Parse(comboBox_linia.Text), Int32.Parse(comboBox_trasa.Text), comboBox_rodzajKursu.Text).AddTrailAssignment();
                    var result = MessageBox.Show("Pomyślnie utworzono nowy kurs", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            label_rodzajKursu.Visible = true;
            comboBox_rodzajKursu.Visible = true;
            comboBox_rodzajKursu.Focus();
            comboBox_rodzajKursu.SelectedIndex = -1;
            comboBox_trasa.SelectedIndex = -1;
            

        }

        private void ComboBox_trasa_SelectedIndexChanged(object sender, EventArgs e) {
            create.Focus();
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

        private void comboBox_rodzajKursu_SelectedIndexChanged(object sender, EventArgs e) {
            label_trasa.Visible = true;
            comboBox_trasa.Visible = true;
            create.Focus();
            sharedView.LoadRouteNumberIntoComboBox(comboBox_trasa, Int32.Parse(comboBox_linia.Text), comboBox_rodzajKursu.Text);
        }

        private void help_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Constants.HelpPath, HelpNavigator.Topic, "Tworzenie%20kursow.htm");
        }
    }
}
