namespace hiddenAnaconda.Views {
    partial class planowanieRealizacjiKursu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planowanieRealizacjiKursu));
            this.windowTitle = new System.Windows.Forms.Label();
            this.instructionSublabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datePickerLabel = new System.Windows.Forms.Label();
            this.pojazdSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.pojazdSelectionLabel = new System.Windows.Forms.Label();
            this.kierowcaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.kierowcaSelectionLabel = new System.Windows.Forms.Label();
            this.dataKursuPicker = new System.Windows.Forms.MonthCalendar();
            this.kursSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.kursSelectionLabel = new System.Windows.Forms.Label();
            this.liniaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.liniaSelectionLabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windowTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.windowTitle.Location = new System.Drawing.Point(28, 4);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(234, 21);
            this.windowTitle.TabIndex = 8;
            this.windowTitle.Text = "Formularz przypisania do kursu";
            this.windowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_window);
            // 
            // instructionSublabel
            // 
            this.instructionSublabel.AutoSize = true;
            this.instructionSublabel.BackColor = System.Drawing.Color.White;
            this.instructionSublabel.Location = new System.Drawing.Point(29, 33);
            this.instructionSublabel.Name = "instructionSublabel";
            this.instructionSublabel.Size = new System.Drawing.Size(477, 13);
            this.instructionSublabel.TabIndex = 2;
            this.instructionSublabel.Text = "Aby przypisać kierowcę i pojazd do kursu w pierwszej kolejności wybierz datę i in" +
    "teresujący cię kurs.";
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instructionLabel.Location = new System.Drawing.Point(-1, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(608, 68);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = " \r\n      Przypisywanie kierowców i pojazdów do kursu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.datePickerLabel);
            this.panel1.Controls.Add(this.pojazdSelectionComboBox);
            this.panel1.Controls.Add(this.pojazdSelectionLabel);
            this.panel1.Controls.Add(this.kierowcaSelectionComboBox);
            this.panel1.Controls.Add(this.kierowcaSelectionLabel);
            this.panel1.Controls.Add(this.dataKursuPicker);
            this.panel1.Controls.Add(this.kursSelectionComboBox);
            this.panel1.Controls.Add(this.kursSelectionLabel);
            this.panel1.Controls.Add(this.liniaSelectionComboBox);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.liniaSelectionLabel);
            this.panel1.Controls.Add(this.instructionSublabel);
            this.panel1.Controls.Add(this.instructionLabel);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.bus_driver1;
            this.pictureBox2.Location = new System.Drawing.Point(506, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // datePickerLabel
            // 
            this.datePickerLabel.AutoSize = true;
            this.datePickerLabel.Location = new System.Drawing.Point(398, 90);
            this.datePickerLabel.Name = "datePickerLabel";
            this.datePickerLabel.Size = new System.Drawing.Size(120, 13);
            this.datePickerLabel.TabIndex = 19;
            this.datePickerLabel.Text = "Wybierz datę przejazdu:";
            // 
            // pojazdSelectionComboBox
            // 
            this.pojazdSelectionComboBox.FormattingEnabled = true;
            this.pojazdSelectionComboBox.Items.AddRange(new object[] {
            "Mercedes - SG 6743K",
            "Solaris - SK 98551",
            "Man - ST 12985"});
            this.pojazdSelectionComboBox.Location = new System.Drawing.Point(18, 260);
            this.pojazdSelectionComboBox.Name = "pojazdSelectionComboBox";
            this.pojazdSelectionComboBox.Size = new System.Drawing.Size(150, 21);
            this.pojazdSelectionComboBox.TabIndex = 3;
            this.pojazdSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.pojazdSelectionComboBox_SelectedIndexChanged);
            this.pojazdSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.pojazdSelectionComboBox_Validating);
            // 
            // pojazdSelectionLabel
            // 
            this.pojazdSelectionLabel.AutoSize = true;
            this.pojazdSelectionLabel.Location = new System.Drawing.Point(16, 240);
            this.pojazdSelectionLabel.Name = "pojazdSelectionLabel";
            this.pojazdSelectionLabel.Size = new System.Drawing.Size(82, 13);
            this.pojazdSelectionLabel.TabIndex = 17;
            this.pojazdSelectionLabel.Text = "Wybierz pojazd:";
            // 
            // kierowcaSelectionComboBox
            // 
            this.kierowcaSelectionComboBox.FormattingEnabled = true;
            this.kierowcaSelectionComboBox.Items.AddRange(new object[] {
            "Kowalski Jan",
            "Zielnik Piotr",
            "Gawron Małgorzata"});
            this.kierowcaSelectionComboBox.Location = new System.Drawing.Point(18, 210);
            this.kierowcaSelectionComboBox.Name = "kierowcaSelectionComboBox";
            this.kierowcaSelectionComboBox.Size = new System.Drawing.Size(150, 21);
            this.kierowcaSelectionComboBox.TabIndex = 2;
            this.kierowcaSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.kierowcaSelectionComboBox_SelectedIndexChanged);
            this.kierowcaSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.kierowcaSelectionComboBox_Validating);
            // 
            // kierowcaSelectionLabel
            // 
            this.kierowcaSelectionLabel.AutoSize = true;
            this.kierowcaSelectionLabel.Location = new System.Drawing.Point(16, 190);
            this.kierowcaSelectionLabel.Name = "kierowcaSelectionLabel";
            this.kierowcaSelectionLabel.Size = new System.Drawing.Size(94, 13);
            this.kierowcaSelectionLabel.TabIndex = 15;
            this.kierowcaSelectionLabel.Text = "Wybierz kierowcę:";
            // 
            // dataKursuPicker
            // 
            this.dataKursuPicker.Location = new System.Drawing.Point(317, 110);
            this.dataKursuPicker.MaxSelectionCount = 1;
            this.dataKursuPicker.Name = "dataKursuPicker";
            this.dataKursuPicker.TabIndex = 4;
            this.dataKursuPicker.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dataKursuPicker_DateChanged);
            // 
            // kursSelectionComboBox
            // 
            this.kursSelectionComboBox.FormattingEnabled = true;
            this.kursSelectionComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.kursSelectionComboBox.Location = new System.Drawing.Point(18, 160);
            this.kursSelectionComboBox.Name = "kursSelectionComboBox";
            this.kursSelectionComboBox.Size = new System.Drawing.Size(150, 21);
            this.kursSelectionComboBox.TabIndex = 1;
            this.kursSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.KursSelectionComboBox_SelectedIndexChanged);
            this.kursSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.KursSelectionComboBox_Validating);
            // 
            // kursSelectionLabel
            // 
            this.kursSelectionLabel.AutoSize = true;
            this.kursSelectionLabel.Location = new System.Drawing.Point(16, 140);
            this.kursSelectionLabel.Name = "kursSelectionLabel";
            this.kursSelectionLabel.Size = new System.Drawing.Size(109, 13);
            this.kursSelectionLabel.TabIndex = 11;
            this.kursSelectionLabel.Text = "Wybierz numer kursu:";
            // 
            // liniaSelectionComboBox
            // 
            this.liniaSelectionComboBox.FormattingEnabled = true;
            this.liniaSelectionComboBox.Items.AddRange(new object[] {
            "32",
            "617",
            "A4"});
            this.liniaSelectionComboBox.Location = new System.Drawing.Point(18, 110);
            this.liniaSelectionComboBox.Name = "liniaSelectionComboBox";
            this.liniaSelectionComboBox.Size = new System.Drawing.Size(120, 21);
            this.liniaSelectionComboBox.TabIndex = 0;
            this.liniaSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.LiniaSelectionComboBox_SelectedIndexChanged);
            this.liniaSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.LiniaSelectionComboBox_Validating);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 335);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(507, 335);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 30);
            this.save.TabIndex = 5;
            this.save.Text = "Przypisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // liniaSelectionLabel
            // 
            this.liniaSelectionLabel.AutoSize = true;
            this.liniaSelectionLabel.Location = new System.Drawing.Point(16, 90);
            this.liniaSelectionLabel.Name = "liniaSelectionLabel";
            this.liniaSelectionLabel.Size = new System.Drawing.Size(69, 13);
            this.liniaSelectionLabel.TabIndex = 3;
            this.liniaSelectionLabel.Text = "Wybierz linię:";
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
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.Hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.Leave_exitbutton);
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
            this.help.TabIndex = 1;
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
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // planowanieRealizacjiKursu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "planowanieRealizacjiKursu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "przypisywanieKierowcowPojazdowDoRealizacji";
            this.Activated += new System.EventHandler(this.PrzypisywanieKierowcowPojazdowDoRealizacji_Load);
            this.Load += new System.EventHandler(this.PrzypisywanieKierowcowPojazdowDoRealizacji_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label instructionSublabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label liniaSelectionLabel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox liniaSelectionComboBox;
        private System.Windows.Forms.ComboBox kursSelectionComboBox;
        private System.Windows.Forms.Label kursSelectionLabel;
        private System.Windows.Forms.ComboBox pojazdSelectionComboBox;
        private System.Windows.Forms.Label pojazdSelectionLabel;
        private System.Windows.Forms.ComboBox kierowcaSelectionComboBox;
        private System.Windows.Forms.Label kierowcaSelectionLabel;
        private System.Windows.Forms.MonthCalendar dataKursuPicker;
        private System.Windows.Forms.Label datePickerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}