namespace hiddenAnaconda.Views
{
    partial class DodawanieKursu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieKursu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_rodzajKursu = new System.Windows.Forms.ComboBox();
            this.comboBox_trasa = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox_linia = new System.Windows.Forms.ComboBox();
            this.label_rodzajKursu = new System.Windows.Forms.Label();
            this.label_trasa = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.comboBox_rodzajKursu);
            this.panel1.Controls.Add(this.comboBox_trasa);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBox_linia);
            this.panel1.Controls.Add(this.label_rodzajKursu);
            this.panel1.Controls.Add(this.label_trasa);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.create);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 377);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_rodzajKursu
            // 
            this.comboBox_rodzajKursu.FormattingEnabled = true;
            this.comboBox_rodzajKursu.Location = new System.Drawing.Point(18, 210);
            this.comboBox_rodzajKursu.Name = "comboBox_rodzajKursu";
            this.comboBox_rodzajKursu.Size = new System.Drawing.Size(150, 21);
            this.comboBox_rodzajKursu.TabIndex = 2;
            this.comboBox_rodzajKursu.SelectedIndexChanged += new System.EventHandler(this.comboBox_rodzajKursu_SelectedIndexChanged);
            this.comboBox_rodzajKursu.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_rodzajKursu_Validating);
            // 
            // comboBox_trasa
            // 
            this.comboBox_trasa.FormattingEnabled = true;
            this.comboBox_trasa.Location = new System.Drawing.Point(18, 160);
            this.comboBox_trasa.Name = "comboBox_trasa";
            this.comboBox_trasa.Size = new System.Drawing.Size(150, 21);
            this.comboBox_trasa.TabIndex = 1;
            this.comboBox_trasa.SelectedIndexChanged += new System.EventHandler(this.ComboBox_trasa_SelectedIndexChanged);
            this.comboBox_trasa.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_trasa_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.course;
            this.pictureBox2.Location = new System.Drawing.Point(537, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox_linia
            // 
            this.comboBox_linia.FormattingEnabled = true;
            this.comboBox_linia.Location = new System.Drawing.Point(18, 110);
            this.comboBox_linia.Name = "comboBox_linia";
            this.comboBox_linia.Size = new System.Drawing.Size(150, 21);
            this.comboBox_linia.TabIndex = 0;
            this.comboBox_linia.SelectedIndexChanged += new System.EventHandler(this.ComboBox_linia_SelectedIndexChanged);
            this.comboBox_linia.Validating += new System.ComponentModel.CancelEventHandler(this.Line_choose_Validating);
            // 
            // label_rodzajKursu
            // 
            this.label_rodzajKursu.AutoSize = true;
            this.label_rodzajKursu.Location = new System.Drawing.Point(16, 190);
            this.label_rodzajKursu.Name = "label_rodzajKursu";
            this.label_rodzajKursu.Size = new System.Drawing.Size(108, 13);
            this.label_rodzajKursu.TabIndex = 13;
            this.label_rodzajKursu.Text = "Wybierz rodzaj kursu:";
            // 
            // label_trasa
            // 
            this.label_trasa.AutoSize = true;
            this.label_trasa.Location = new System.Drawing.Point(16, 140);
            this.label_trasa.Name = "label_trasa";
            this.label_trasa.Size = new System.Drawing.Size(74, 13);
            this.label_trasa.TabIndex = 13;
            this.label_trasa.Text = "Wybierz trasę:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 325);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 40);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Close_on_click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(506, 325);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 40);
            this.create.TabIndex = 3;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aby utworzyć nowy kurs wypełnij poniższy formularz a następnie kliknij utwórz.";
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
            this.label1.Text = " \r\n      Tworzenie nowego kursu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_window);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wybierz linię:";
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
            this.exit.Click += new System.EventHandler(this.Close_on_click);
            this.exit.MouseEnter += new System.EventHandler(this.Hover_exitbutton);
            this.exit.MouseLeave += new System.EventHandler(this.Leave_exitbutton);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(26, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Formularz tworzenia nowego kursu";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_window);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // DodawanieKursu
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodawanieKursu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodawaniekKursu";
            this.Activated += new System.EventHandler(this.TurnoffFocus);
            this.Load += new System.EventHandler(this.DodawanieKursu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_window);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_trasa;
        private System.Windows.Forms.ComboBox comboBox_linia;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ComboBox comboBox_trasa;
        private System.Windows.Forms.ComboBox comboBox_rodzajKursu;
        private System.Windows.Forms.Label label_rodzajKursu;
    }
}