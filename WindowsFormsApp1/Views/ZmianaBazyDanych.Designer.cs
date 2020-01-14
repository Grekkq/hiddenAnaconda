namespace hiddenAnaconda.Views {
    partial class ZmianaBazyDanych {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZmianaBazyDanych));
            this.help = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.checkBoxIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.textBoxIpAdress = new System.Windows.Forms.TextBox();
            this.textBoxDataBaseName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.help.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.help.FlatAppearance.BorderSize = 0;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.help.Location = new System.Drawing.Point(414, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 29);
            this.help.TabIndex = 1;
            this.help.TabStop = false;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
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
            this.exit.Location = new System.Drawing.Point(464, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 29);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.Hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.Leave_exitbutton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ustawienia połączenia z bazą danych";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox4.Location = new System.Drawing.Point(4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.help);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 33);
            this.panel2.TabIndex = 60;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxUserName);
            this.panel3.Controls.Add(this.checkBoxIntegratedSecurity);
            this.panel3.Controls.Add(this.textBoxPassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(14, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 101);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ustawienia autoryzacji:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUserName.Location = new System.Drawing.Point(139, 34);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(172, 22);
            this.textBoxUserName.TabIndex = 3;
            // 
            // checkBoxIntegratedSecurity
            // 
            this.checkBoxIntegratedSecurity.Checked = true;
            this.checkBoxIntegratedSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIntegratedSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIntegratedSecurity.Location = new System.Drawing.Point(317, 34);
            this.checkBoxIntegratedSecurity.Name = "checkBoxIntegratedSecurity";
            this.checkBoxIntegratedSecurity.Size = new System.Drawing.Size(154, 22);
            this.checkBoxIntegratedSecurity.TabIndex = 1;
            this.checkBoxIntegratedSecurity.Text = "Integrated Security";
            this.checkBoxIntegratedSecurity.UseVisualStyleBackColor = true;
            this.checkBoxIntegratedSecurity.CheckedChanged += new System.EventHandler(this.checkBoxIntegratedSecurity_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(139, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasło:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nazwa użytkownika:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.checkBoxLocal);
            this.panel4.Controls.Add(this.labelDataBaseName);
            this.panel4.Controls.Add(this.textBoxIpAdress);
            this.panel4.Controls.Add(this.textBoxDataBaseName);
            this.panel4.Location = new System.Drawing.Point(14, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 100);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ustawienia bazy danych:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adres IP Serwera:";
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.Checked = true;
            this.checkBoxLocal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLocal.Location = new System.Drawing.Point(321, 33);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(154, 22);
            this.checkBoxLocal.TabIndex = 1;
            this.checkBoxLocal.Text = "Logowanie lokalne";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBoxLocal_CheckedChanged);
            // 
            // labelDataBaseName
            // 
            this.labelDataBaseName.AutoSize = true;
            this.labelDataBaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDataBaseName.Location = new System.Drawing.Point(14, 72);
            this.labelDataBaseName.Name = "labelDataBaseName";
            this.labelDataBaseName.Size = new System.Drawing.Size(124, 13);
            this.labelDataBaseName.TabIndex = 7;
            this.labelDataBaseName.Text = "Nazwa bazy danych:";
            // 
            // textBoxIpAdress
            // 
            this.textBoxIpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIpAdress.Location = new System.Drawing.Point(143, 33);
            this.textBoxIpAdress.Name = "textBoxIpAdress";
            this.textBoxIpAdress.Size = new System.Drawing.Size(172, 22);
            this.textBoxIpAdress.TabIndex = 0;
            // 
            // textBoxDataBaseName
            // 
            this.textBoxDataBaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataBaseName.Location = new System.Drawing.Point(143, 65);
            this.textBoxDataBaseName.Name = "textBoxDataBaseName";
            this.textBoxDataBaseName.Size = new System.Drawing.Size(172, 22);
            this.textBoxDataBaseName.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(403, 235);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 30);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(14, 235);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(90, 30);
            this.Anuluj.TabIndex = 6;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Anuluj);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 277);
            this.panel1.TabIndex = 59;
            // 
            // ZmianaBazyDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(510, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZmianaBazyDanych";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZmianaBazyDanych";
            this.Activated += new System.EventHandler(this.TurnoffFocus);
            this.Load += new System.EventHandler(this.ZmianaBazyDanych_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.Label labelDataBaseName;
        private System.Windows.Forms.TextBox textBoxIpAdress;
        private System.Windows.Forms.TextBox textBoxDataBaseName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxIntegratedSecurity;
    }
}