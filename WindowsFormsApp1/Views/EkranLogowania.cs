using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views
{
    public partial class EkranLogowania : Form
    {
        public EkranLogowania()
        {
            InitializeComponent();
        }


        SharedView sharedView = new SharedView();

        private void turnoffFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.leave_exitbutton(exit);


        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void EkranLogowania_Load(object sender, EventArgs e)
        {
            this.textBox2.Enter += new EventHandler(textBox2_Enter);
            this.textBox2.Leave += new EventHandler(textBox2_Leave);
            this.textBox1.Enter += new EventHandler(textBox1_Enter);
            this.textBox1.Leave += new EventHandler(textBox1_Leave);
            textBox2_SetText();
            textBox2.PasswordChar=' ';
            textBox1_SetText();
        }

        protected void textBox2_SetText()
        {
            this.textBox2.Text = " Hasło";
            textBox2.ForeColor = Color.Gray;
            textBox2.PasswordChar= '\0';
        }

        protected void textBox1_SetText()
        {
            this.textBox1.Text = " Nazwa użytkownika";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Black)
                return;
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
            textBox2.ForeColor = Color.Black;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Black)
                return;
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //textBox2.PasswordChar = '\0';
            if (textBox2.Text.Trim() == "")
                textBox2_SetText();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                textBox1_SetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Views.AboutProject InnerForm = new Views.AboutProject()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " Nazwa użytkownika") {
                MessageBox.Show("Nie podano nazwy użytkownika.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (textBox2.Text == " Hasło") {
                MessageBox.Show("Nie podano hasła.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                var result = MessageBox.Show("Pomyślnie zalogowano.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    this.Hide();
                    Form sistema = new WybórEkranu();
                    sistema.ShowDialog();
                    this.Close();
                }
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
