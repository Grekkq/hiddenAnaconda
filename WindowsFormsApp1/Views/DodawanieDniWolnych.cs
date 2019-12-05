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

namespace hiddenAnaconda.Views
{
    public partial class DodawanieDniWolnych : Form
    {
        public DodawanieDniWolnych()
        {
            InitializeComponent();
        }

        SharedView sharedView = new SharedView();

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

        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.leave_exitbutton(exit);

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void DodawanieDniSwiatecznych_Load(object sender, EventArgs e)
        {
            type.MaxLength = 30;
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

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeStart.Value < DateTime.Today) {
                MessageBox.Show("Wybrana data jest wcześniejsza niż dzisiejsza data", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeStart.Value = DateTime.Today;
            }
        }

        private void Aktualizuj_Click(object sender, EventArgs e)
        {
            var startDate = dateTimeStart.Value.Date;
            var endDate = dateTimeEnd.Value.Date.AddSeconds(NumberOfSecondSInDay-1);
            var dayKind = type.Text;
            if ( endDate < startDate) {
                MessageBox.Show("Data początkowa nie może być późniejsza niż data końcowa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if(string.IsNullOrEmpty(dayKind) && type.SelectedIndex == -1) {
                MessageBox.Show("Nie wprowadzono rodzaju okresu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Models.DayType dayType = new Models.DayType();
                if (dayType.addDate(dayKind, startDate, endDate)) {
                    if (MessageBox.Show("Pomyślnie utworzono termin.", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                        this.Close();
                    }
                } else {
                    if (MessageBox.Show("Nie udało utworzyć.\nSpróbuj ponownie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) {
                        this.Close();
                    }
                }
                
            }
        }

        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeEnd.Value < DateTime.Today) {
                MessageBox.Show("Wybrana data jest wcześniejsza niż dzisiejsza data", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeEnd.Value = DateTime.Now;
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            dateTimeStart.Value = DateTime.Today;
            dateTimeEnd.Value = DateTime.Today;
            type.Text = "";
            type.SelectedIndex = -1;
        }
    }

    }
