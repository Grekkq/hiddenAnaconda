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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPrzystanekDoTrasy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dodaj = new System.Windows.Forms.Button();
            this.anuluj = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.cityName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.dodaj);
            this.panel1.Controls.Add(this.anuluj);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.arrivalTime);
            this.panel1.Controls.Add(this.cityName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.stopName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 226);
            this.panel1.TabIndex = 6;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(251, 188);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(90, 28);
            this.dodaj.TabIndex = 10;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(10, 188);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(90, 28);
            this.anuluj.TabIndex = 10;
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
            // create
            // 
            this.create.Location = new System.Drawing.Point(496, 336);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 28);
            this.create.TabIndex = 8;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HideSelection = false;
            this.arrivalTime.Location = new System.Drawing.Point(10, 130);
            this.arrivalTime.MaxLength = 5;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(110, 20);
            this.arrivalTime.TabIndex = 4;
            this.arrivalTime.TextChanged += new System.EventHandler(this.arrivalTime_TextChanged);
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrivalTime_TextChanged);
            // 
            // cityName
            // 
            this.cityName.HideSelection = false;
            this.cityName.Location = new System.Drawing.Point(10, 80);
            this.cityName.MaxLength = 15;
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(110, 20);
            this.cityName.TabIndex = 4;
            this.cityName.TextChanged += new System.EventHandler(this.cityName_TextChanged);
            this.cityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Podaj czas odjazdu:";
            // 
            // stopName
            // 
            this.stopName.HideSelection = false;
            this.stopName.Location = new System.Drawing.Point(10, 31);
            this.stopName.MaxLength = 15;
            this.stopName.Name = "stopName";
            this.stopName.Size = new System.Drawing.Size(110, 20);
            this.stopName.TabIndex = 4;
            this.stopName.TextChanged += new System.EventHandler(this.stopName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Podaj miasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaj nazwę przystanku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(2, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dodaj przystanek do trasy";
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
            this.exit.Location = new System.Drawing.Point(311, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 30);
            this.exit.TabIndex = 9;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
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
            this.Text = "DodajPrzystanekDoTrasy";
            this.Activated += new System.EventHandler(this.TurnoffFocus);
            this.Load += new System.EventHandler(this.DodajPrzystanekDoTrasy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox stopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button anuluj;
        private System.Windows.Forms.Button exit;
    }
}