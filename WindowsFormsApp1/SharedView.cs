using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1 {

    class SharedView {
        private readonly int WM_NCLBUTTONDOWN = 0xA1;
        private readonly int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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

        // zmiana koloru X'a po zjechaniu
        public void leave_exitbutton(Button exit) {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        public void fixIndex(ListBox listBox) {
            int index = 1;
            List<String> replacmentData = new List<String>();
            foreach (object item in listBox.Items) {
                string content = (string) item;
                String[] separator = { ") " };
                String newcontent = content.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
                newcontent = (index + ") ").PadRight(11, ' ') + newcontent;
                replacmentData.Add(newcontent);
                MessageBox.Show(content + "\n" + newcontent);
                index++;
            }
            listBox.Items.Clear();
            foreach (object item in replacmentData) {
                listBox.Items.Add(item);
            }
        }
    }
}
