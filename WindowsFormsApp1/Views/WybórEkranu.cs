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
    public partial class WybórEkranu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();
        public WybórEkranu()
        {
            InitializeComponent();
        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void turnoffFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void hover_helpbutton(object sender, EventArgs e)
        {
            sharedView.hover_helpbutton(help);
        }

        private void leave_helpbutton(object sender, EventArgs e)
        {
            sharedView.leave_helpbutton(help);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Linia_Click(object sender, EventArgs e)
        {
            using (Views.DodawanieNowejLinii InnerForm = new Views.DodawanieNowejLinii()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Trasa_Click(object sender, EventArgs e)
        {
            using (Views.DodawanieTrasy InnerForm = new Views.DodawanieTrasy()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Przystanek_Click(object sender, EventArgs e)
        {
            using (Views.DodawaniePrzystanku InnerForm = new Views.DodawaniePrzystanku()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Pojazd_Click(object sender, EventArgs e)
        {
            using (Views.DodawaniePojazdow InnerForm = new Views.DodawaniePojazdow()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Kierowca_Click(object sender, EventArgs e)
        {
            using (Views.DodawanieKierowcy InnerForm = new Views.DodawanieKierowcy()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Kurs_Click(object sender, EventArgs e)
        {
            using (Views.DodawanieKursu InnerForm = new Views.DodawanieKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Przypisanie_Click(object sender, EventArgs e)
        {
            using (Views.planowanieRealizacjiKursu InnerForm = new Views.planowanieRealizacjiKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Czas_Click(object sender, EventArgs e)
        {
            using (Views.WypelnianieCzasuRealizacjiKursu InnerForm = new Views.WypelnianieCzasuRealizacjiKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void WybórEkranu_Load(object sender, EventArgs e)
        {

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

        private void create_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZmianaStatusu_Click(object sender, EventArgs e)
        {
            using (Views.ZmianaStatusu InnerForm = new Views.ZmianaStatusu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Views.DodawanieDniWolnych InnerForm = new Views.DodawanieDniWolnych()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void RaportButton_Click(object sender, EventArgs e) {
            Models.TimeTable timeTable = new Models.TimeTable();
            DateTime date = DateTime.Parse("29.11.2020");
            date = date.AddHours(2);
            timeTable.GetTimeTable(101, "Skalka", date, 1);
            //timeTable.GetAllBusStops(164);
            // test pdf'a
            //timeTable.SaveToPdf("<p>Przykładowa zawartość</p><br /><p><table style='width:100%'><tr><th>Firstname</th><th>Lastname</th><th>Age</th></tr><tr><td>Jill</td><td>Smith</td><td>50</td></tr><tr><td>Eve</td><td>Jackson</td><td>94</td></tr></table></p>");
        }
    }
}
