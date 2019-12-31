using hiddenAnaconda.Models;
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
        AddTrail trail;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        private void Move_window(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                sharedView.MoveWindow(sender, e, Handle);
            }
        }

        private void Hover_exitbutton(object sender, EventArgs e) {
            sharedView.Hover_exitbutton(this.exit);
        }

        private void Leave_exitbutton(object sender, EventArgs e) {
            sharedView.Leave_exitbutton(this.exit);
        }

        private void Turnoff_focus(object sender, EventArgs e) {  //wyłączenie fokusu na pola tekstowe przy uruchomieniu 
            this.ActiveControl = null;
        }

        public DodawanieTrasy() {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        // DRAG&DROP
        private void MainListBox_MouseDown(object sender, MouseEventArgs e) {
            if (this.mainListBox.SelectedItem == null)
                return;
            // nie ruszać jak się usunie if'a to nigdy nie wejdzie do doubleclick 
            // https://stackoverflow.com/questions/8531949/listbox-mousedown-and-doubleclick
            if (e.Button == MouseButtons.Left && e.Clicks == 1) {
                this.mainListBox.DoDragDrop(this.mainListBox.SelectedItem, DragDropEffects.Move);
            }
        }

        private void MainListBox_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Move;
        }

        private void MainListBox_DragDrop(object sender, DragEventArgs e) {
            Point point = mainListBox.PointToClient(new Point(e.X, e.Y));
            int index = this.mainListBox.IndexFromPoint(point);
            if (index < 0)
                index = this.mainListBox.Items.Count - 1;
            object data = mainListBox.SelectedItem;
            this.mainListBox.Items.Remove(data);
            this.mainListBox.Items.Insert(index, data);
            // Napraw indexy
            sharedView.FixIndex(this.mainListBox);
        }

        private void Itemcreator_Load(object sender, EventArgs e) {
            this.mainListBox.AllowDrop = true;
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            mainListBox.Items.Clear();
        }

        private void MainListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
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

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (this.mainListBox.SelectedIndex == -1)
                MessageBox.Show("Musisz najpierw zaznaczyć element, który chcesz usunąć.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else {
                this.mainListBox.Items.RemoveAt(this.mainListBox.SelectedIndex);
                sharedView.FixIndex(this.mainListBox);
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            using (Views.DodajPrzystanekDoTrasy InnerForm = new Views.DodajPrzystanekDoTrasy())
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                    InnerForm.GetStop.putInListBox(this.mainListBox);
                }
        }

        private void DodawanieTrasy_Load(object sender, EventArgs e) {
            sharedView.LoadLinesIntoComboBox(this.linia_comboBox);
            checkBox_czyUtworzycNowaTrase.Visible = false;
            label_trasa.Visible = false;
            comboBoxTrasa.Visible = false;
            clearButton.Visible = false;
            addButton.Visible = false;
            deleteButton.Visible = false;
            create.Visible = false;
            label_przystanek.Visible = false;


            //visability of datagrid
            label_lokalizacja.Visible = false;
            label_nr.Visible = false;
            label_godzina.Visible = false;
            mainListBox.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e) {
            if (ErrorIsOn != true) {
                var result = MessageBox.Show("Na pewno chcesz utworzyć trasę?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    //WPISANIE DO BD
                    trail.AddNewTrail(mainListBox);
                    //jak chcemy go nie zamykać to trzeba ogarnąc buga że przy podwójnym dodaniu nie przeliczy jeszcze raz numeru trasy i się zdubluje
                    //ewentualnie jeszcze można odznaczać checkboxa to powinno się samo przeliczyć 
                    checkBox_czyUtworzycNowaTrase.Checked = false; 
                } else {
                    linia_comboBox.Focus();
                }
            }
        }

        private void LineSelectionComboBox_Validating(object sender, CancelEventArgs e) {
            if (string.IsNullOrEmpty(linia_comboBox.Text)) {
                errorProvider1.SetError(linia_comboBox, "Nie wybrano linii");
                ErrorIsOn = true;
            } else {
                errorProvider1.SetError(linia_comboBox, null);
                ErrorIsOn = false;
            }
        }

        private void Linia_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            label_trasa.Visible = true;
            comboBoxTrasa.Visible = true;
            sharedView.LoadRouteNumberIntoComboBox(comboBoxTrasa, Int32.Parse(linia_comboBox.Text));
            comboBoxTrasa.Focus();
        }

        private void ComboBoxTrasa_SelectedIndexChanged(object sender, EventArgs e) {
            mainListBox.Visible = true;
            label_godzina.Visible = true;
            label_lokalizacja.Visible = true;
            label_przystanek.Visible = true;
            label_nr.Visible = true;
            checkBox_czyUtworzycNowaTrase.Visible = true;
            checkBox_czyUtworzycNowaTrase.Focus();

            clearButton.Visible = true;
            addButton.Visible = true;
            create.Visible = true;
            deleteButton.Visible = true;
            trail = new AddTrail(Int32.Parse(this.linia_comboBox.Text), Int32.Parse(this.comboBoxTrasa.Text), false);
            trail.LoadTrailIntoListBox(this.mainListBox);
        }

        private void checkBox_czyUtworzycNowaTrase_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_czyUtworzycNowaTrase.Checked)
                trail = new AddTrail(Int32.Parse(this.linia_comboBox.Text), Int32.Parse(this.comboBoxTrasa.Text), true);
            else
                trail = new AddTrail(Int32.Parse(this.linia_comboBox.Text), Int32.Parse(this.comboBoxTrasa.Text), false);
        }
    }
}
