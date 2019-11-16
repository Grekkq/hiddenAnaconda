using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Widoki_Wilk
{
    public partial class DodawanieKierowcy : Form
    {
        public DodawanieKierowcy()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano Kierowcę");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
