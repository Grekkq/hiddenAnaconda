namespace WindowsFormsApp1.Views
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
            this.helpLabel2 = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.lineSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.lineSelectionLabel = new System.Windows.Forms.Label();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpLabel2
            // 
            this.helpLabel2.AutoSize = true;
            this.helpLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.helpLabel2.Location = new System.Drawing.Point(29, 64);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(440, 13);
            this.helpLabel2.TabIndex = 4;
            this.helpLabel2.Text = "Aby utworzyć nową trasę autobusową wypełnij poniższy formularz a następnie klikni" +
    "j utwórz.";
            // 
            // helpLabel
            // 
            this.helpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpLabel.Location = new System.Drawing.Point(1, 33);
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
            this.lineSelectionComboBox.Location = new System.Drawing.Point(106, 16);
            this.lineSelectionComboBox.Name = "lineSelectionComboBox";
            this.lineSelectionComboBox.Size = new System.Drawing.Size(131, 21);
            this.lineSelectionComboBox.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.36842F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(68, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 27);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(51, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lokalizacja";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(383, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Godzina";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nr.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cancel.Location = new System.Drawing.Point(21, 277);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 28);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.create.Location = new System.Drawing.Point(498, 277);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(90, 28);
            this.create.TabIndex = 17;
            this.create.Text = "Utwórz";
            this.create.UseVisualStyleBackColor = false;
            // 
            // lineSelectionLabel
            // 
            this.lineSelectionLabel.AutoSize = true;
            this.lineSelectionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lineSelectionLabel.Location = new System.Drawing.Point(27, 19);
            this.lineSelectionLabel.Name = "lineSelectionLabel";
            this.lineSelectionLabel.Size = new System.Drawing.Size(73, 13);
            this.lineSelectionLabel.TabIndex = 18;
            this.lineSelectionLabel.Text = "Wybierz Linię:";
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bgPanel.Controls.Add(this.clearButton);
            this.bgPanel.Controls.Add(this.mainListBox);
            this.bgPanel.Controls.Add(this.deleteButton);
            this.bgPanel.Controls.Add(this.addButton);
            this.bgPanel.Controls.Add(this.lineSelectionLabel);
            this.bgPanel.Controls.Add(this.create);
            this.bgPanel.Controls.Add(this.cancel);
            this.bgPanel.Controls.Add(this.tableLayoutPanel2);
            this.bgPanel.Controls.Add(this.lineSelectionComboBox);
            this.bgPanel.Location = new System.Drawing.Point(2, 100);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(606, 323);
            this.bgPanel.TabIndex = 19;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(140, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(82, 28);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mainListBox
            // 
            this.mainListBox.AllowDrop = true;
            this.mainListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 20;
            this.mainListBox.Items.AddRange(new object[] {
            "1)              Gliwice, Plac Piastów                          7:15",
            "2)              Zabrze, Plac Kroczka                          8:00",
            "3)              Zabrze, Rokietnica                              8:30"});
            this.mainListBox.Location = new System.Drawing.Point(68, 89);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(460, 164);
            this.mainListBox.TabIndex = 23;
            this.mainListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainListBox_DragDrop);
            this.mainListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.mainListBox_DragOver);
            this.mainListBox.DoubleClick += new System.EventHandler(this.mainListBox_DoubleClick);
            this.mainListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainListBox_MouseDown);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(256, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 28);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(363, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 28);
            this.addButton.TabIndex = 20;
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
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(561, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 28);
            this.exit.TabIndex = 20;
            this.exit.Text = "x";
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
            this.titleLabel.Location = new System.Drawing.Point(3, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(244, 21);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Formularz tworzenia nowej trasy";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            // 
            // DodawanieTrasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(609, 431);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DodawanieTrasy";
            this.Text = "Formularz tworzenia trasy";
            this.Enter += new System.EventHandler(this.turnoff_focus);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.move_window);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel2;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.ComboBox lineSelectionComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lineSelectionLabel;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.Button clearButton;
    }
}