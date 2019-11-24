using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Widoki_Zagoła
{
    public partial class DodawanieTrasy : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;                                               // stałe do funkcji przesuwania okna
        public const int HT_CAPTION = 0x2;                                                      //
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                // importowanie funkcji do przesuwania okna
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);     // 
        [System.Runtime.InteropServices.DllImport("user32.dll")]                                //
        public static extern bool ReleaseCapture();

        private void move_window(object sender, MouseEventArgs e)
        {                             // metoda do przesuwania okna
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        private void turnoff_focus(object sender, EventArgs e)  //wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        {
            this.ActiveControl = null;
        }

        public DodawanieTrasy()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DRAG&DROP
        private void mainListBox_MouseDown(object sender, MouseEventArgs e) {
            if (this.mainListBox.SelectedItem == null)
                return;
            this.mainListBox.DoDragDrop(this.mainListBox.SelectedItem, DragDropEffects.Move);
        }

        private void mainListBox_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        private void mainListBox_DragDrop(object sender, DragEventArgs e) {
            Point point = mainListBox.PointToClient(new Point(e.X, e.Y));
            int index = this.mainListBox.IndexFromPoint(point);
            if (index < 0)
                index = this.mainListBox.Items.Count - 1;
            object data = mainListBox.SelectedItem;
            this.mainListBox.Items.Remove(data);
            this.mainListBox.Items.Insert(index, data);
            // Napraw indexy
            index = 1;
            List<String> replacmentData = new List<String>();
            foreach (object item in mainListBox.Items) {
                string content = (string) item;
                String[] separator = { ") " };
                String newcontent = content.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
                newcontent = (index + ") ").PadRight(11, ' ') + newcontent;
                replacmentData.Add(newcontent);
                MessageBox.Show(content + "\n" + newcontent);
                index++;
            }
            this.mainListBox.Items.Clear();
            foreach (object item in replacmentData) {
                this.mainListBox.Items.Add(item);
            }
        }

        private void itemcreator_Load(object sender, EventArgs e) {
            this.mainListBox.AllowDrop = true;
        }

        private void mainListBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void clearButton_Click(object sender, EventArgs e) {
            mainListBox.Items.Clear();
        }
    }
}
