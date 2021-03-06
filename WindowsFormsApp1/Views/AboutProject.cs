﻿using System;
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
    public partial class AboutProject : Form
    {
        public AboutProject()
        {
            InitializeComponent();
        }

        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void turnoffFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Hover_exitbutton(object sender, EventArgs e) => sharedView.Hover_exitbutton(exit);

        private void Leave_exitbutton(object sender, EventArgs e) => sharedView.Leave_exitbutton(exit);


        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
