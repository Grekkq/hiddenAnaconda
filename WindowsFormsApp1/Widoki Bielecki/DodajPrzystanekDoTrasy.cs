using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Widoki_Bielecki
{
    public partial class DodajPrzystanekDoTrasy : Form
    {
        public DodajPrzystanekDoTrasy()
        {
            InitializeComponent();
        }

        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e)
        {
            sharedView.moveWindow(sender, e, Handle);
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPrzystanekDoTrasy_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
