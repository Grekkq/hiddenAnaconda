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
            var endDate = dateTimeEnd.Value.Date;
            if ( dateTimeEnd.Value.Date < dateTimeStart.Value.Date) {
                MessageBox.Show("Data początkowa nie może być późniejsza niż data końcowa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Models.DayType dayType = new Models.DayType();
                dayType.addDate(0, startDate, endDate);
                const string message = "Pomyślnie utworzono termin";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    this.Close();
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
