﻿namespace hiddenAnaconda.Views
{
    partial class DodawanieTrasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieTrasy));
            this.helpLabel = new System.Windows.Forms.Label();
            this.lineSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.lineSelectionLabel = new System.Windows.Forms.Label();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helpLabel2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpLabel.Location = new System.Drawing.Point(-1, 0);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(608, 68);
            this.helpLabel.TabIndex = 3;
            this.helpLabel.Text = " \r\n      Tworzenie nowej trasy";
            // 
            // lineSelectionComboBox
            // 
            this.lineSelectionComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.lineSelectionComboBox.FormattingEnabled = true;
            this.lineSelectionComboBox.Items.AddRange(new object[] {
            "657",
            "296",
            "409"});
            this.lineSelectionComboBox.Location = new System.Drawing.Point(19, 96);
            this.lineSelectionComboBox.Name = "lineSelectionComboBox";
            this.lineSelectionComboBox.Size = new System.Drawing.Size(131, 21);
            this.lineSelectionComboBox.TabIndex = 0;
            this.lineSelectionComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.lineSelectionComboBox_Validating);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cancel.Location = new System.Drawing.Point(10, 325);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 40);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.create.Location = new System.Drawing.Point(506, 325);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(80, 40);
            this.create.TabIndex = 3;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // lineSelectionLabel
            // 
            this.lineSelectionLabel.AutoSize = true;
            this.lineSelectionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lineSelectionLabel.Location = new System.Drawing.Point(16, 80);
            this.lineSelectionLabel.Name = "lineSelectionLabel";
            this.lineSelectionLabel.Size = new System.Drawing.Size(73, 13);
            this.lineSelectionLabel.TabIndex = 18;
            this.lineSelectionLabel.Text = "Wybierz Linię:";
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bgPanel.Controls.Add(this.label2);
            this.bgPanel.Controls.Add(this.label6);
            this.bgPanel.Controls.Add(this.label1);
            this.bgPanel.Controls.Add(this.pictureBox2);
            this.bgPanel.Controls.Add(this.helpLabel2);
            this.bgPanel.Controls.Add(this.clearButton);
            this.bgPanel.Controls.Add(this.mainListBox);
            this.bgPanel.Controls.Add(this.deleteButton);
            this.bgPanel.Controls.Add(this.helpLabel);
            this.bgPanel.Controls.Add(this.addButton);
            this.bgPanel.Controls.Add(this.lineSelectionLabel);
            this.bgPanel.Controls.Add(this.create);
            this.bgPanel.Controls.Add(this.cancel);
            this.bgPanel.Controls.Add(this.lineSelectionComboBox);
            this.bgPanel.Location = new System.Drawing.Point(2, 31);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(606, 377);
            this.bgPanel.TabIndex = 0;
            this.bgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bgPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "                              Lokalizacja                          ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(418, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "      Godzina     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(65, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "  Nr. ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::hiddenAnaconda.Properties.Resources.route;
            this.pictureBox2.Location = new System.Drawing.Point(497, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // helpLabel2
            // 
            this.helpLabel2.AutoSize = true;
            this.helpLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.helpLabel2.Location = new System.Drawing.Point(29, 33);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(440, 13);
            this.helpLabel2.TabIndex = 25;
            this.helpLabel2.Text = "Aby utworzyć nową trasę autobusową wypełnij poniższy formularz a następnie klikni" +
    "j utwórz.";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 40);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mainListBox
            // 
            this.mainListBox.AllowDrop = true;
            this.mainListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 18;
            this.mainListBox.Items.AddRange(new object[] {
            "1)   Gliwice, Plac Piastów            07:15",
            "2)   Zabrze, Plac Kroczkaa            08:00",
            "3)   Zabrze, Rokietnica               08:30"});
            this.mainListBox.Location = new System.Drawing.Point(65, 155);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(468, 148);
            this.mainListBox.TabIndex = 1;
            this.mainListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainListBox_DragDrop);
            this.mainListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.mainListBox_DragOver);
            this.mainListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainListBox_MouseDoubleClick);
            this.mainListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainListBox_MouseDown);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(200, 325);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 40);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(411, 325);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.titleLabel.Location = new System.Drawing.Point(28, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(244, 21);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Formularz tworzenia nowej trasy";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
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
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::hiddenAnaconda.Properties.Resources.icon;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // DodawanieTrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(610, 410);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodawanieTrasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularz tworzenia trasy";
            this.Load += new System.EventHandler(this.DodawanieTrasy_Load);
            this.Enter += new System.EventHandler(this.turnoff_focus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.ComboBox lineSelectionComboBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label lineSelectionLabel;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label helpLabel2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}