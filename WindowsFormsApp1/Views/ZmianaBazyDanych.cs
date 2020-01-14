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
    public partial class ZmianaBazyDanych : Form {
        public ZmianaBazyDanych() {
            InitializeComponent();
            var currentDb = Models.ChangeDb.GetCurentConnectionString();
            textBoxIpAdress.Text = currentDb.Single(c=>c.Key=="IP").Value;
            textBoxDataBaseName.Text = currentDb.Single(c => c.Key == "DbName").Value;
            if(currentDb.Single(c=>c.Key=="IP").Value.Contains("local")) {
                textBoxIpAdress.Enabled = false;
                checkBoxLocal.Checked = true;
            }
            textBoxUserName.Enabled = false;
            textBoxPassword.Enabled = false;
            checkBoxIntegratedSecurity.Checked = true;
            if (!currentDb.Single(c => c.Key == "Security").Value.Contains("Integrated")) {
                checkBoxIntegratedSecurity.Checked = false;
                textBoxUserName.Enabled = true;
                textBoxPassword.Enabled = true;
                textBoxUserName.Text = currentDb.Single(c => c.Key == "UserName").Value;
                textBoxPassword.Text = currentDb.Single(c => c.Key == "Password").Value;
            }
        }

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void TurnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.Hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.Leave_exitbutton(exit);

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void Anuluj_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ZmianaBazyDanych_Load(object sender, EventArgs e) {
            textBoxPassword.PasswordChar = '⚫';
        }

        private void checkBoxLocal_CheckedChanged(object sender, EventArgs e) {
            if (!checkBoxLocal.Checked) {
                textBoxIpAdress.Enabled = true;
                textBoxIpAdress.Clear();
            } else {
                textBoxIpAdress.Enabled = false;
                textBoxIpAdress.Text = "(localdb)\\MSSQLLocalDB";
            }
        }

        private void checkBoxIntegratedSecurity_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxIntegratedSecurity.Checked) {
                textBoxUserName.Enabled = false;
                textBoxPassword.Enabled = false;
            } else {
                textBoxPassword.Enabled = true;
                textBoxUserName.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if(checkBoxIntegratedSecurity.Checked) {
                Models.ChangeDb.ChangeCurrentDb(textBoxIpAdress.Text, textBoxDataBaseName.Text);
                Application.Restart();
            } else {
                Models.ChangeDb.ChangeCurrentDb(textBoxIpAdress.Text, textBoxDataBaseName.Text, textBoxUserName.Text, textBoxPassword.Text);
                Application.Restart();
            }
        }
    }
}
