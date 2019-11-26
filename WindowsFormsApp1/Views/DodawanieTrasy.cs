using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class DodawanieTrasy : Form {
        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        private void move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e) {
            sharedView.hover_exitbutton(this.exit);
        }

        private void leave_exitbutton(object sender, EventArgs e) {
            sharedView.leave_exitbutton(this.exit);
        }

        private void turnoff_focus(object sender, EventArgs e)  //wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        {
            this.ActiveControl = null;
        }

        public DodawanieTrasy() {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e) {
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
            sharedView.fixIndex(this.mainListBox);
        }

        private void itemcreator_Load(object sender, EventArgs e) {
            this.mainListBox.AllowDrop = true;
        }

        private void clearButton_Click(object sender, EventArgs e) {
            mainListBox.Items.Clear();
        }

        private void mainListBox_DoubleClick(object sender, EventArgs e) {
            ;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (this.mainListBox.SelectedIndex == -1)
                MessageBox.Show("Musisz najpierw zanzaczyć który element chcesz usunąć.");
            else {
                this.mainListBox.Items.RemoveAt(this.mainListBox.SelectedIndex);
                // Napraw indexy
                sharedView.fixIndex(this.mainListBox);
            }
        }
        
        //TODO dorobić odpowiednią liczbę spacji przy godzinie 
        private void addButton_Click(object sender, EventArgs e) {
            Models.routeElementModel przystanek;
            using (Views.DodajPrzystanekDoTrasy InnerForm = new Views.DodajPrzystanekDoTrasy())
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                    przystanek = InnerForm.GetStop;
                    Console.WriteLine($"Miasto: {przystanek.City}");
                    string toAdd = "1) " + przystanek.City + ", " + przystanek.Name + "    " + przystanek.ArrivalTime;
                    this.mainListBox.Items.Add(toAdd);
                    sharedView.fixIndex(this.mainListBox);
                }
        }

    }
}
