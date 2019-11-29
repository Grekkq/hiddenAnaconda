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



namespace hiddenAnaconda.Views
{
   
    public partial class DodawanieKursu : Form
    {
        bool ErrorIsOn, ErrorIsOn2 = false;
        SharedView sharedView = new SharedView();
        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        public DodawanieKursu()
        {
            InitializeComponent();
        }
        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(line_choose.Text)))
            {
                MessageBox.Show("Nie wybrano numeru lini", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(date_name.Text) || (ErrorIsOn2 == true))
            {
                MessageBox.Show("Nie wprowadzono nowej daty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(c_number.Text))
            {
                MessageBox.Show("Nie wprowadzono numeru kursu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(hour_name.Text) ||  (ErrorIsOn == true))
            {
                MessageBox.Show("Nie wprowadzono poprawnie godziny.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            else
            {
                const string message = "Pomyślnie utworzono nowy pojazd";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DodawanieKursu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void c_number_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void c_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hour_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void hour_name_Validating(object sender, CancelEventArgs e)
            {
            Regex r = new Regex(@"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");

            if (string.IsNullOrEmpty(hour_name.Text))
                {
                    errorProvider1.SetError(hour_name, "Nie wpisano godziny!");
                     ErrorIsOn = true;
                }
                else if(!r.IsMatch(hour_name.Text))
                {
                   errorProvider1.SetError(hour_name, "Niepoprawnie wpisana godzina");
                 ErrorIsOn = true;
                }
                else
                {
                    errorProvider1.SetError(hour_name, null);
                    ErrorIsOn = false;
                }
            }

        private void date_name_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"((0?[13578]|10|12)(-|\/)((0[0-9])|([12])([0-9]?)|(3[01]?))(-|\/)((\d{4})|(\d{2}))|(0?[2469]|11)(-|\/)((0[0-9])|([12])([0-9]?)|(3[0]?))(-|\/)((\d{4}|\d{2})))");

            if (string.IsNullOrEmpty(date_name.Text))
            {
                errorProvider2.SetError(date_name, "Nie wpisano daty!");
                ErrorIsOn2 = true;
            }
            else if (!r.IsMatch(date_name.Text))
            {
                errorProvider2.SetError(date_name, "Niepoprawnie wpisana data");
                ErrorIsOn2 = true;
            }
            else
            {
                errorProvider2.SetError(date_name, null);
                ErrorIsOn2 = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
