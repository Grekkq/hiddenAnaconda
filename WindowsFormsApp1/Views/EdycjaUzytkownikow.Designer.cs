namespace hiddenAnaconda.Views {
    partial class EdycjaUzytkownikow {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdycjaUzytkownikow));
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_uprawnienia = new System.Windows.Forms.ComboBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.radioButton_nieaktywne = new System.Windows.Forms.RadioButton();
            this.radioButton_aktywne = new System.Windows.Forms.RadioButton();
            this.groupBox_status_uprawnienia = new System.Windows.Forms.GroupBox();
            this.radio_uprawnienia = new System.Windows.Forms.RadioButton();
            this.radio_status = new System.Windows.Forms.RadioButton();
            this.comboBox_uzytkownik = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_uprawnienia = new System.Windows.Forms.Label();
            this.label_nazwaUzytkownika = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox_status.SuspendLayout();
            this.groupBox_status_uprawnienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 335);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(507, 335);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 30);
            this.create.TabIndex = 3;
            this.create.Text = "Zapisz";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.comboBox_uprawnienia);
            this.panel1.Controls.Add(this.groupBox_status);
            this.panel1.Controls.Add(this.groupBox_status_uprawnienia);
            this.panel1.Controls.Add(this.comboBox_uzytkownik);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label_uprawnienia);
            this.panel1.Controls.Add(this.label_nazwaUzytkownika);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 55;
            // 
            // comboBox_uprawnienia
            // 
            this.comboBox_uprawnienia.FormattingEnabled = true;
            this.comboBox_uprawnienia.ItemHeight = 13;
            this.comboBox_uprawnienia.Items.AddRange(new object[] {
            "Kierowca",
            "Menedżer",
            "Układacz Tras",
            "Administrator"});
            this.comboBox_uprawnienia.Location = new System.Drawing.Point(18, 260);
            this.comboBox_uprawnienia.Name = "comboBox_uprawnienia";
            this.comboBox_uprawnienia.Size = new System.Drawing.Size(150, 21);
            this.comboBox_uprawnienia.TabIndex = 2;
            this.comboBox_uprawnienia.SelectedIndexChanged += new System.EventHandler(this.comboBox_uprawnienia_SelectedIndexChanged);
            this.comboBox_uprawnienia.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_uprawnienia_Validating);
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.radioButton_nieaktywne);
            this.groupBox_status.Controls.Add(this.radioButton_aktywne);
            this.groupBox_status.Location = new System.Drawing.Point(16, 226);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(174, 68);
            this.groupBox_status.TabIndex = 2;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "Zmień status konta na:";
            // 
            // radioButton_nieaktywne
            // 
            this.radioButton_nieaktywne.AutoSize = true;
            this.radioButton_nieaktywne.Location = new System.Drawing.Point(90, 32);
            this.radioButton_nieaktywne.Name = "radioButton_nieaktywne";
            this.radioButton_nieaktywne.Size = new System.Drawing.Size(81, 17);
            this.radioButton_nieaktywne.TabIndex = 2;
            this.radioButton_nieaktywne.TabStop = true;
            this.radioButton_nieaktywne.Text = "Nieaktywne";
            this.radioButton_nieaktywne.UseVisualStyleBackColor = true;
            // 
            // radioButton_aktywne
            // 
            this.radioButton_aktywne.AutoSize = true;
            this.radioButton_aktywne.Location = new System.Drawing.Point(18, 32);
            this.radioButton_aktywne.Name = "radioButton_aktywne";
            this.radioButton_aktywne.Size = new System.Drawing.Size(66, 17);
            this.radioButton_aktywne.TabIndex = 0;
            this.radioButton_aktywne.TabStop = true;
            this.radioButton_aktywne.Text = "Aktywne";
            this.radioButton_aktywne.UseVisualStyleBackColor = true;
            // 
            // groupBox_status_uprawnienia
            // 
            this.groupBox_status_uprawnienia.Controls.Add(this.radio_uprawnienia);
            this.groupBox_status_uprawnienia.Controls.Add(this.radio_status);
            this.groupBox_status_uprawnienia.Location = new System.Drawing.Point(16, 140);
            this.groupBox_status_uprawnienia.Name = "groupBox_status_uprawnienia";
            this.groupBox_status_uprawnienia.Size = new System.Drawing.Size(243, 80);
            this.groupBox_status_uprawnienia.TabIndex = 1;
            this.groupBox_status_uprawnienia.TabStop = false;
            this.groupBox_status_uprawnienia.Text = "Edycja dotyczy:";
            // 
            // radio_uprawnienia
            // 
            this.radio_uprawnienia.AutoSize = true;
            this.radio_uprawnienia.Location = new System.Drawing.Point(113, 32);
            this.radio_uprawnienia.Name = "radio_uprawnienia";
            this.radio_uprawnienia.Size = new System.Drawing.Size(117, 17);
            this.radio_uprawnienia.TabIndex = 1;
            this.radio_uprawnienia.TabStop = true;
            this.radio_uprawnienia.Text = "Poziomu uprawnień";
            this.radio_uprawnienia.UseVisualStyleBackColor = true;
            this.radio_uprawnienia.CheckedChanged += new System.EventHandler(this.radio_uprawnienia_CheckedChanged);
            // 
            // radio_status
            // 
            this.radio_status.AutoSize = true;
            this.radio_status.Location = new System.Drawing.Point(16, 32);
            this.radio_status.Name = "radio_status";
            this.radio_status.Size = new System.Drawing.Size(91, 17);
            this.radio_status.TabIndex = 0;
            this.radio_status.TabStop = true;
            this.radio_status.Text = "Statusu konta";
            this.radio_status.UseVisualStyleBackColor = true;
            this.radio_status.CheckedChanged += new System.EventHandler(this.radio_status_CheckedChanged);
            // 
            // comboBox_uzytkownik
            // 
            this.comboBox_uzytkownik.FormattingEnabled = true;
            this.comboBox_uzytkownik.Location = new System.Drawing.Point(18, 110);
            this.comboBox_uzytkownik.Name = "comboBox_uzytkownik";
            this.comboBox_uzytkownik.Size = new System.Drawing.Size(120, 21);
            this.comboBox_uzytkownik.TabIndex = 0;
            this.comboBox_uzytkownik.SelectedIndexChanged += new System.EventHandler(this.comboBox_uzytkownik_SelectedIndexChanged);
            this.comboBox_uzytkownik.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_uzytkownik_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(537, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label_uprawnienia
            // 
            this.label_uprawnienia.AutoSize = true;
            this.label_uprawnienia.Location = new System.Drawing.Point(16, 240);
            this.label_uprawnienia.Name = "label_uprawnienia";
            this.label_uprawnienia.Size = new System.Drawing.Size(164, 13);
            this.label_uprawnienia.TabIndex = 13;
            this.label_uprawnienia.Text = "Wybierz nowy poziom uprawnień:";
            // 
            // label_nazwaUzytkownika
            // 
            this.label_nazwaUzytkownika.AutoSize = true;
            this.label_nazwaUzytkownika.Location = new System.Drawing.Point(16, 90);
            this.label_nazwaUzytkownika.Name = "label_nazwaUzytkownika";
            this.label_nazwaUzytkownika.Size = new System.Drawing.Size(107, 13);
            this.label_nazwaUzytkownika.TabIndex = 13;
            this.label_nazwaUzytkownika.Text = "Wybierz użytkownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby dokonać edycji użytkownika wybierz jego konto.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = " \r\n      Edycja użytkowników";
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
            this.help.TabIndex = 58;
            this.help.TabStop = false;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(25, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Formularz edycji użytkowników";
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
            this.exit.TabIndex = 56;
            this.exit.TabStop = false;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // EdycjaUzytkownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdycjaUzytkownikow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdycjaUżytkowników";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.EdycjaUżytkowników_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
            this.groupBox_status_uprawnienia.ResumeLayout(false);
            this.groupBox_status_uprawnienia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label_nazwaUzytkownika;
        private System.Windows.Forms.ComboBox comboBox_uzytkownik;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.RadioButton radioButton_nieaktywne;
        private System.Windows.Forms.RadioButton radioButton_aktywne;
        private System.Windows.Forms.GroupBox groupBox_status_uprawnienia;
        private System.Windows.Forms.RadioButton radio_uprawnienia;
        private System.Windows.Forms.RadioButton radio_status;
        private System.Windows.Forms.ComboBox comboBox_uprawnienia;
        private System.Windows.Forms.Label label_uprawnienia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}