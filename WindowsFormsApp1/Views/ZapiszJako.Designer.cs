namespace hiddenAnaconda.Views {
    partial class ZapiszJako {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapiszJako));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_przegladaj = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(2, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Zapisz jako";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.button_anuluj);
            this.panel1.Controls.Add(this.button_zapisz);
            this.panel1.Controls.Add(this.button_przegladaj);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_path);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 106);
            this.panel1.TabIndex = 56;
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(13, 68);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(90, 28);
            this.button_anuluj.TabIndex = 3;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(292, 68);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(90, 28);
            this.button_zapisz.TabIndex = 3;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_przegladaj
            // 
            this.button_przegladaj.Location = new System.Drawing.Point(342, 33);
            this.button_przegladaj.Name = "button_przegladaj";
            this.button_przegladaj.Size = new System.Drawing.Size(40, 20);
            this.button_przegladaj.TabIndex = 2;
            this.button_przegladaj.Text = "...";
            this.button_przegladaj.UseVisualStyleBackColor = true;
            this.button_przegladaj.Click += new System.EventHandler(this.button_przegladaj_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(135, 7);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(201, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(135, 33);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(201, 20);
            this.textBox_path.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wybierz miejsce zapisu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazwę raportu:";
            // 
            // ZapiszJako
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(400, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZapiszJako";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZapiszJako";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.ZapiszJako_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Button button_przegladaj;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}