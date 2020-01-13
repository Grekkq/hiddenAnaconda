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

namespace hiddenAnaconda.Views
{
    public partial class WypelnianieCzasuRealizacjiKursu : Form
    {
        RealizationTime realizationTime;
        public WypelnianieCzasuRealizacjiKursu()
        {
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

            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Control_KeyPress);

        }

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return sharedView.EscKeyPressed(this, keyData);
        }

        bool ErrorIsOn, ErrorCzasIsOn, ErrorCzas2IsOn, ErrorCzas4IsOn, ErrorCzas3IsOn, ErrorKierIsOn = true;
     

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
            int[] tab = new int [RealizationTimeDataGridView.Rows.Count];
         
            for (int i = 0; i < RealizationTimeDataGridView.Rows.Count; i++)
            {
                string headerText = RealizationTimeDataGridView.Columns[1].HeaderText;

                RealizationTimeDataGridView.CurrentCell = RealizationTimeDataGridView.Rows[i].Cells[1];

                if (headerText.Equals("Faktyczny Czas"))
                {


                    if (string.IsNullOrEmpty(RealizationTimeDataGridView.CurrentCell.Value.NullSafeToString()))
                    {
                        errorProvider1.SetError(RealizationTimeDataGridView, "Nie wpisano godziny");
                        ErrorCzas2IsOn = true;
                        tab[i] = 1;
                    }
                    else if (!Constants.ValidateTimeFormat.IsMatch(RealizationTimeDataGridView.CurrentCell.Value.ToString()))
                    {
                        errorProvider2.SetError(RealizationTimeDataGridView, "Niepoprawnie wpisana godzina. Akceptowany format czasu: GG:MM");
                        ErrorCzasIsOn = true;
                        tab[i] = 1;
                    }
                    else
                    {
                        errorProvider1.SetError(RealizationTimeDataGridView, null);
                        ErrorCzasIsOn = false;
                        tab[i] = 0;
                        ErrorCzas2IsOn = false;
                        ErrorCzas3IsOn = false;
                        errorProvider3.SetError(RealizationTimeDataGridView, null);
                        errorProvider2.SetError(RealizationTimeDataGridView, null);
                    }
                }
            }

            RealizationTimeDataGridView.CurrentCell = RealizationTimeDataGridView.Rows[0].Cells[0];
            //Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):[0-5][0-9]$");
            //bool isValid = regex.IsMatch(czas_realizacji.Text.Trim());
            TrailAssignmentComboBox.Focus();
            DriverComboBox.Focus();
            TrailAssignmentComboBox.Focus();
            RealizationTimeDataGridView.Focus();

            

            for (int i = 0; i < RealizationTimeDataGridView.Rows.Count; i++)
            {
                if (tab[i] == 1)
                { 
                    errorProvider3.SetError(RealizationTimeDataGridView, "Niepoprawnie wpisana godzina. Akceptowany format czasu: GG:MM");
                    ErrorCzas3IsOn = true;
                }
            }

            if (ErrorKierIsOn == false && ErrorIsOn == false && ErrorCzasIsOn == false && ErrorCzas2IsOn == false && ErrorCzas3IsOn == false && ErrorCzas4IsOn == false)
            {
                var result = MessageBox.Show("Czy na pewno chcesz przypisać czas realizacji danego kursu?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //WPISANIE DO BD
                    realizationTime.AddRealizationTime(RealizationTimeDataGridView, DriverComboBox, TrailAssignmentComboBox);
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
            if (TrailAssignmentComboBox.SelectedIndex > -1)
            {
                RealizationTimeDataGridView.Visible = true;
                realizationTime.LoadDataIntoDataGridView(RealizationTimeDataGridView, TrailAssignmentComboBox.Text);
            }
        }

        private void RealizationTimeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Constants.HelpPath, HelpNavigator.Topic, "Czas%20realizacji%20kursu.htm");
        }

        private void kurs_SelectedIndexChanged_Validating(object sender, CancelEventArgs e)
        {
            if (TrailAssignmentComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(TrailAssignmentComboBox, "Nie wybrano kursu");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(TrailAssignmentComboBox, null);
                ErrorIsOn = false;
            }
        }

        private void driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorKierIsOn = true;
        }

        private void WypelnianieCzasuRealizacjiKursu_Load(object sender, EventArgs e) {
            this.AcceptButton = create;
        }

        private void driver_SelectedIndexChanged_Validating(object sender, CancelEventArgs e) {
            if (DriverComboBox.SelectedIndex == -1) {
                errorProvider1.SetError(DriverComboBox, "Nie wybrano kierowcy");
                ErrorKierIsOn = true;
            }
            else
            {
                errorProvider1.SetError(DriverComboBox, null);
                ErrorKierIsOn = false;
            }
        }


        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == ':'))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
            
        }

    }

    public static class ObjectExtensions
    {
        public static string NullSafeToString(this object obj)
        {
            return obj != null ? obj.ToString() : String.Empty;
        }
    }

}