namespace hiddenAnaconda.Views
{
    partial class DodajPrzystanekDoTrasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPrzystanekDoTrasy));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_miasto = new System.Windows.Forms.Label();
            this.label_przystanek = new System.Windows.Forms.Label();
            this.label_czas = new System.Windows.Forms.Label();
            this.textbox_time = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_kierunek = new System.Windows.Forms.ComboBox();
            this.comboBox_przystanek = new System.Windows.Forms.ComboBox();
            this.comboBox_miasto = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label_kierunek = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
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
            this.exit.Location = new System.Drawing.Point(311, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 30);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dodaj przystanek do trasy";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // label_miasto
            // 
            this.label_miasto.AutoSize = true;
            this.label_miasto.Location = new System.Drawing.Point(7, 15);
            this.label_miasto.Name = "label_miasto";
            this.label_miasto.Size = new System.Drawing.Size(78, 13);
            this.label_miasto.TabIndex = 0;
            this.label_miasto.Text = "Wybierz miasto";
            // 
            // label_przystanek
            // 
            this.label_przystanek.AutoSize = true;
            this.label_przystanek.Location = new System.Drawing.Point(7, 64);
            this.label_przystanek.Name = "label_przystanek";
            this.label_przystanek.Size = new System.Drawing.Size(102, 13);
            this.label_przystanek.TabIndex = 1;
            this.label_przystanek.Text = "Wybierz przystanek:";
            // 
            // label_czas
            // 
            this.label_czas.AutoSize = true;
            this.label_czas.Location = new System.Drawing.Point(7, 114);
            this.label_czas.Name = "label_czas";
            this.label_czas.Size = new System.Drawing.Size(102, 13);
            this.label_czas.TabIndex = 2;
            this.label_czas.Text = "Podaj czas odjazdu:";
            // 
            // textbox_time
            // 
            this.textbox_time.HideSelection = false;
            this.textbox_time.Location = new System.Drawing.Point(10, 131);
            this.textbox_time.MaxLength = 5;
            this.textbox_time.Name = "textbox_time";
            this.textbox_time.Size = new System.Drawing.Size(120, 20);
            this.textbox_time.TabIndex = 3;
            this.textbox_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrivalTime_TextChanged);
            this.textbox_time.Validating += new System.ComponentModel.CancelEventHandler(this.arrivalTime_Validating);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(496, 336);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 28);
            this.create.TabIndex = 8;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.comboBox_kierunek);
            this.panel1.Controls.Add(this.comboBox_przystanek);
            this.panel1.Controls.Add(this.comboBox_miasto);
            this.panel1.Controls.Add(this.label_miasto);
            this.panel1.Controls.Add(this.dodaj);
            this.panel1.Controls.Add(this.anuluj);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.textbox_time);
            this.panel1.Controls.Add(this.label_czas);
            this.panel1.Controls.Add(this.label_kierunek);
            this.panel1.Controls.Add(this.label_przystanek);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 226);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_kierunek
            // 
            this.comboBox_kierunek.FormattingEnabled = true;
            this.comboBox_kierunek.Location = new System.Drawing.Point(166, 80);
            this.comboBox_kierunek.Name = "comboBox_kierunek";
            this.comboBox_kierunek.Size = new System.Drawing.Size(150, 21);
            this.comboBox_kierunek.TabIndex = 2;
            this.comboBox_kierunek.SelectedIndexChanged += new System.EventHandler(this.comboBox_kierunek_SelectedIndexChanged_1);
            this.comboBox_kierunek.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_kierunek_Validating);
            // 
            // comboBox_przystanek
            // 
            this.comboBox_przystanek.FormattingEnabled = true;
            this.comboBox_przystanek.Location = new System.Drawing.Point(10, 80);
            this.comboBox_przystanek.Name = "comboBox_przystanek";
            this.comboBox_przystanek.Size = new System.Drawing.Size(120, 21);
            this.comboBox_przystanek.TabIndex = 1;
            this.comboBox_przystanek.SelectedIndexChanged += new System.EventHandler(this.comboBox_przystanek_SelectedIndexChanged);
            this.comboBox_przystanek.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_przystanek_Validating);
            // 
            // comboBox_miasto
            // 
            this.comboBox_miasto.FormattingEnabled = true;
            this.comboBox_miasto.Location = new System.Drawing.Point(10, 31);
            this.comboBox_miasto.Name = "comboBox_miasto";
            this.comboBox_miasto.Size = new System.Drawing.Size(120, 21);
            this.comboBox_miasto.TabIndex = 0;
            this.comboBox_miasto.SelectedIndexChanged += new System.EventHandler(this.comboBox_miasto_SelectedIndexChanged);
            this.comboBox_miasto.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_miasto_Validating);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(241, 188);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(90, 28);
            this.dodaj.TabIndex = 3;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(20, 188);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(90, 28);
            this.anuluj.TabIndex = 4;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 336);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 28);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label_kierunek
            // 
            this.label_kierunek.AutoSize = true;
            this.label_kierunek.Location = new System.Drawing.Point(163, 64);
            this.label_kierunek.Name = "label_kierunek";
            this.label_kierunek.Size = new System.Drawing.Size(92, 13);
            this.label_kierunek.TabIndex = 1;
            this.label_kierunek.Text = "Wybierz kierunek:";
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // DodajPrzystanekDoTrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(355, 260);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajPrzystanekDoTrasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DodajPrzystanekDoTrasy";
            this.Activated += new System.EventHandler(this.TurnoffFocus);
            this.Load += new System.EventHandler(this.DodajPrzystanekDoTrasy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox textbox_time;
        private System.Windows.Forms.Label label_czas;
        private System.Windows.Forms.Label label_przystanek;
        private System.Windows.Forms.Label label_miasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_kierunek;
        private System.Windows.Forms.ComboBox comboBox_przystanek;
        private System.Windows.Forms.ComboBox comboBox_miasto;
        private System.Windows.Forms.Label label_kierunek;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}