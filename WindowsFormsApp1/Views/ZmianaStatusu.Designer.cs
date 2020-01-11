namespace hiddenAnaconda.Views
{
    partial class ZmianaStatusu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZmianaStatusu));
            this.powrot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radio_pracownik = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radio_pojazd = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pojazdSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.pojazdSelectionLabel = new System.Windows.Forms.Label();
            this.kierowcaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.kierowcaSelectionLabel = new System.Windows.Forms.Label();
            this.ObjectRadio = new System.Windows.Forms.GroupBox();
            this.pojazd = new System.Windows.Forms.RadioButton();
            this.kierowca = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.radio_pracownik.SuspendLayout();
            this.radio_pojazd.SuspendLayout();
            this.ObjectRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(20, 335);
            this.powrot.Margin = new System.Windows.Forms.Padding(2);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(80, 30);
            this.powrot.TabIndex = 5;
            this.powrot.Text = "Anuluj";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Formularz zmiany statusu kierowcy/kierowcy";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.exit.Location = new System.Drawing.Point(565, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 30);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.Hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.Leave_exitbutton);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(506, 335);
            this.Aktualizuj.Margin = new System.Windows.Forms.Padding(2);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(80, 30);
            this.Aktualizuj.TabIndex = 4;
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.Aktualizuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby zmienić status pracownika bądź kierowcy wypełnij formularz, a następnie klikn" +
    "ij aktualizuj.";
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
            this.label1.Text = " \r\n      Zmiana statusu";
            // 
            // help
            // 
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.help.Location = new System.Drawing.Point(521, 1);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 30);
            this.help.TabIndex = 1;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.radio_pracownik);
            this.panel1.Controls.Add(this.radio_pojazd);
            this.panel1.Controls.Add(this.pojazdSelectionComboBox);
            this.panel1.Controls.Add(this.pojazdSelectionLabel);
            this.panel1.Controls.Add(this.kierowcaSelectionComboBox);
            this.panel1.Controls.Add(this.kierowcaSelectionLabel);
            this.panel1.Controls.Add(this.ObjectRadio);
            this.panel1.Controls.Add(this.powrot);
            this.panel1.Controls.Add(this.Aktualizuj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // radio_pracownik
            // 
            this.radio_pracownik.Controls.Add(this.radioButton3);
            this.radio_pracownik.Controls.Add(this.radioButton4);
            this.radio_pracownik.Location = new System.Drawing.Point(327, 90);
            this.radio_pracownik.Name = "radio_pracownik";
            this.radio_pracownik.Size = new System.Drawing.Size(259, 80);
            this.radio_pracownik.TabIndex = 3;
            this.radio_pracownik.TabStop = false;
            this.radio_pracownik.Text = "Zmień status na:";
            this.radio_pracownik.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(131, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "nie pracuje";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(65, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "pracuje";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radio_pojazd
            // 
            this.radio_pojazd.Controls.Add(this.radioButton1);
            this.radio_pojazd.Controls.Add(this.radioButton2);
            this.radio_pojazd.Location = new System.Drawing.Point(327, 90);
            this.radio_pojazd.Name = "radio_pojazd";
            this.radio_pojazd.Size = new System.Drawing.Size(259, 80);
            this.radio_pojazd.TabIndex = 2;
            this.radio_pojazd.TabStop = false;
            this.radio_pojazd.Text = "Zmień status";
            this.radio_pojazd.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(115, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sprawny";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "niesprawny";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // pojazdSelectionComboBox
            // 
            this.pojazdSelectionComboBox.FormattingEnabled = true;
            this.pojazdSelectionComboBox.Items.AddRange(new object[] {
            "Mercedes - SG 6743K, sprawny",
            "Solaris - SK 98551, sprawny",
            "Man - ST 12985, niesprawny"});
            this.pojazdSelectionComboBox.Location = new System.Drawing.Point(18, 210);
            this.pojazdSelectionComboBox.Name = "pojazdSelectionComboBox";
            this.pojazdSelectionComboBox.Size = new System.Drawing.Size(220, 21);
            this.pojazdSelectionComboBox.TabIndex = 1;
            this.pojazdSelectionComboBox.Visible = false;
            this.pojazdSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.pojazdSelectionComboBox_SelectedIndexChanged);
            this.pojazdSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.pojazdSelectionComboBox_Validating);
            // 
            // pojazdSelectionLabel
            // 
            this.pojazdSelectionLabel.AutoSize = true;
            this.pojazdSelectionLabel.Location = new System.Drawing.Point(16, 190);
            this.pojazdSelectionLabel.Name = "pojazdSelectionLabel";
            this.pojazdSelectionLabel.Size = new System.Drawing.Size(82, 13);
            this.pojazdSelectionLabel.TabIndex = 4;
            this.pojazdSelectionLabel.Text = "Wybierz pojazd:";
            this.pojazdSelectionLabel.Visible = false;
            // 
            // kierowcaSelectionComboBox
            // 
            this.kierowcaSelectionComboBox.FormattingEnabled = true;
            this.kierowcaSelectionComboBox.Items.AddRange(new object[] {
            "Kowalski Jan, pracuje",
            "Zielnik Piotr, nie pracuje",
            "Gawron Małgorzata, chorobowe"});
            this.kierowcaSelectionComboBox.Location = new System.Drawing.Point(18, 210);
            this.kierowcaSelectionComboBox.Name = "kierowcaSelectionComboBox";
            this.kierowcaSelectionComboBox.Size = new System.Drawing.Size(160, 21);
            this.kierowcaSelectionComboBox.TabIndex = 2;
            this.kierowcaSelectionComboBox.Visible = false;
            this.kierowcaSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.kierowcaSelectionComboBox_SelectedIndexChanged);
            this.kierowcaSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.kierowcaSelectionComboBox_Validating);
            // 
            // kierowcaSelectionLabel
            // 
            this.kierowcaSelectionLabel.AutoSize = true;
            this.kierowcaSelectionLabel.Location = new System.Drawing.Point(16, 190);
            this.kierowcaSelectionLabel.Name = "kierowcaSelectionLabel";
            this.kierowcaSelectionLabel.Size = new System.Drawing.Size(94, 13);
            this.kierowcaSelectionLabel.TabIndex = 1;
            this.kierowcaSelectionLabel.Text = "Wybierz kierowcę:";
            this.kierowcaSelectionLabel.Visible = false;
            // 
            // ObjectRadio
            // 
            this.ObjectRadio.Controls.Add(this.pojazd);
            this.ObjectRadio.Controls.Add(this.kierowca);
            this.ObjectRadio.Location = new System.Drawing.Point(16, 90);
            this.ObjectRadio.Name = "ObjectRadio";
            this.ObjectRadio.Size = new System.Drawing.Size(245, 80);
            this.ObjectRadio.TabIndex = 0;
            this.ObjectRadio.TabStop = false;
            this.ObjectRadio.Text = "Zmiana statusu dotyczy:";
            // 
            // pojazd
            // 
            this.pojazd.AutoSize = true;
            this.pojazd.Location = new System.Drawing.Point(105, 32);
            this.pojazd.Name = "pojazd";
            this.pojazd.Size = new System.Drawing.Size(62, 17);
            this.pojazd.TabIndex = 1;
            this.pojazd.TabStop = true;
            this.pojazd.Text = "pojazdu";
            this.pojazd.UseVisualStyleBackColor = true;
            this.pojazd.CheckedChanged += new System.EventHandler(this.pojazd_CheckedChanged);
            // 
            // kierowca
            // 
            this.kierowca.AutoSize = true;
            this.kierowca.Location = new System.Drawing.Point(31, 32);
            this.kierowca.Name = "kierowca";
            this.kierowca.Size = new System.Drawing.Size(67, 17);
            this.kierowca.TabIndex = 0;
            this.kierowca.TabStop = true;
            this.kierowca.Text = "kierowcy";
            this.kierowca.UseVisualStyleBackColor = true;
            this.kierowca.CheckedChanged += new System.EventHandler(this.kierowca_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ZmianaStatusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZmianaStatusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZmianaStatusu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.ZmianaStatusu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.radio_pracownik.ResumeLayout(false);
            this.radio_pracownik.PerformLayout();
            this.radio_pojazd.ResumeLayout(false);
            this.radio_pojazd.PerformLayout();
            this.ObjectRadio.ResumeLayout(false);
            this.ObjectRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ObjectRadio;
        private System.Windows.Forms.RadioButton pojazd;
        private System.Windows.Forms.RadioButton kierowca;
        private System.Windows.Forms.GroupBox radio_pojazd;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox pojazdSelectionComboBox;
        private System.Windows.Forms.Label pojazdSelectionLabel;
        private System.Windows.Forms.ComboBox kierowcaSelectionComboBox;
        private System.Windows.Forms.Label kierowcaSelectionLabel;
        private System.Windows.Forms.GroupBox radio_pracownik;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}