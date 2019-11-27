namespace hiddenAnaconda.Views
{
    partial class DodawaniePojazdow

    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawaniePojazdow));
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.no1 = new System.Windows.Forms.RadioButton();
            this.yes2 = new System.Windows.Forms.RadioButton();
            this.year_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vin_number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plate_numer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.model_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.mark_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Formularz tworzenia nowego pojazdu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(566, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 30);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.year_number);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.vin_number);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.plate_numer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.model_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.mark_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 374);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.no1);
            this.groupBox2.Controls.Add(this.yes2);
            this.groupBox2.Location = new System.Drawing.Point(341, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 80);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Czy tworzony pojazd jest dostępny?";
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.Location = new System.Drawing.Point(92, 32);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(41, 17);
            this.no1.TabIndex = 7;
            this.no1.TabStop = true;
            this.no1.Text = "Nie";
            this.no1.UseVisualStyleBackColor = true;
            // 
            // yes2
            // 
            this.yes2.AutoSize = true;
            this.yes2.Location = new System.Drawing.Point(31, 32);
            this.yes2.Name = "yes2";
            this.yes2.Size = new System.Drawing.Size(44, 17);
            this.yes2.TabIndex = 6;
            this.yes2.TabStop = true;
            this.yes2.Text = "Tak";
            this.yes2.UseVisualStyleBackColor = true;
            // 
            // year_number
            // 
            this.year_number.HideSelection = false;
            this.year_number.Location = new System.Drawing.Point(20, 291);
            this.year_number.MaxLength = 4;
            this.year_number.Name = "year_number";
            this.year_number.Size = new System.Drawing.Size(109, 20);
            this.year_number.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Podaj rok produkcji tworzonego pojazdu";
            // 
            // vin_number
            // 
            this.vin_number.HideSelection = false;
            this.vin_number.Location = new System.Drawing.Point(20, 241);
            this.vin_number.MaxLength = 4;
            this.vin_number.Name = "vin_number";
            this.vin_number.Size = new System.Drawing.Size(109, 20);
            this.vin_number.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Podaj numer VIN tworzonego pojazdu";
            // 
            // plate_numer
            // 
            this.plate_numer.HideSelection = false;
            this.plate_numer.Location = new System.Drawing.Point(20, 185);
            this.plate_numer.MaxLength = 4;
            this.plate_numer.Name = "plate_numer";
            this.plate_numer.Size = new System.Drawing.Size(109, 20);
            this.plate_numer.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Podaj numer rejestracyjny tworzonego pojazdu";
            // 
            // model_name
            // 
            this.model_name.HideSelection = false;
            this.model_name.Location = new System.Drawing.Point(20, 135);
            this.model_name.MaxLength = 4;
            this.model_name.Name = "model_name";
            this.model_name.Size = new System.Drawing.Size(109, 20);
            this.model_name.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Podaj model tworzonego pojazdu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Location = new System.Drawing.Point(341, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czy tworzony pojazd będzie niskopodłogowy?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(92, 32);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 17);
            this.no.TabIndex = 7;
            this.no.TabStop = true;
            this.no.Text = "Nie";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(31, 32);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(44, 17);
            this.yes.TabIndex = 6;
            this.yes.TabStop = true;
            this.yes.Text = "Tak";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 336);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 28);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.close_on_click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(496, 336);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 28);
            this.create.TabIndex = 8;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // mark_name
            // 
            this.mark_name.HideSelection = false;
            this.mark_name.Location = new System.Drawing.Point(20, 84);
            this.mark_name.MaxLength = 4;
            this.mark_name.Name = "mark_name";
            this.mark_name.Size = new System.Drawing.Size(109, 20);
            this.mark_name.TabIndex = 4;
            this.mark_name.TextChanged += new System.EventHandler(this.mark_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaj marke tworzonego pojazdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby utworzyć nowy pojazd wypełnij poniższy formularz a następnie kliknij utwórz.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(603, 59);
            this.label3.TabIndex = 1;
            this.label3.Text = " \r\n      Tworzenie nowego pojazdu";
            // 
            // help
            // 
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.help.Location = new System.Drawing.Point(522, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 30);
            this.help.TabIndex = 49;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // DodawaniePojazdow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodawaniePojazdow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator Dodawanie Pojazdu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.DodawaniePojazdow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton no1;
        private System.Windows.Forms.RadioButton yes2;
        private System.Windows.Forms.TextBox year_number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vin_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox plate_numer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox model_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox mark_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
