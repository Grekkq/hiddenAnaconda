using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenAnaconda.Views
{
    public partial class DodawaniePojazdow : Form
    {

        SharedView sharedView = new SharedView();
        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sharedView.moveWindow(sender, e, Handle);
            }
        }

        private void hover_exitbutton(object sender, EventArgs e)
        {
            sharedView.hover_exitbutton(exit);
        }

        private void leave_exitbutton(object sender, EventArgs e)
        {
            sharedView.leave_exitbutton(exit);
        }

        public DodawaniePojazdow()
        {
            InitializeComponent();
        }
        private void turnoffFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void close_on_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mark_name_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == ' ') || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-'))
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }
        private void mark_name_TextChanged(object sender, EventArgs e)
        {
            mark_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.mark_name.Text);
            mark_name.Select(mark_name.Text.Length, 0);
        }
        private void create_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(mark_name.Text)))
            {
                MessageBox.Show("Nie wypełniono pola marka", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(model_name.Text)))
            {
                MessageBox.Show("Nie wypełniono pola model.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(plate_numer.Text)))
            {
                MessageBox.Show("Nie wypełniono pola numer rejestracyjny pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(vin_number.Text)))
            {
                MessageBox.Show("Nie wypełniono pola numer VIN pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(year_number.Text)))
            {
                MessageBox.Show("Nie wypełniono pola rok produkcji pojazdu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (yes.Checked == false && no.Checked == false)
            {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (yes2.Checked == false && no1.Checked == false)
            {
                MessageBox.Show("Nie zaznaczono odpowiedz na pytanie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                const string message = "Pomyślnie utworzono nowy pojazd";
                const string caption = "Sukces";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DodawaniePojazdow_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void vin_number_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'I') || (e.KeyChar == 'i') || (e.KeyChar == 'o') || (e.KeyChar == 'O') || (e.KeyChar == 'q') || (e.KeyChar == 'Q'))
                e.Handled = true;
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void vin_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void plate_number_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void model_name_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == ' ') || (e.KeyChar == '-') || (e.KeyChar == '+'))
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void model_name_TextChanged(object sender, EventArgs e)
        {
            model_name.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.model_name.Text);
            model_name.Select(model_name.Text.Length, 0);
        }

        private void plate_numer_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_number_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void year_number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}