namespace WindowsFormsApp1 {
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
            this.windowTitle = new System.Windows.Forms.Label();
            this.instructionSublabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePickerLabel = new System.Windows.Forms.Label();
            this.pojazdSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.pojazdSelectionLabel = new System.Windows.Forms.Label();
            this.kierowcaSelectionConboBox = new System.Windows.Forms.ComboBox();
            this.kierowcaSelectionLabel = new System.Windows.Forms.Label();
            this.dataKursuPicker = new System.Windows.Forms.MonthCalendar();
            this.kursSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.kursSelectionLabel = new System.Windows.Forms.Label();
            this.liniaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.liniaSelectionLabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windowTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.windowTitle.Location = new System.Drawing.Point(8, 3);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(158, 21);
            this.windowTitle.TabIndex = 8;
            this.windowTitle.Text = "Przypisanie do kursu";
            this.windowTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.instructionLabel.Location = new System.Drawing.Point(0, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(608, 68);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = " \r\n      Przypisywanie kierowców i pojazdów do kursu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.datePickerLabel);
            this.panel1.Controls.Add(this.pojazdSelectionComboBox);
            this.panel1.Controls.Add(this.pojazdSelectionLabel);
            this.panel1.Controls.Add(this.kierowcaSelectionConboBox);
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
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 374);
            this.panel1.TabIndex = 6;
            // 
            // datePickerLabel
            // 
            this.datePickerLabel.AutoSize = true;
            this.datePickerLabel.Location = new System.Drawing.Point(10, 77);
            this.datePickerLabel.Name = "datePickerLabel";
            this.datePickerLabel.Size = new System.Drawing.Size(120, 13);
            this.datePickerLabel.TabIndex = 19;
            this.datePickerLabel.Text = "Wybierz datę przejazdu:";
            // 
            // pojazdSelectionComboBox
            // 
            this.pojazdSelectionComboBox.FormattingEnabled = true;
            this.pojazdSelectionComboBox.Location = new System.Drawing.Point(309, 272);
            this.pojazdSelectionComboBox.Name = "pojazdSelectionComboBox";
            this.pojazdSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.pojazdSelectionComboBox.TabIndex = 18;
            // 
            // pojazdSelectionLabel
            // 
            this.pojazdSelectionLabel.AutoSize = true;
            this.pojazdSelectionLabel.Location = new System.Drawing.Point(306, 255);
            this.pojazdSelectionLabel.Name = "pojazdSelectionLabel";
            this.pojazdSelectionLabel.Size = new System.Drawing.Size(82, 13);
            this.pojazdSelectionLabel.TabIndex = 17;
            this.pojazdSelectionLabel.Text = "Wybierz pojazd:";
            // 
            // kierowcaSelectionConboBox
            // 
            this.kierowcaSelectionConboBox.FormattingEnabled = true;
            this.kierowcaSelectionConboBox.Location = new System.Drawing.Point(309, 218);
            this.kierowcaSelectionConboBox.Name = "kierowcaSelectionConboBox";
            this.kierowcaSelectionConboBox.Size = new System.Drawing.Size(121, 21);
            this.kierowcaSelectionConboBox.TabIndex = 16;
            // 
            // kierowcaSelectionLabel
            // 
            this.kierowcaSelectionLabel.AutoSize = true;
            this.kierowcaSelectionLabel.Location = new System.Drawing.Point(306, 201);
            this.kierowcaSelectionLabel.Name = "kierowcaSelectionLabel";
            this.kierowcaSelectionLabel.Size = new System.Drawing.Size(94, 13);
            this.kierowcaSelectionLabel.TabIndex = 15;
            this.kierowcaSelectionLabel.Text = "Wybierz kierowcę:";
            // 
            // dataKursuPicker
            // 
            this.dataKursuPicker.Location = new System.Drawing.Point(10, 99);
            this.dataKursuPicker.Name = "dataKursuPicker";
            this.dataKursuPicker.TabIndex = 14;
            // 
            // kursSelectionComboBox
            // 
            this.kursSelectionComboBox.FormattingEnabled = true;
            this.kursSelectionComboBox.Location = new System.Drawing.Point(309, 148);
            this.kursSelectionComboBox.Name = "kursSelectionComboBox";
            this.kursSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.kursSelectionComboBox.TabIndex = 12;
            // 
            // kursSelectionLabel
            // 
            this.kursSelectionLabel.AutoSize = true;
            this.kursSelectionLabel.Location = new System.Drawing.Point(306, 131);
            this.kursSelectionLabel.Name = "kursSelectionLabel";
            this.kursSelectionLabel.Size = new System.Drawing.Size(109, 13);
            this.kursSelectionLabel.TabIndex = 11;
            this.kursSelectionLabel.Text = "Wybierz numer kursu:";
            // 
            // liniaSelectionComboBox
            // 
            this.liniaSelectionComboBox.FormattingEnabled = true;
            this.liniaSelectionComboBox.Location = new System.Drawing.Point(309, 94);
            this.liniaSelectionComboBox.Name = "liniaSelectionComboBox";
            this.liniaSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.liniaSelectionComboBox.TabIndex = 10;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 336);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 28);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(496, 336);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 28);
            this.save.TabIndex = 8;
            this.save.Text = "Przypisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // liniaSelectionLabel
            // 
            this.liniaSelectionLabel.AutoSize = true;
            this.liniaSelectionLabel.Location = new System.Drawing.Point(306, 77);
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
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(560, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 28);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // planowanieRealizacjiKursu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "planowanieRealizacjiKursu";
            this.Text = "przypisywanieKierowcowPojazdowDoRealizacji";
            this.Activated += new System.EventHandler(this.przypisywanieKierowcowPojazdowDoRealizacji_Load);
            this.Load += new System.EventHandler(this.przypisywanieKierowcowPojazdowDoRealizacji_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ComboBox kierowcaSelectionConboBox;
        private System.Windows.Forms.Label kierowcaSelectionLabel;
        private System.Windows.Forms.MonthCalendar dataKursuPicker;
        private System.Windows.Forms.Label datePickerLabel;
    }
}