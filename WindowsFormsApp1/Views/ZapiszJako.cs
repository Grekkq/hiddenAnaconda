using hiddenAnaconda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class ZapiszJako : Form {
        public ZapiszJako() {
            InitializeComponent();
        }

        public ZapiszJako(Dictionary<string, string> argsForTimeTableConstructor) {
            InitializeComponent();
            this.argsForTimeTableConstructor = argsForTimeTableConstructor;
            this.BusStopName = argsForTimeTableConstructor[Constants.BusStopName];
            this.CityName = argsForTimeTableConstructor[Constants.BusStopCityName];
            this.Way = argsForTimeTableConstructor[Constants.BusStopWay];
        }
        bool ErrorIsOn = false;
        SharedView sharedView = new SharedView();
        Dictionary<string, string> argsForTimeTableConstructor = new Dictionary<string, string>();
        string BusStopName, CityName, Way;
        private void turnoffFocus(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_przegladaj_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                textBox_path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_zapisz_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_name.Text)) {
                MessageBox.Show("Nie podano nazwy raportu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Regex regex = new Regex(@"^[\w\-. ]+$");
                if (!regex.IsMatch(textBox_name.Text)) {
                    MessageBox.Show("Nieprawidłowa nazwa pliku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    new TimeTable(CityName, BusStopName, Way, textBox_name.Text, textBox_path.Text).GenerateTimetable();
                    //new TimeTable(CityName, BusStopName, Way, textBox_name.Text, textBox_path.Text).GetAllDayTypeForLine(710);
                    MessageBox.Show("Raport został pomyślnie wygenerowany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void button_anuluj_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ZapiszJako_Load(object sender, EventArgs e) {
            textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.AcceptButton = button_zapisz;
        }
    }
}
