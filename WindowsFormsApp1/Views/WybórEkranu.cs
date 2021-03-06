﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views {
    public partial class WybórEkranu : Form {

        public WybórEkranu() {
            InitializeComponent();
            timer1.Start();
        }

        // funkcje wspólne dla widoków
        SharedView sharedView = new SharedView();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            return sharedView.EscKeyPressed(this, keyData);
        }

        // wyłączenie fokusu na pola tekstowe przy uruchomieniu formularza
        private void TurnoffFocus(object sender, EventArgs e) {
            ActiveControl = null;
        }

        private void Hover_helpbutton(object sender, EventArgs e) {
            sharedView.Hover_helpbutton(help);
        }

        private void Leave_helpbutton(object sender, EventArgs e) {
            sharedView.Leave_helpbutton(help);
        }

        private void Exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Linia_Click(object sender, EventArgs e) {
            using (Views.DodawanieNowejLinii InnerForm = new Views.DodawanieNowejLinii()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Trasa_Click(object sender, EventArgs e) {
            using (Views.DodawanieTrasy InnerForm = new Views.DodawanieTrasy()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Przystanek_Click(object sender, EventArgs e) {
            using (Views.DodawaniePrzystanku InnerForm = new Views.DodawaniePrzystanku()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Pojazd_Click(object sender, EventArgs e) {
            using (Views.DodawaniePojazdow InnerForm = new Views.DodawaniePojazdow()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Kierowca_Click(object sender, EventArgs e) {
            using (Views.DodawanieKierowcy InnerForm = new Views.DodawanieKierowcy()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Kurs_Click(object sender, EventArgs e) {
            using (Views.DodawanieKursu InnerForm = new Views.DodawanieKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Przypisanie_Click(object sender, EventArgs e) {
            using (Views.planowanieRealizacjiKursu InnerForm = new Views.planowanieRealizacjiKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Czas_Click(object sender, EventArgs e) {
            using (Views.WypelnianieCzasuRealizacjiKursu InnerForm = new Views.WypelnianieCzasuRealizacjiKursu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Hover_exitbutton(object sender, EventArgs e) {
            exit.BackColor = Color.FromArgb(218, 83, 44);
        }

        private void Leave_exitbutton(object sender, EventArgs e) {
            exit.BackColor = Color.FromArgb(0, 99, 183);
        }

        private void Move_window(object sender, MouseEventArgs e) {
            sharedView.MoveWindow(sender, e, Handle);
        }

        private void Create_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ZmianaStatusu_Click(object sender, EventArgs e) {
            using (Views.ZmianaStatusu InnerForm = new Views.ZmianaStatusu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void Button2_Click(object sender, EventArgs e) {
            using (Views.DodawanieDniWolnych InnerForm = new Views.DodawanieDniWolnych()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void RaportButton_Click(object sender, EventArgs e) {
            using (Views.TworzenieRaportu InnerForm = new Views.TworzenieRaportu()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void button3_Click(object sender, EventArgs e) {
            using (Views.EdycjaUzytkownikow InnerForm = new Views.EdycjaUzytkownikow()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void button1_Click(object sender, EventArgs e) {
            using (Views.DodawanieUzytkownikow InnerForm = new Views.DodawanieUzytkownikow()) {
                if (InnerForm.ShowDialog() == DialogResult.OK) {
                }
            };
        }

        private void WybórEkranu_Load(object sender, EventArgs e) {
            string permLvl = EkranLogowania.permissionLevel;
            hello.Text = "Witaj, " + EkranLogowania.AccountName + "!";
            if (permLvl == Constants.DriverPermission) { //wylaczanie buttonow dla kierowcy
                pojazdy.Enabled = false;
                przystanki.Enabled = false;
                linie.Enabled = false;
                kursy.Enabled = false;
                terminyKursowania.Enabled = false;
                kursyPrzypisanie.Enabled = false;
                kierowcy.Enabled = false;
                statusZmiana.Enabled = false;
                Raport.Enabled = false;
                trasyZarzadzanie.Enabled = false;
                uzytkownicy.Enabled = false;
                uzytkownicyEdycja.Enabled = false;
            } else if (permLvl == Constants.MenagerPermission) { //wylaczanie buttonow dla menedzera
                uzytkownicy.Enabled = false;
                uzytkownicyEdycja.Enabled = false;
            } else if (permLvl == Constants.RoutePlannerPermission) { //wylaczanie buttonów dla ukladacza tras
                pojazdy.Enabled = false;
                czasyRealizacje.Enabled = false;
                kierowcy.Enabled = false;
                statusZmiana.Enabled = false;
                uzytkownicy.Enabled = false;
                uzytkownicyEdycja.Enabled = false;
            }
        }

        private void Wyloguj_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Hide();
                Form frm = new EkranLogowania();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime dateTime = DateTime.Now;
            Time.Text = dateTime.ToString();
        }

        private void help_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, Constants.HelpPath, HelpNavigator.Topic, "Ekran%20wyboru%20widoków.htm");
        }
    }
}
