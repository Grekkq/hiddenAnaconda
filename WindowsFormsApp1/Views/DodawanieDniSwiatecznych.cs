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
    public partial class DodawanieDniSwiatecznych : Form
    {
        public DodawanieDniSwiatecznych()
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
           
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
