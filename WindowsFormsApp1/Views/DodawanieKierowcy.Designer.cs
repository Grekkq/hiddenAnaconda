﻿namespace hiddenAnaconda.Views
{
    partial class DodawanieKierowcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieKierowcy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.powrot = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DriverBirthDate = new System.Windows.Forms.TextBox();
            this.DriverPesel = new System.Windows.Forms.TextBox();
            this.DriverLastName = new System.Windows.Forms.TextBox();
            this.DriverFirstName = new System.Windows.Forms.TextBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.powrot);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DriverBirthDate);
            this.panel1.Controls.Add(this.DriverPesel);
            this.panel1.Controls.Add(this.DriverLastName);
            this.panel1.Controls.Add(this.DriverFirstName);
            this.panel1.Controls.Add(this.Zapisz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.driver1;
            this.pictureBox2.Location = new System.Drawing.Point(537, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(20, 325);
            this.powrot.Margin = new System.Windows.Forms.Padding(2);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(80, 40);
            this.powrot.TabIndex = 45;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // Reset
            // 
            this.Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Reset.Location = new System.Drawing.Point(411, 325);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(80, 40);
            this.Reset.TabIndex = 44;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data urodzenia:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Pesel:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nazwisko:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Imię:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DriverBirthDate
            // 
            this.DriverBirthDate.Location = new System.Drawing.Point(20, 202);
            this.DriverBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.DriverBirthDate.MaxLength = 10;
            this.DriverBirthDate.Name = "DriverBirthDate";
            this.DriverBirthDate.Size = new System.Drawing.Size(201, 20);
            this.DriverBirthDate.TabIndex = 39;
            this.DriverBirthDate.TextChanged += new System.EventHandler(this.DriverBirthDate_TextChanged);
            this.DriverBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.DriverBirthDate_Validating);
            // 
            // DriverPesel
            // 
            this.DriverPesel.Location = new System.Drawing.Point(20, 255);
            this.DriverPesel.Margin = new System.Windows.Forms.Padding(2);
            this.DriverPesel.MaxLength = 11;
            this.DriverPesel.Name = "DriverPesel";
            this.DriverPesel.Size = new System.Drawing.Size(200, 20);
            this.DriverPesel.TabIndex = 38;
            this.DriverPesel.TextChanged += new System.EventHandler(this.DriverPesel_TextChanged);
            this.DriverPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DriverPesel_TextChanged);
            // 
            // DriverLastName
            // 
            this.DriverLastName.Location = new System.Drawing.Point(21, 151);
            this.DriverLastName.Margin = new System.Windows.Forms.Padding(2);
            this.DriverLastName.Name = "DriverLastName";
            this.DriverLastName.Size = new System.Drawing.Size(200, 20);
            this.DriverLastName.TabIndex = 37;
            this.DriverLastName.TextChanged += new System.EventHandler(this.DriverLastName_TextChanged);
            this.DriverLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DriverName_TextChanged);
            // 
            // DriverFirstName
            // 
            this.DriverFirstName.Location = new System.Drawing.Point(20, 96);
            this.DriverFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.DriverFirstName.Name = "DriverFirstName";
            this.DriverFirstName.Size = new System.Drawing.Size(200, 20);
            this.DriverFirstName.TabIndex = 36;
            this.DriverFirstName.TextChanged += new System.EventHandler(this.DriverFirstName_TextChanged);
            this.DriverFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DriverName_TextChanged);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(506, 325);
            this.Zapisz.Margin = new System.Windows.Forms.Padding(2);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(80, 40);
            this.Zapisz.TabIndex = 35;
            this.Zapisz.Text = "Utwórz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby dodać nowego kierowcę wypełnij poniższy formularz, a następnie kliknij utwórz" +
    ".";
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
            this.label1.Text = " \r\n      Dodawanie nowego kierowcy";
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
            this.exit.TabIndex = 5;
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
            this.label3.Location = new System.Drawing.Point(28, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formularz dodawania nowego kierowcy";
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
            this.help.TabIndex = 47;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.MouseEnter += new System.EventHandler(this.hover_helpbutton);
            this.help.MouseLeave += new System.EventHandler(this.leave_helpbutton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // DodawanieKierowcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodawanieKierowcy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie Kierowcy";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.DodawanieKierowcy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DriverBirthDate;
        private System.Windows.Forms.TextBox DriverPesel;
        private System.Windows.Forms.TextBox DriverLastName;
        private System.Windows.Forms.TextBox DriverFirstName;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}