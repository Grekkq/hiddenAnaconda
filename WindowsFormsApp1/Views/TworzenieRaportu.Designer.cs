namespace hiddenAnaconda.Views {
    partial class TworzenieRaportu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TworzenieRaportu));
            this.label2 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label_przystanek = new System.Windows.Forms.Label();
            this.label_miasto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_kierunek = new System.Windows.Forms.ComboBox();
            this.comboBox_przystanek = new System.Windows.Forms.ComboBox();
            this.comboBox_miasto = new System.Windows.Forms.ComboBox();
            this.label_kierunek = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aby utworzyć raport wypełnij poniższy formularz.";
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
            this.help.TabIndex = 52;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(28, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Formularz tworzenia nowego raportu";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.exit.TabIndex = 53;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.create.Location = new System.Drawing.Point(507, 335);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 30);
            this.create.TabIndex = 3;
            this.create.Text = "Zapisz jako";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cancel.Location = new System.Drawing.Point(20, 335);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label_przystanek
            // 
            this.label_przystanek.AutoSize = true;
            this.label_przystanek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_przystanek.Location = new System.Drawing.Point(16, 140);
            this.label_przystanek.Name = "label_przystanek";
            this.label_przystanek.Size = new System.Drawing.Size(102, 13);
            this.label_przystanek.TabIndex = 12;
            this.label_przystanek.Text = "Wybierz przystanek:";
            // 
            // label_miasto
            // 
            this.label_miasto.AutoSize = true;
            this.label_miasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_miasto.Location = new System.Drawing.Point(16, 90);
            this.label_miasto.Name = "label_miasto";
            this.label_miasto.Size = new System.Drawing.Size(81, 13);
            this.label_miasto.TabIndex = 15;
            this.label_miasto.Text = "Wybierz miasto:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = " \r\n      Tworzenie raportu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBox_kierunek);
            this.panel1.Controls.Add(this.comboBox_przystanek);
            this.panel1.Controls.Add(this.comboBox_miasto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_kierunek);
            this.panel1.Controls.Add(this.label_przystanek);
            this.panel1.Controls.Add(this.label_miasto);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 51;
            // 
            // comboBox_kierunek
            // 
            this.comboBox_kierunek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kierunek.FormattingEnabled = true;
            this.comboBox_kierunek.Location = new System.Drawing.Point(18, 210);
            this.comboBox_kierunek.Name = "comboBox_kierunek";
            this.comboBox_kierunek.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kierunek.TabIndex = 2;
            this.comboBox_kierunek.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_kierunek_Validating);
            // 
            // comboBox_przystanek
            // 
            this.comboBox_przystanek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_przystanek.FormattingEnabled = true;
            this.comboBox_przystanek.Location = new System.Drawing.Point(18, 160);
            this.comboBox_przystanek.Name = "comboBox_przystanek";
            this.comboBox_przystanek.Size = new System.Drawing.Size(121, 21);
            this.comboBox_przystanek.TabIndex = 1;
            this.comboBox_przystanek.SelectedIndexChanged += new System.EventHandler(this.comboBox_przystanek_SelectedIndexChanged);
            this.comboBox_przystanek.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_przystanek_Validating);
            // 
            // comboBox_miasto
            // 
            this.comboBox_miasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_miasto.FormattingEnabled = true;
            this.comboBox_miasto.Location = new System.Drawing.Point(18, 110);
            this.comboBox_miasto.Name = "comboBox_miasto";
            this.comboBox_miasto.Size = new System.Drawing.Size(121, 21);
            this.comboBox_miasto.TabIndex = 0;
            this.comboBox_miasto.SelectedIndexChanged += new System.EventHandler(this.comboBox_miasto_SelectedIndexChanged);
            this.comboBox_miasto.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_miasto_Validating);
            // 
            // label_kierunek
            // 
            this.label_kierunek.AutoSize = true;
            this.label_kierunek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_kierunek.Location = new System.Drawing.Point(16, 190);
            this.label_kierunek.Name = "label_kierunek";
            this.label_kierunek.Size = new System.Drawing.Size(92, 13);
            this.label_kierunek.TabIndex = 12;
            this.label_kierunek.Text = "Wybierz kierunek:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(546, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // TworzenieRaportu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TworzenieRaportu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TworzenieRaportu";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.TworzenieRaportu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_przystanek;
        private System.Windows.Forms.Label label_miasto;
        private System.Windows.Forms.ComboBox comboBox_miasto;
        private System.Windows.Forms.ComboBox comboBox_przystanek;
        private System.Windows.Forms.ComboBox comboBox_kierunek;
        private System.Windows.Forms.Label label_kierunek;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}