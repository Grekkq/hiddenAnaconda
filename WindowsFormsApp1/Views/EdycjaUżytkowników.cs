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
    public partial class EdycjaUżytkowników : Form {
        public EdycjaUżytkowników() {
            InitializeComponent();
        }

        SharedView sharedView = new SharedView();

        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
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

        private void EdycjaUżytkowników_Load(object sender, EventArgs e) {
            this.comboBox_uzytkownik.Items.Clear();
            this.comboBox_uzytkownik.Items.Add("Grekkq");
            this.comboBox_uzytkownik.Items.Add("nieDam");
            this.comboBox_uzytkownik.Items.Add("h1mit");

            groupBox_status_uprawnienia.Visible = false;
            radio_status.Visible = false;
            radio_uprawnienia.Visible = false;

            groupBox_status.Visible = false;
            radioButton_aktywne.Visible = false;
            radioButton_nieaktywne.Visible = false;

            label_uprawnienia.Visible = false;
            comboBox_uprawnienia.Visible = false;
        }

        private void radio_status_CheckedChanged(object sender, EventArgs e) {

            label_uprawnienia.Visible = false;
            comboBox_uprawnienia.Visible = false;

            groupBox_status.Visible = true;
            radioButton_aktywne.Visible = true;
            radioButton_nieaktywne.Visible = true;
        }

        private void comboBox_uzytkownik_SelectedIndexChanged(object sender, EventArgs e) {
            groupBox_status_uprawnienia.Visible = true;
            radio_status.Visible = true;
            radio_uprawnienia.Visible = true;
        }

        private void radio_uprawnienia_CheckedChanged(object sender, EventArgs e) {
            groupBox_status.Visible = false;
            radioButton_aktywne.Visible = false;
            radioButton_nieaktywne.Visible = false;

            label_uprawnienia.Visible = true;
            comboBox_uprawnienia.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
