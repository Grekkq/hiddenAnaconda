﻿namespace hiddenAnaconda.Views
{
    partial class WypelnianieCzasuRealizacjiKursu
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
            if (disposing && (components != null))
            {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kurs = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.Przystanek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alert = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.alertpic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.driver = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.driver);
            this.panel1.Controls.Add(this.alertpic);
            this.panel1.Controls.Add(this.alert);
            this.panel1.Controls.Add(this.tabela);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.kurs);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 374);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Akceptowany format czasu - GG:MM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wybierz kierowcę:";
            // 
            // kurs
            // 
            this.kurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.kurs.DropDownHeight = 5;
            this.kurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.kurs.DropDownWidth = 5;
            this.kurs.FormattingEnabled = true;
            this.kurs.IntegralHeight = false;
            this.kurs.Items.AddRange(new object[] {
            "15.11.2019 - 194 - 4",
            "15.11.2019 - 47 - 1",
            "15.11.2019 - 47 - 2",
            "15.11.2019 - 648 - 2",
            "15.11.2019 - 710 - 1",
            "15.11.2019 - 710 - 2",
            "16.11.2019 - 710 - 1",
            "16.11.2019 - 710 - 2"});
            this.kurs.Location = new System.Drawing.Point(20, 96);
            this.kurs.Name = "kurs";
            this.kurs.Size = new System.Drawing.Size(127, 119);
            this.kurs.Sorted = true;
            this.kurs.TabIndex = 10;
            this.kurs.SelectedIndexChanged += new System.EventHandler(this.kurs_SelectedIndexChanged);
            this.kurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
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
            this.create.Text = "Przypisz";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.assign_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wybierz kurs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby przypisać do danego kursu czas jego realizacji wypełnij poniższy fromularz.\r\n" +
    "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = " \r\n      Przypisanie czasu realizacji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Formularz przypisania czasu realizacji do kursu";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.exit.Location = new System.Drawing.Point(560, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 28);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Przystanek,
            this.Czas});
            this.tabela.Location = new System.Drawing.Point(304, 96);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(245, 172);
            this.tabela.TabIndex = 16;
            this.tabela.Visible = false;
            // 
            // Przystanek
            // 
            this.Przystanek.HeaderText = "Przystanek";
            this.Przystanek.Name = "Przystanek";
            // 
            // Czas
            // 
            this.Czas.HeaderText = "Czas";
            this.Czas.Name = "Czas";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alert.Location = new System.Drawing.Point(317, 280);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(260, 26);
            this.alert.TabIndex = 17;
            this.alert.Text = "Lista przystanków będzie zczytywana z bazy danych. \r\nKolumna czas będzie wypełnia" +
    "na przez użytkownika.";
            this.alert.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // alertpic
            // 
            this.alertpic.Image = global::hiddenAnaconda.Properties.Resources.Alert_Download_PNG;
            this.alertpic.Location = new System.Drawing.Point(284, 280);
            this.alertpic.Name = "alertpic";
            this.alertpic.Size = new System.Drawing.Size(27, 26);
            this.alertpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertpic.TabIndex = 18;
            this.alertpic.TabStop = false;
            this.alertpic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.time;
            this.pictureBox1.Location = new System.Drawing.Point(518, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // driver
            // 
            this.driver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driver.FormattingEnabled = true;
            this.driver.Items.AddRange(new object[] {
            "Jan Kowalski",
            "Adam Meller",
            "Łukasz Nowak"});
            this.driver.Location = new System.Drawing.Point(20, 247);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(121, 21);
            this.driver.TabIndex = 19;
            // 
            // WypelnianieCzasuRealizacjiKursu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WypelnianieCzasuRealizacjiKursu";
            this.Text = "WypelnianieCzasuRealizacjiKursu";
            this.Activated += new System.EventHandler(this.turnoff_focus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox kurs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przystanek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.PictureBox alertpic;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox driver;
    }
}