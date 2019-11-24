using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Widoki_Wilk
{
    public partial class DodawanieKierowcy : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();
        public DodawanieKierowcy()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano Kierowcę");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void DodawanieKierowcy_Load(object sender, EventArgs e)
        {

        }
    }
}
