using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static hiddenAnaconda.Constants;

namespace hiddenAnaconda.Views {
    public partial class DodawanieDniWolnych : Form {
        public DodawanieDniWolnych() {
            InitializeComponent();
        }
        bool ErrorIsOn,ErrorStartIsOn,ErrorEndIsOn = true;

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void turnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void hover_helpbutton(object sender, EventArgs e) {
            sharedView.Hover_helpbutton(help);
        }

        private void leave_helpbutton(object sender, EventArgs e) {
            sharedView.Leave_helpbutton(help);
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

        private void DodawanieDniSwiatecznych_Load(object sender, EventArgs e) {
            type.MaxLength = 30;
            ReloadDataInDataGrid();
            sharedView.LoadDayTypesIntoComboBox(type);
        }

        private void ReloadDataInDataGrid() {
            this.dataGridView.Rows.Clear();
            this.dataGridView.Refresh();
            this.dataGridView.ReadOnly = true;
            Models.DayType dayType = new Models.DayType();
            this.dataGridView.DataSource = dayType.selectDataForDataGrid().Select(d => new { d.rodzaj_kursu, d.od_dnia, d.do_dnia.Date });
            this.dataGridView.Columns[0].HeaderText = "Typ Dnia";
            this.dataGridView.Columns[1].HeaderText = "Od Dnia";
            this.dataGridView.Columns[2].HeaderText = "Do Dnia";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void powrot_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e) {
            /*if (dateTimeStart.Value < DateTime.Today) {
                MessageBox.Show("Wybrana data jest wcześniejsza niż dzisiejsza data", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeStart.Value = DateTime.Today;
            }*/
        }
        private void dateTimeStart_ValueChanged_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeStart.Value < DateTime.Today)
            {
                errorProvider1.SetError(dateTimeStart, "Wybrana data była wcześniejsza niż dzisiejsza data, błąd poprawiono");
                dateTimeStart.Value = DateTime.Today;

            }
            else
            {
                errorProvider1.SetError(dateTimeStart, null);

            }
        }

        private void Aktualizuj_Click(object sender, EventArgs e) {
           
            type.Focus();
            label1.Focus();
            type.Focus();
            var startDate = dateTimeStart.Value.Date;
            var endDate = dateTimeEnd.Value.Date.AddSeconds(NumberOfSecondSInDay - 1);
            var dayKind = type.Text;
            if(!string.IsNullOrEmpty(type.Text) && ErrorIsOn == false)
            {
                if (endDate < startDate)
                {
                    MessageBox.Show("Data początkowa nie może być późniejsza niż data końcowa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var result = MessageBox.Show
                        ("Czy na pewno chcesz dodać dzień " + dayKind + " od dnia: " + startDate.ToString(DateFormat) + " do dnia: " + endDate.ToString(DateFormat) + "?",
                        "Czy na pewno?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Models.DayType dayType = new Models.DayType();
                        if (!dayType.addDate(dayKind, startDate, endDate))
                        {
                            MessageBox.Show("Wybrana data koliduje z inną.\n Spróbuj jeszcze raz.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ReloadDataInDataGrid();
                    }
                }
            }
         
           
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e) {
           /* if (dateTimeEnd.Value < DateTime.Today) {
                MessageBox.Show("Wybrana data jest wcześniejsza niż dzisiejsza data", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeEnd.Value = DateTime.Now;
            }*/
        }

        private void dateTimeEnd_ValueChanged_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeEnd.Value < DateTime.Today)
            {
                errorProvider1.SetError(dateTimeEnd, "Wybrana data była wcześniejsza niż dzisiejsza data, błąd poprawiono");
                dateTimeEnd.Value = DateTime.Now;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void reset_Click(object sender, EventArgs e) {
            dateTimeStart.Value = DateTime.Today;
            dateTimeEnd.Value = DateTime.Today;
            type.Text = "";
            type.SelectedIndex = -1;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aktualizuj.Focus();
        }
        private void type_SelectedIndexChanged_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(type.Text))
            {
                errorProvider1.SetError(type, "Nie wprowadzono rodzaju okresu");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(type, null);
                ErrorIsOn = false;
            }
        }
    }

}
