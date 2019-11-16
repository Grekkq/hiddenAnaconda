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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Linia_Click(object sender, EventArgs e)
        {
            Widoki_Bielecki.DodawanieNowejLinii form1 = new Widoki_Bielecki.DodawanieNowejLinii();
            form1.Show();
        }

        private void Trasa_Click(object sender, EventArgs e)
        {
            Widoki_Zagoła.DodawanieTrasy form2 = new Widoki_Zagoła.DodawanieTrasy();
            form2.Show();
        }

        private void Przystanek_Click(object sender, EventArgs e)
        {
            Widoki_Zagoła.DodawaniePrzystanku form3 = new Widoki_Zagoła.DodawaniePrzystanku();
            form3.Show();
        }

        private void Pojazd_Click(object sender, EventArgs e)
        {

        }

        private void Kierowca_Click(object sender, EventArgs e)
        {
            Widoki_Wilk.DodawanieKierowcy form5 = new Widoki_Wilk.DodawanieKierowcy();
            form5.Show();
        }

        private void Kurs_Click(object sender, EventArgs e)
        {

        }

        private void Przypisanie_Click(object sender, EventArgs e)
        {
            planowanieRealizacjiKursu form7 = new planowanieRealizacjiKursu();
            form7.Show();
        }

        private void Czas_Click(object sender, EventArgs e)
        {
            Widoki_Bielecki.WypelnianieCzasuRealizacjiKursu form8 = new Widoki_Bielecki.WypelnianieCzasuRealizacjiKursu();
            form8.Show();
        }
    }
}
