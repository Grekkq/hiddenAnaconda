using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Widoki_Wilk
{
    public partial class WybórEkranu : Form
    {
        public WybórEkranu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Linia_Click(object sender, EventArgs e)
        {
            Widoki_Bielecki.DodawanieNowejLinii form = new Widoki_Bielecki.DodawanieNowejLinii();
            form.Show();
        }

        private void Trasa_Click(object sender, EventArgs e)
        {
            Widoki_Zagoła.DodawanieTrasy form = new Widoki_Zagoła.DodawanieTrasy();
            form.Show();
        }

        private void Przystanek_Click(object sender, EventArgs e)
        {
            Widoki_Zagoła.DodawaniePrzystanku form = new Widoki_Zagoła.DodawaniePrzystanku();
            form.Show();
        }

        private void Pojazd_Click(object sender, EventArgs e)
        {
            Widoki_Mastaliński.DodawaniePojazdow form = new Widoki_Mastaliński.DodawaniePojazdow();
            form.Show();
        }

        private void Kierowca_Click(object sender, EventArgs e)
        {
            Widoki_Wilk.DodawanieKierowcy form = new Widoki_Wilk.DodawanieKierowcy();
            form.Show();
        }

        private void Kurs_Click(object sender, EventArgs e)
        {
            Widoki_Mastaliński.DodawanieKursu form = new Widoki_Mastaliński.DodawanieKursu();
            form.Show();
        }

        private void Przypisanie_Click(object sender, EventArgs e)
        {
            planowanieRealizacjiKursu form = new planowanieRealizacjiKursu();
            form.Show();
        }

        private void Czas_Click(object sender, EventArgs e)
        {
            Widoki_Bielecki.WypelnianieCzasuRealizacjiKursu form = new Widoki_Bielecki.WypelnianieCzasuRealizacjiKursu();
            form.Show();
        }
    }
}
