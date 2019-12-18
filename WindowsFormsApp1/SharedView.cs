﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using hiddenAnaconda.Models;

namespace hiddenAnaconda {

    class SharedView {
        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        ReportDataContext dc;
        private List<String> lines;
        public SharedView() {
            dc = new ReportDataContext();
            lines = new List<string>();
        }

        public void LoadLinesIntoComboBox(ComboBox comboBox) {
            if (lines.Count == 0)
                GetLinesFromDb();
            foreach (var line in lines)
                comboBox.Items.Add(line);
        }

        private void GetLinesFromDb() {
            var data = dc.linias;
            foreach (var item in data) {
                lines.Add(item.id_linii.ToString());
            }
        }

        // przesuwanie okna
        public void moveWindow(object sender, MouseEventArgs e, IntPtr Handle) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // zmiana koloru X'a po najechaniu
        public void hover_exitbutton(Button exit) {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        // zmiana koloru ?'a po najechaniu
        public void hover_helpbutton(Button help)
        {
            help.BackColor = Color.FromArgb(0, 99, 183);
        }
        // zmiana koloru ?'a po zjechaniu

        public void leave_helpbutton(Button help)
        {
            help.BackColor = Color.FromArgb(0, 99, 183);
        }

        // zmiana koloru X'a po zjechaniu
        public void leave_exitbutton(Button exit) {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        public void fixIndex(ListBox listBox) {
            int index = 1;
            //List<String> replacmentData = new List<String>();
            List<Models.routeElementModel> busStops = new List<Models.routeElementModel>();
            foreach (object item in listBox.Items) {
                busStops.Add(new Models.routeElementModel((string) item));
                index++;
            }
            listBox.Items.Clear();
            foreach (Models.routeElementModel busStop in busStops) {
                busStop.putInListBox(listBox);
            }
        }
    }
}
