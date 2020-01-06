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
using hiddenAnaconda.Models;

namespace hiddenAnaconda.Views {
    public partial class WypelnianieCzasuRealizacjiKursu : Form {
        RealizationTime realizationTime;
        public WypelnianieCzasuRealizacjiKursu() {
            InitializeComponent();
            realizationTime = new RealizationTime();
            realizationTime.LoadTrailRealizationIntoComboBox(TrailAssignmentComboBox);
            realizationTime.LoadDriversIntoComboBox(DriverComboBox);
            RealizationTimeDataGridView.Columns.Clear();
            RealizationTimeDataGridView.Columns.Add("stopName", "Przystanek");
            RealizationTimeDataGridView.Columns.Add("realizationTime", "Faktyczny Czas");
            RealizationTimeDataGridView.Columns.Add("scheduledTime", "Planowy Czas");
            RealizationTimeDataGridView.RowHeadersVisible = false;
            RealizationTimeDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RealizationTimeDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RealizationTimeDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RealizationTimeDataGridView.Columns[2].Width = 60;
            RealizationTimeDataGridView.Columns[1].Width = 60;
        }

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        bool ErrorIsOn, ErrorKierIsOn = true;

        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();

        private void move_window(object sender, MouseEventArgs e) {                             // metoda do przesuwania okna
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        private void turnoff_focus(object sender, EventArgs e)  //wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e) {
            this.Close();
        }

        private void assign_Click(object sender, EventArgs e) {
            //Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):[0-5][0-9]$");
            //bool isValid = regex.IsMatch(czas_realizacji.Text.Trim());
            TrailAssignmentComboBox.Focus();
            DriverComboBox.Focus();
            TrailAssignmentComboBox.Focus();
            if (ErrorKierIsOn == false && ErrorIsOn == false) {
                var result = MessageBox.Show("Czy na pewno chcesz przypisać czas realizacji danego kursu?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    //WPISANIE DO BD
                    this.Close();
                }

            }

        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void kurs_SelectedIndexChanged(object sender, EventArgs e) {
            if (TrailAssignmentComboBox.SelectedIndex > -1) {
                RealizationTimeDataGridView.Visible = true;
                alert.Visible = true;
                alertpic.Visible = true;

                realizationTime.LoadDataIntoDataGridView(RealizationTimeDataGridView, TrailAssignmentComboBox.Text);
            }
        }
        private void kurs_SelectedIndexChanged_Validating(object sender, CancelEventArgs e) {
            if (TrailAssignmentComboBox.SelectedIndex == -1) {
                errorProvider1.SetError(TrailAssignmentComboBox, "Nie wybrano kursu");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(TrailAssignmentComboBox, null);
                ErrorIsOn = false;
            }
        }

        private void driver_SelectedIndexChanged(object sender, EventArgs e) {
            ErrorKierIsOn = true;
        }

        private void driver_SelectedIndexChanged_Validating(object sender, CancelEventArgs e) {
            if (DriverComboBox.SelectedIndex == -1) {
                errorProvider1.SetError(DriverComboBox, "Nie wybrano kierowcy");
                ErrorKierIsOn = true;
            } else {
                errorProvider1.SetError(DriverComboBox, null);
                ErrorKierIsOn = false;
            }
        }
    }
}
