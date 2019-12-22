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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Czas = new System.Windows.Forms.Button();
            this.ZmianaStatusu = new System.Windows.Forms.Button();
            this.Przypisanie = new System.Windows.Forms.Button();
            this.Kierowca = new System.Windows.Forms.Button();
            this.RaportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pojazd = new System.Windows.Forms.Button();
            this.Przystanek = new System.Windows.Forms.Button();
            this.Linia = new System.Windows.Forms.Button();
            this.Trasa = new System.Windows.Forms.Button();
            this.Kurs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(402, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 210);
            this.panel4.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "tworzenie użytkowników";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(402, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Administracja";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(216, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Zarządzanie i raporty:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Czas);
            this.panel3.Controls.Add(this.ZmianaStatusu);
            this.panel3.Controls.Add(this.Przypisanie);
            this.panel3.Controls.Add(this.Trasa);
            this.panel3.Controls.Add(this.Kierowca);
            this.panel3.Controls.Add(this.RaportButton);
            this.panel3.Location = new System.Drawing.Point(216, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 233);
            this.panel3.TabIndex = 32;
            // 
            // Czas
            // 
            this.Czas.Location = new System.Drawing.Point(25, 4);
            this.Czas.Margin = new System.Windows.Forms.Padding(2);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(130, 30);
            this.Czas.TabIndex = 6;
            this.Czas.Text = "czasy realizacji kursu";
            this.Czas.UseVisualStyleBackColor = true;
            this.Czas.Click += new System.EventHandler(this.Czas_Click);
            // 
            // ZmianaStatusu
            // 
            this.ZmianaStatusu.Location = new System.Drawing.Point(25, 107);
            this.ZmianaStatusu.Margin = new System.Windows.Forms.Padding(2);
            this.ZmianaStatusu.Name = "ZmianaStatusu";
            this.ZmianaStatusu.Size = new System.Drawing.Size(130, 30);
            this.ZmianaStatusu.TabIndex = 11;
            this.ZmianaStatusu.Text = "zmiana statusu";
            this.ZmianaStatusu.UseVisualStyleBackColor = true;
            this.ZmianaStatusu.Click += new System.EventHandler(this.ZmianaStatusu_Click);
            // 
            // Przypisanie
            // 
            this.Przypisanie.Location = new System.Drawing.Point(25, 38);
            this.Przypisanie.Margin = new System.Windows.Forms.Padding(2);
            this.Przypisanie.Name = "Przypisanie";
            this.Przypisanie.Size = new System.Drawing.Size(130, 30);
            this.Przypisanie.TabIndex = 7;
            this.Przypisanie.Text = "przypisanie do kursu";
            this.Przypisanie.UseVisualStyleBackColor = true;
            this.Przypisanie.Click += new System.EventHandler(this.Przypisanie_Click);
            // 
            // Kierowca
            // 
            this.Kierowca.Location = new System.Drawing.Point(25, 73);
            this.Kierowca.Margin = new System.Windows.Forms.Padding(2);
            this.Kierowca.Name = "Kierowca";
            this.Kierowca.Size = new System.Drawing.Size(130, 30);
            this.Kierowca.TabIndex = 10;
            this.Kierowca.Text = "dodawanie kierowców";
            this.Kierowca.UseVisualStyleBackColor = true;
            this.Kierowca.Click += new System.EventHandler(this.Kierowca_Click);
            // 
            // RaportButton
            // 
            this.RaportButton.Location = new System.Drawing.Point(25, 142);
            this.RaportButton.Name = "RaportButton";
            this.RaportButton.Size = new System.Drawing.Size(130, 30);
            this.RaportButton.TabIndex = 8;
            this.RaportButton.Text = "raport";
            this.RaportButton.UseVisualStyleBackColor = true;
            this.RaportButton.Click += new System.EventHandler(this.RaportButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tworzenie:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Pojazd);
            this.panel2.Controls.Add(this.Przystanek);
            this.panel2.Controls.Add(this.Linia);
            this.panel2.Controls.Add(this.Kurs);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(29, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 210);
            this.panel2.TabIndex = 30;
            // 
            // Pojazd
            // 
            this.Pojazd.Location = new System.Drawing.Point(25, 4);
            this.Pojazd.Margin = new System.Windows.Forms.Padding(2);
            this.Pojazd.Name = "Pojazd";
            this.Pojazd.Size = new System.Drawing.Size(130, 30);
            this.Pojazd.TabIndex = 0;
            this.Pojazd.Text = "pojazdu";
            this.Pojazd.UseVisualStyleBackColor = true;
            this.Pojazd.Click += new System.EventHandler(this.Pojazd_Click);
            // 
            // Przystanek
            // 
            this.Przystanek.Location = new System.Drawing.Point(25, 38);
            this.Przystanek.Margin = new System.Windows.Forms.Padding(2);
            this.Przystanek.Name = "Przystanek";
            this.Przystanek.Size = new System.Drawing.Size(130, 30);
            this.Przystanek.TabIndex = 1;
            this.Przystanek.Text = "przystanku";
            this.Przystanek.UseVisualStyleBackColor = true;
            this.Przystanek.Click += new System.EventHandler(this.Przystanek_Click);
            // 
            // Linia
            // 
            this.Linia.Location = new System.Drawing.Point(25, 73);
            this.Linia.Margin = new System.Windows.Forms.Padding(2);
            this.Linia.Name = "Linia";
            this.Linia.Size = new System.Drawing.Size(130, 30);
            this.Linia.TabIndex = 2;
            this.Linia.Text = "linii";
            this.Linia.UseVisualStyleBackColor = true;
            this.Linia.Click += new System.EventHandler(this.Linia_Click);
            // 
            // Trasa
            // 
            this.Trasa.Location = new System.Drawing.Point(25, 175);
            this.Trasa.Margin = new System.Windows.Forms.Padding(2);
            this.Trasa.Name = "Trasa";
            this.Trasa.Size = new System.Drawing.Size(130, 30);
            this.Trasa.TabIndex = 3;
            this.Trasa.Text = "zarządzanie trasami";
            this.Trasa.UseVisualStyleBackColor = true;
            this.Trasa.Click += new System.EventHandler(this.Trasa_Click);
            // 
            // Kurs
            // 
            this.Kurs.Location = new System.Drawing.Point(25, 107);
            this.Kurs.Margin = new System.Windows.Forms.Padding(2);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(130, 30);
            this.Kurs.TabIndex = 4;
            this.Kurs.Text = "kursu";
            this.Kurs.UseVisualStyleBackColor = true;
            this.Kurs.Click += new System.EventHandler(this.Kurs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "terminów kursowania";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.manage;
            this.pictureBox2.Location = new System.Drawing.Point(537, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(20, 325);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 40);
            this.create.TabIndex = 14;
            this.create.Text = "Zakończ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wybierz, do którego okna chcesz przejść.";
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
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
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
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.help.TabIndex = 0;
            this.help.TabStop = false;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.MouseEnter += new System.EventHandler(this.hover_helpbutton);
            this.help.MouseLeave += new System.EventHandler(this.leave_helpbutton);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // WybórEkranu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WybórEkranu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WybórEkranu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.WybórEkranu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ZmianaStatusu;
        private System.Windows.Forms.Button RaportButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}