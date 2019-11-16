namespace WindowsFormsApp1.Widoki_Bielecki
{

    partial class DodawanieNowejLinii
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.line_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = " \r\n      Tworzenie nowej lini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby utworzyć nową linię autobusową wypełnij poniższy formularz a następnie klikni" +
    "j utwórz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.line_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 374);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Location = new System.Drawing.Point(20, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 80);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czy tworzona linia będzie kursować w pętli?";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(92, 32);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 17);
            this.no.TabIndex = 7;
            this.no.TabStop = true;
            this.no.Text = "Nie";
            this.no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(31, 32);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(44, 17);
            this.yes.TabIndex = 6;
            this.yes.TabStop = true;
            this.yes.Text = "Tak";
            this.yes.UseVisualStyleBackColor = true;
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
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // line_name
            // 
            this.line_name.HideSelection = false;
            this.line_name.Location = new System.Drawing.Point(20, 96);
            this.line_name.MaxLength = 4;
            this.line_name.Name = "line_name";
            this.line_name.Size = new System.Drawing.Size(109, 20);
            this.line_name.TabIndex = 4;
            this.line_name.TextChanged += new System.EventHandler(this.nazwa_linii_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podaj nazwę tworzonej linii:";
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
            this.exit.TabIndex = 4;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Formularz tworzenia nowej linii";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // DodawanieNowejLinii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodawanieNowejLinii";
            this.Text = "Kreator dodawania nowej linii";
            this.Activated += new System.EventHandler(this.turnoffFocus);
            this.Load += new System.EventHandler(this.DodawanieNowejLinii_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox line_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}