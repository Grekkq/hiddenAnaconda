namespace hiddenAnaconda.Views {
    partial class WybórEkranu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WybórEkranu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Czas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Przypisanie = new System.Windows.Forms.Button();
            this.Kurs = new System.Windows.Forms.Button();
            this.Kierowca = new System.Windows.Forms.Button();
            this.Pojazd = new System.Windows.Forms.Button();
            this.Przystanek = new System.Windows.Forms.Button();
            this.Trasa = new System.Windows.Forms.Button();
            this.Linia = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.Czas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Przypisanie);
            this.panel1.Controls.Add(this.Kurs);
            this.panel1.Controls.Add(this.Kierowca);
            this.panel1.Controls.Add(this.Pojazd);
            this.panel1.Controls.Add(this.Przystanek);
            this.panel1.Controls.Add(this.Trasa);
            this.panel1.Controls.Add(this.Linia);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Czas
            // 
            this.Czas.Location = new System.Drawing.Point(291, 240);
            this.Czas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(128, 41);
            this.Czas.TabIndex = 19;
            this.Czas.Text = "Faktyczny Czas Realizacji";
            this.Czas.UseVisualStyleBackColor = true;
            this.Czas.Click += new System.EventHandler(this.Czas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wybierz do którego okna chcesz przejść";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 68);
            this.label1.TabIndex = 17;
            this.label1.Text = " \r\n      Wybór Ekranu";
            // 
            // Przypisanie
            // 
            this.Przypisanie.Location = new System.Drawing.Point(291, 193);
            this.Przypisanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Przypisanie.Name = "Przypisanie";
            this.Przypisanie.Size = new System.Drawing.Size(128, 41);
            this.Przypisanie.TabIndex = 16;
            this.Przypisanie.Text = "Przypisanie Do Kursu";
            this.Przypisanie.UseVisualStyleBackColor = true;
            this.Przypisanie.Click += new System.EventHandler(this.Przypisanie_Click);
            // 
            // Kurs
            // 
            this.Kurs.Location = new System.Drawing.Point(291, 147);
            this.Kurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(128, 41);
            this.Kurs.TabIndex = 15;
            this.Kurs.Text = "Dodanie Kursu";
            this.Kurs.UseVisualStyleBackColor = true;
            this.Kurs.Click += new System.EventHandler(this.Kurs_Click);
            // 
            // Kierowca
            // 
            this.Kierowca.Location = new System.Drawing.Point(291, 101);
            this.Kierowca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kierowca.Name = "Kierowca";
            this.Kierowca.Size = new System.Drawing.Size(128, 41);
            this.Kierowca.TabIndex = 14;
            this.Kierowca.Text = "Dodawanie Kierowców";
            this.Kierowca.UseVisualStyleBackColor = true;
            this.Kierowca.Click += new System.EventHandler(this.Kierowca_Click);
            // 
            // Pojazd
            // 
            this.Pojazd.Location = new System.Drawing.Point(159, 240);
            this.Pojazd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pojazd.Name = "Pojazd";
            this.Pojazd.Size = new System.Drawing.Size(128, 41);
            this.Pojazd.TabIndex = 13;
            this.Pojazd.Text = "Dodawanie Pojazdu";
            this.Pojazd.UseVisualStyleBackColor = true;
            this.Pojazd.Click += new System.EventHandler(this.Pojazd_Click);
            // 
            // Przystanek
            // 
            this.Przystanek.Location = new System.Drawing.Point(159, 193);
            this.Przystanek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Przystanek.Name = "Przystanek";
            this.Przystanek.Size = new System.Drawing.Size(128, 41);
            this.Przystanek.TabIndex = 12;
            this.Przystanek.Text = "Dodawanie Przystanku";
            this.Przystanek.UseVisualStyleBackColor = true;
            this.Przystanek.Click += new System.EventHandler(this.Przystanek_Click);
            // 
            // Trasa
            // 
            this.Trasa.Location = new System.Drawing.Point(159, 147);
            this.Trasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Trasa.Name = "Trasa";
            this.Trasa.Size = new System.Drawing.Size(128, 41);
            this.Trasa.TabIndex = 11;
            this.Trasa.Text = "Dodawanie Trasy";
            this.Trasa.UseVisualStyleBackColor = true;
            this.Trasa.Click += new System.EventHandler(this.Trasa_Click);
            // 
            // Linia
            // 
            this.Linia.Location = new System.Drawing.Point(159, 101);
            this.Linia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Linia.Name = "Linia";
            this.Linia.Size = new System.Drawing.Size(128, 41);
            this.Linia.TabIndex = 10;
            this.Linia.Text = "Dodawanie Lini";
            this.Linia.UseVisualStyleBackColor = true;
            this.Linia.Click += new System.EventHandler(this.Linia_Click);
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
            this.exit.TabIndex = 6;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wybór Ekranów";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
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
            this.help.TabIndex = 20;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.MouseEnter += new System.EventHandler(this.hover_helpbutton);
            this.help.MouseLeave += new System.EventHandler(this.leave_helpbutton);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(20, 325);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 40);
            this.create.TabIndex = 20;
            this.create.Text = "Zakończ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // WybórEkranu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WybórEkranu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WybórEkranu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.WybórEkranu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Czas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Przypisanie;
        private System.Windows.Forms.Button Kurs;
        private System.Windows.Forms.Button Kierowca;
        private System.Windows.Forms.Button Pojazd;
        private System.Windows.Forms.Button Przystanek;
        private System.Windows.Forms.Button Trasa;
        private System.Windows.Forms.Button Linia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button create;
    }
}