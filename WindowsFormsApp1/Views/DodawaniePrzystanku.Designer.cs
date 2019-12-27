namespace hiddenAnaconda.Views
{
    partial class DodawaniePrzystanku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawaniePrzystanku));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p_nazwa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.p_miasto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Do = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBox_kierunekDo = new System.Windows.Forms.TextBox();
            this.textbox_kierunekZ = new System.Windows.Forms.TextBox();
            this.label_kierunek = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aby utworzyć nowy przystanek autobusowy wypełnij poniższy formularz a następnie k" +
    "liknij utwórz.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Text = " \r\n      Tworzenie nowego przystanku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // p_nazwa
            // 
            this.p_nazwa.Location = new System.Drawing.Point(18, 160);
            this.p_nazwa.MaxLength = 15;
            this.p_nazwa.Name = "p_nazwa";
            this.p_nazwa.Size = new System.Drawing.Size(150, 20);
            this.p_nazwa.TabIndex = 1;
            this.p_nazwa.TextChanged += new System.EventHandler(this.p_nazwa_TextChanged);
            this.p_nazwa.Validating += new System.ComponentModel.CancelEventHandler(this.p_nazwa_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.no);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Location = new System.Drawing.Point(352, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Czy utworzony przystanek jest pojedynczy?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(119, 33);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 17);
            this.no.TabIndex = 1;
            this.no.TabStop = true;
            this.no.Text = "Nie";
            this.no.UseVisualStyleBackColor = true;
            this.no.CheckedChanged += new System.EventHandler(this.no_CheckedChanged);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(69, 33);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(44, 17);
            this.yes.TabIndex = 0;
            this.yes.TabStop = true;
            this.yes.Text = "Tak";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Podaj nazwę przystanku:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // p_miasto
            // 
            this.p_miasto.Location = new System.Drawing.Point(18, 110);
            this.p_miasto.Name = "p_miasto";
            this.p_miasto.Size = new System.Drawing.Size(150, 20);
            this.p_miasto.TabIndex = 0;
            this.p_miasto.TextChanged += new System.EventHandler(this.p_miasto_TextChanged);
            this.p_miasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_miasto_TextChanged);
            this.p_miasto.Validating += new System.ComponentModel.CancelEventHandler(this.p_miasto_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Podaj miasto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.create.Location = new System.Drawing.Point(507, 335);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 30);
            this.create.TabIndex = 4;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cancel.Location = new System.Drawing.Point(20, 335);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 30);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.label_Do);
            this.panel1.Controls.Add(this.label_Z);
            this.panel1.Controls.Add(this.textBox_kierunekDo);
            this.panel1.Controls.Add(this.textbox_kierunekZ);
            this.panel1.Controls.Add(this.label_kierunek);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.p_nazwa);
            this.panel1.Controls.Add(this.p_miasto);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Do
            // 
            this.label_Do.Location = new System.Drawing.Point(18, 233);
            this.label_Do.Name = "label_Do";
            this.label_Do.Size = new System.Drawing.Size(101, 20);
            this.label_Do.TabIndex = 22;
            this.label_Do.Text = "Miasto docelowe:";
            this.label_Do.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Do.Click += new System.EventHandler(this.label_Do_Click);
            // 
            // label_Z
            // 
            this.label_Z.Location = new System.Drawing.Point(19, 207);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(100, 20);
            this.label_Z.TabIndex = 22;
            this.label_Z.Text = "Miasto wyjściowe:";
            this.label_Z.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Z.Click += new System.EventHandler(this.label_Z_Click);
            // 
            // textBox_kierunekDo
            // 
            this.textBox_kierunekDo.Location = new System.Drawing.Point(125, 235);
            this.textBox_kierunekDo.Name = "textBox_kierunekDo";
            this.textBox_kierunekDo.Size = new System.Drawing.Size(150, 20);
            this.textBox_kierunekDo.TabIndex = 4;
            this.textBox_kierunekDo.TextChanged += new System.EventHandler(this.textBox_kierunekDo_TextChanged);
            this.textBox_kierunekDo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_miasto_TextChanged);
            this.textBox_kierunekDo.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_kierunekDo_Validating);
            // 
            // textbox_kierunekZ
            // 
            this.textbox_kierunekZ.Location = new System.Drawing.Point(125, 209);
            this.textbox_kierunekZ.Name = "textbox_kierunekZ";
            this.textbox_kierunekZ.Size = new System.Drawing.Size(150, 20);
            this.textbox_kierunekZ.TabIndex = 3;
            this.textbox_kierunekZ.TextChanged += new System.EventHandler(this.textbox_kierunekZ_TextChanged);
            this.textbox_kierunekZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_miasto_TextChanged);
            this.textbox_kierunekZ.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_kierunekZ_Validating);
            // 
            // label_kierunek
            // 
            this.label_kierunek.AutoSize = true;
            this.label_kierunek.Location = new System.Drawing.Point(16, 190);
            this.label_kierunek.Name = "label_kierunek";
            this.label_kierunek.Size = new System.Drawing.Size(81, 13);
            this.label_kierunek.TabIndex = 21;
            this.label_kierunek.Text = "Podaj kierunek:";
            this.label_kierunek.Click += new System.EventHandler(this.label_kierunek_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.bus_stop;
            this.pictureBox2.Location = new System.Drawing.Point(537, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.leave_exitbutton);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(28, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Formularz tworzenia nowego przystanku";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.help.TabIndex = 1;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // DodawaniePrzystanku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodawaniePrzystanku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz dodawania przystanku";
            this.Load += new System.EventHandler(this.DodawaniePrzystanku_Load);
            this.Shown += new System.EventHandler(this.turnoff_focus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p_nazwa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_miasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textbox_kierunekZ;
        private System.Windows.Forms.Label label_kierunek;
        private System.Windows.Forms.Label label_Do;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.TextBox textBox_kierunekDo;
    }
}