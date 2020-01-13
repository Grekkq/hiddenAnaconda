using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class EkranLogowania : Form {
        public EkranLogowania() {
            InitializeComponent();
        }

        SharedView sharedView = new SharedView();
        public static string permissionLevel;
        public static string AccountName;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this,keyData);
        }

        private void TurnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.Hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.Leave_exitbutton(exit);

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void EkranLogowania_Load(object sender, EventArgs e) {
            this.textBox2.Enter += new EventHandler(textBox2_Enter);
            this.textBox2.Leave += new EventHandler(textBox2_Leave);
            this.textBox1.Enter += new EventHandler(textBox1_Enter);
            this.textBox1.Leave += new EventHandler(textBox1_Leave);
            textBox2.PasswordChar = ' ';
            textBox2_SetText();
            textBox1_SetText();
            this.ActiveControl = this.textBox1;
            exit.TabStop = false;
            help.TabStop = false;
            button3.TabStop = false;
        }

        protected void textBox2_SetText() {
            this.textBox2.Text = " Hasło";
            textBox2.ForeColor = Color.Gray;
            textBox2.PasswordChar = '\0';
        }

        protected void textBox1_SetText() {
            this.textBox1.Text = " Nazwa użytkownika";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e) {
            if (textBox2.ForeColor == Color.Black)
                return;
            textBox2.Text = "";
            textBox2.PasswordChar = '⚫';
            textBox2.ForeColor = Color.Black;
        }

        private void textBox1_Enter(object sender, EventArgs e) {
            if (textBox1.ForeColor == Color.Black)
                return;
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e) {
            //textBox2.PasswordChar = '\0';
            if (textBox2.Text.Trim() == "")
                textBox2_SetText();

        }

        private void textBox1_Leave(object sender, EventArgs e) {
            if (textBox1.Text.Trim() == "")
                textBox1_SetText();
        }

        private void button3_Click(object sender, EventArgs e) {
            using (Views.AboutProject InnerForm = new Views.AboutProject()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void button1_Click(object sender, EventArgs e) {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == " Nazwa użytkownika") {
                MessageBox.Show("Nie podano nazwy użytkownika.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (password == " Hasło") {
                MessageBox.Show("Nie podano hasła.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Models.ApplicationUser login = new Models.ApplicationUser();
                if (login.LoginUser(username, password)) {
                    if (login.GetUserStatus(username)) {
                        AccountName = username;
                        permissionLevel = Constants.TranslatePermissionLevel(login.GetPremissionLevel(username));
                        this.Hide();
                        Form frm = new WybórEkranu();
                        frm.ShowDialog();
                        this.Close();
                    } else {
                        MessageBox.Show("Użytkownik, na którego konto próbujesz się zalogować jest nieaktywny. Aby odzyskać dostęp skontaktuj się z administratorem.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło!", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void textBox2_loginButtonClick(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            }

        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == (char) 13) {
                button1_Click(this, new EventArgs());
            }
        }

        private void help_Click(object sender, EventArgs e) {

            Help.ShowHelp(this, "../../Resources/Help/Pomoc.chm");
            
        }
    }
}
