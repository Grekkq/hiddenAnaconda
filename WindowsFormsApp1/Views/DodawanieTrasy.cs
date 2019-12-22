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
        bool ErrorIsOn = true;
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

        private void turnoff_focus(object sender, EventArgs e) {  //wyłączenie fokusu na pola tekstowe przy uruchomieniu 
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
            // nie ruszać jak się usunie if'a to nigdy nie wejdzie do doubleclick 
            // https://stackoverflow.com/questions/8531949/listbox-mousedown-and-doubleclick
            if (e.Button == MouseButtons.Left && e.Clicks == 1) {
                this.mainListBox.DoDragDrop(this.mainListBox.SelectedItem, DragDropEffects.Move);
            }
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

        private void mainListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.mainListBox.SelectedItem == null)
                return;
            int index = this.mainListBox.SelectedIndex;
            using (Views.DodajPrzystanekDoTrasy InnerForm =
                new Views.DodajPrzystanekDoTrasy(new Models.routeElementModel(this.mainListBox.SelectedItem.ToString())))
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                    this.mainListBox.Items.RemoveAt(index);
                    InnerForm.GetStop.putInListBoxAt(this.mainListBox, index);
                }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (this.mainListBox.SelectedIndex == -1)
                MessageBox.Show("Musisz najpierw zanzaczyć który element chcesz usunąć.");
            else {
                this.mainListBox.Items.RemoveAt(this.mainListBox.SelectedIndex);
                sharedView.fixIndex(this.mainListBox);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            using (Views.DodajPrzystanekDoTrasy InnerForm = new Views.DodajPrzystanekDoTrasy())
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                    InnerForm.GetStop.putInListBox(this.mainListBox);
                }
        }

        private void DodawanieTrasy_Load(object sender, EventArgs e) {
            sharedView.LoadLinesIntoComboBox(this.linia_comboBox);
            label_trasa.Visible = false;
            comboBoxTrasa.Visible = false;
            clearButton.Visible = false;
            addButton.Visible = false;
            deleteButton.Visible = false;
            create.Visible = false;

            //visability of datagrid
            label_lokalizacja.Visible = false;
            label_nr.Visible = false;
            label_godzina.Visible = false;
            mainListBox.Visible = false;
            //przykładowe dane
            this.comboBoxTrasa.Items.Clear();
            this.comboBoxTrasa.Items.Add("1");
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (ErrorIsOn!=true)
            {
                var result = MessageBox.Show("Na pewno chcesz utworzyć trasę?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //WPISANIE DO BD
                }
                else
                {
                    linia_comboBox.Focus();
                }
            }
        }

        private void lineSelectionComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(linia_comboBox.Text))
            {
                errorProvider1.SetError(linia_comboBox, "Nie wybrano linii");
                ErrorIsOn = true;
            }
            else
            {
                errorProvider1.SetError(linia_comboBox, null);
                ErrorIsOn = false;
            }
        }

        private void bgPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linia_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            label_trasa.Visible = true;
            comboBoxTrasa.Visible = true;
        }

        private void comboBoxTrasa_SelectedIndexChanged(object sender, EventArgs e) {
            mainListBox.Visible = true;
            label_godzina.Visible = true;
            label_lokalizacja.Visible = true;
            label_nr.Visible = true;

            clearButton.Visible = true;
            addButton.Visible = true;
            create.Visible = true;
            deleteButton.Visible = true;
        }
    }
}
