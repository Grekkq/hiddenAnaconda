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
    public partial class ZmianaStatusu : Form
    {
        public ZmianaStatusu()
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

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.leave_exitbutton(exit);

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kierowca_CheckedChanged(object sender, EventArgs e)
        {
            if (kierowca.Checked == true) {
                kierowcaSelectionLabel.Visible = true;
                kierowcaSelectionComboBox.Visible = true;
                pojazdSelectionLabel.Visible = false;
                pojazdSelectionComboBox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radio_pojazd.Visible = false;
            }
        }

        private void pojazd_CheckedChanged(object sender, EventArgs e)
        {
            if (pojazd.Checked == true) {
                kierowcaSelectionLabel.Visible = false;
                kierowcaSelectionComboBox.Visible = false;

                pojazdSelectionLabel.Visible = true;
                pojazdSelectionComboBox.Visible = true;

                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radio_pracownik.Visible = false;
                pojazdSelectionComboBox.SelectedValue = null;
              
            }
        }

        private void pojazdSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            radio_pojazd.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;

            radio_pracownik.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
        }

        private void kierowcaSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            radio_pracownik.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radio_pojazd.Visible = false;
        }
    }
}
