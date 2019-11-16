using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodawaniepojazdu
{
    public partial class Dodawaniepojazdu : Form    {

        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();

        private void move_window(object sender, MouseEventArgs e)
        {                             // metoda do przesuwania okna
            if (e.Button == MouseButtons.Left)
            {
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

        public Dodawaniepojazdu()
        {
            InitializeComponent();
        }
        private void turnoff_focus(object sender, EventArgs e)  //wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        {
            this.ActiveControl = null;
        }
        private void close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mark_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void create_Click(object sender, EventArgs e)
        {
            if ((yes.Checked == false && no.Checked == false) && (string.IsNullOrEmpty(mark_name.Text)))
            {
                MessageBox.Show("Nie wypełniono formularza", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (((string.IsNullOrEmpty(vin_number.Text)) || (string.IsNullOrEmpty(model_name.Text)) || (string.IsNullOrEmpty(year_number.Text))) || (string.IsNullOrEmpty(plate_numer.Text)))
            {
                MessageBox.Show("Formularz niewypełniony całkowicie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if (yes.Checked == false && no.Checked == false)
            {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                const string message = "Pomyślnie utworzono nowy pojazd";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}






