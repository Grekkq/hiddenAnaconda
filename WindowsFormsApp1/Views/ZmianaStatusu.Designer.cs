﻿namespace hiddenAnaconda.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZmianaStatusu));
            this.powrot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_pracownik = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radio_pojazd = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pojazdSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.pojazdSelectionLabel = new System.Windows.Forms.Label();
            this.kierowcaSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.kierowcaSelectionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pojazd = new System.Windows.Forms.RadioButton();
            this.kierowca = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.radio_pracownik.SuspendLayout();
            this.radio_pojazd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(37, 600);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(147, 74);
            this.powrot.TabIndex = 45;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(50, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 38);
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
            this.exit.Location = new System.Drawing.Point(1036, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 55);
            this.exit.TabIndex = 50;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.Hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.Leave_exitbutton);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.Location = new System.Drawing.Point(928, 600);
            this.Aktualizuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(147, 74);
            this.Aktualizuj.TabIndex = 35;
            this.Aktualizuj.Text = "Aktualizuj";
            this.Aktualizuj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby zmienić status pracownika bądź kierowcy wypełnij formularz, a następnie klikn" +
    "ij aktualizuj.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1113, 124);
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
            this.help.Location = new System.Drawing.Point(955, 2);
            this.help.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(81, 55);
            this.help.TabIndex = 52;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.radio_pracownik);
            this.panel1.Controls.Add(this.radio_pojazd);
            this.panel1.Controls.Add(this.pojazdSelectionComboBox);
            this.panel1.Controls.Add(this.pojazdSelectionLabel);
            this.panel1.Controls.Add(this.kierowcaSelectionComboBox);
            this.panel1.Controls.Add(this.kierowcaSelectionLabel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.powrot);
            this.panel1.Controls.Add(this.Aktualizuj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 696);
            this.panel1.TabIndex = 49;
            // 
            // radio_pracownik
            // 
            this.radio_pracownik.Controls.Add(this.radioButton5);
            this.radio_pracownik.Controls.Add(this.radioButton3);
            this.radio_pracownik.Controls.Add(this.radioButton4);
            this.radio_pracownik.Location = new System.Drawing.Point(600, 166);
            this.radio_pracownik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radio_pracownik.Name = "radio_pracownik";
            this.radio_pracownik.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radio_pracownik.Size = new System.Drawing.Size(475, 148);
            this.radio_pracownik.TabIndex = 57;
            this.radio_pracownik.TabStop = false;
            this.radio_pracownik.Text = "Zmień status na:";
            this.radio_pracownik.Visible = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(325, 59);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(133, 29);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "chorobowe";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(178, 59);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(127, 29);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "niepracuje";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(57, 59);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 29);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "pracuje";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radio_pojazd
            // 
            this.radio_pojazd.Controls.Add(this.radioButton1);
            this.radio_pojazd.Controls.Add(this.radioButton2);
            this.radio_pojazd.Location = new System.Drawing.Point(600, 166);
            this.radio_pojazd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radio_pojazd.Name = "radio_pojazd";
            this.radio_pojazd.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radio_pojazd.Size = new System.Drawing.Size(475, 148);
            this.radio_pojazd.TabIndex = 56;
            this.radio_pojazd.TabStop = false;
            this.radio_pojazd.Text = "Zmień status";
            this.radio_pojazd.Visible = false;
            this.radio_pojazd.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(211, 59);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 29);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sprawny";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 59);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 29);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "niesprawny";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pojazdSelectionComboBox
            // 
            this.pojazdSelectionComboBox.FormattingEnabled = true;
            this.pojazdSelectionComboBox.Items.AddRange(new object[] {
            "Mercedes - SG 6743K, sprawny",
            "Solaris - SK 98551, sprawny",
            "Man - ST 12985, niesprawny"});
            this.pojazdSelectionComboBox.Location = new System.Drawing.Point(37, 369);
            this.pojazdSelectionComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pojazdSelectionComboBox.Name = "pojazdSelectionComboBox";
            this.pojazdSelectionComboBox.Size = new System.Drawing.Size(439, 32);
            this.pojazdSelectionComboBox.TabIndex = 55;
            this.pojazdSelectionComboBox.Visible = false;
            this.pojazdSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.pojazdSelectionComboBox_SelectedIndexChanged);
            // 
            // pojazdSelectionLabel
            // 
            this.pojazdSelectionLabel.AutoSize = true;
            this.pojazdSelectionLabel.Location = new System.Drawing.Point(31, 340);
            this.pojazdSelectionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pojazdSelectionLabel.Name = "pojazdSelectionLabel";
            this.pojazdSelectionLabel.Size = new System.Drawing.Size(153, 25);
            this.pojazdSelectionLabel.TabIndex = 54;
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
            this.kierowcaSelectionComboBox.Location = new System.Drawing.Point(37, 369);
            this.kierowcaSelectionComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kierowcaSelectionComboBox.Name = "kierowcaSelectionComboBox";
            this.kierowcaSelectionComboBox.Size = new System.Drawing.Size(439, 32);
            this.kierowcaSelectionComboBox.TabIndex = 53;
            this.kierowcaSelectionComboBox.Visible = false;
            this.kierowcaSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.kierowcaSelectionComboBox_SelectedIndexChanged);
            // 
            // kierowcaSelectionLabel
            // 
            this.kierowcaSelectionLabel.AutoSize = true;
            this.kierowcaSelectionLabel.Location = new System.Drawing.Point(31, 340);
            this.kierowcaSelectionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kierowcaSelectionLabel.Name = "kierowcaSelectionLabel";
            this.kierowcaSelectionLabel.Size = new System.Drawing.Size(172, 25);
            this.kierowcaSelectionLabel.TabIndex = 52;
            this.kierowcaSelectionLabel.Text = "Wybierz kierowcę:";
            this.kierowcaSelectionLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pojazd);
            this.groupBox1.Controls.Add(this.kierowca);
            this.groupBox1.Location = new System.Drawing.Point(29, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(449, 148);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmiana statusu dotyczy:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pojazd
            // 
            this.pojazd.AutoSize = true;
            this.pojazd.Location = new System.Drawing.Point(193, 59);
            this.pojazd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pojazd.Name = "pojazd";
            this.pojazd.Size = new System.Drawing.Size(106, 29);
            this.pojazd.TabIndex = 2;
            this.pojazd.TabStop = true;
            this.pojazd.Text = "pojazdu";
            this.pojazd.UseVisualStyleBackColor = true;
            this.pojazd.CheckedChanged += new System.EventHandler(this.pojazd_CheckedChanged);
            // 
            // kierowca
            // 
            this.kierowca.AutoSize = true;
            this.kierowca.Location = new System.Drawing.Point(57, 59);
            this.kierowca.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kierowca.Name = "kierowca";
            this.kierowca.Size = new System.Drawing.Size(113, 29);
            this.kierowca.TabIndex = 1;
            this.kierowca.TabStop = true;
            this.kierowca.Text = "kierowcy";
            this.kierowca.UseVisualStyleBackColor = true;
            this.kierowca.CheckedChanged += new System.EventHandler(this.kierowca_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // ZmianaStatusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1118, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ZmianaStatusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZmianaStatusu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.ZmianaStatusu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.radio_pracownik.ResumeLayout(false);
            this.radio_pracownik.PerformLayout();
            this.radio_pojazd.ResumeLayout(false);
            this.radio_pojazd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.RadioButton radioButton5;
    }
}