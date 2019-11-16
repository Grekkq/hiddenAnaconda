using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class planowanieRealizacjiKursu : Form {

        public planowanieRealizacjiKursu() {
            InitializeComponent();
        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.leave_exitbutton(exit);
        }

        private void przypisywanieKierowcowPojazdowDoRealizacji_Load(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
