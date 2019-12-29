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
    public partial class WypelnianieCzasuRealizacjiKursu : Form
    {
        public WypelnianieCzasuRealizacjiKursu()
        {
            InitializeComponent();
        }

        bool ErrorIsOn,ErrorKierIsOn = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();

        private void move_window(object sender, MouseEventArgs e)
        {                             // metoda do przesuwania okna
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        private void turnoff_focus(object sender, EventArgs e)  //wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assign_Click(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):[0-5][0-9]$");
            //bool isValid = regex.IsMatch(czas_realizacji.Text.Trim());
            kurs.Focus();
            driver.Focus();
            kurs.Focus();
            if (ErrorKierIsOn == false && ErrorIsOn == false)
            { 
                var result = MessageBox.Show("Czy na pewno chcesz przypisać czas realizacji danego kursu?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //WPISANIE DO BD
                    this.Close();
                }
             
            }
      
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void kurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kurs.SelectedIndex > -1) {
                tabela.Visible = true;
                alert.Visible = true;
                alertpic.Visible = true;
            }
        }
        private void kurs_SelectedIndexChanged_Validating(object sender, CancelEventArgs e)
        {
            if (kurs.SelectedIndex == -1)
            {
                errorProvider1.SetError(kurs, "Nie wybrano kursu");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(kurs, null);
                ErrorIsOn = false;
            }
        }

        private void driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorKierIsOn = true;
        }

        private void driver_SelectedIndexChanged_Validating(object sender, CancelEventArgs e)
        {
            if (driver.SelectedIndex == -1)
            {
                errorProvider1.SetError(driver, "Nie wybrano kierowcy");
                ErrorKierIsOn = true;
            }
            else
            {
                errorProvider1.SetError(driver, null);
                ErrorKierIsOn = false;
            }
        }
    }
}
