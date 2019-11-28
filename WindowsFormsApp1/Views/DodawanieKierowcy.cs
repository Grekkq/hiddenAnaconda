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
    public partial class DodawanieKierowcy : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();
        public DodawanieKierowcy() {
            InitializeComponent();
        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void powrot_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e) {
            DriverFirstName.ResetText();
            DriverLastName.ResetText();
            DriverPesel.ResetText();
            DriverBirthDate.ResetText();
        }

        private void Zapisz_Click(object sender, EventArgs e) {
            MessageBox.Show("Zapisano Kierowcę");
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        private void leave_helpbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(help);
        }

        private void hover_helpbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(help);
        }

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void DodawanieKierowcy_Load(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DriverName_TextChanged(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }

        private void DriverFirstName_TextChanged(object sender, EventArgs e)
        {
            DriverFirstName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.DriverFirstName.Text);
            DriverFirstName.Select(DriverFirstName.Text.Length, 0);
        }

        private void DriverLastName_TextChanged(object sender, EventArgs e)
        {
            DriverLastName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.DriverLastName.Text);
            DriverLastName.Select(DriverLastName.Text.Length, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DriverBirthDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DriverPesel_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void DriverPesel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
