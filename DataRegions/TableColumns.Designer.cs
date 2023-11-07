namespace ReportWizardPrototype
{
    partial class TableColumns
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
            panel1 = new Panel();
            btnBack = new Button();
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            lblTitle = new Label();
            btnMoveUp = new Button();
            btnMoveDown = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            checkBox6 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnFinish);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 461);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 61);
            panel1.TabIndex = 33;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.System;
            btnBack.Location = new Point(331, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Location = new Point(574, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.System;
            btnNext.Location = new Point(412, 18);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next >";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnBack_Click;
            // 
            // btnFinish
            // 
            btnFinish.Enabled = false;
            btnFinish.FlatStyle = FlatStyle.System;
            btnFinish.Location = new Point(493, 18);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 23);
            btnFinish.TabIndex = 2;
            btnFinish.Text = "Finish > >";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnNext_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(18, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(161, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configure Table Columns";
            // 
            // btnMoveUp
            // 
            btnMoveUp.Location = new Point(242, 46);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(38, 23);
            btnMoveUp.TabIndex = 52;
            btnMoveUp.Text = "Up";
            btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Location = new Point(242, 75);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(38, 23);
            btnMoveDown.TabIndex = 53;
            btnMoveDown.Text = "Down\\";
            btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "FullName", "CompanyName", "Address", "Income", "Gender" });
            listBox1.Location = new Point(18, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 394);
            listBox1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 57;
            label2.Text = "Header Text:";
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(385, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 20);
            checkBox1.TabIndex = 59;
            checkBox1.Text = "Sum";
            // 
            // checkBox2
            // 
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(385, 236);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 20);
            checkBox2.TabIndex = 60;
            checkBox2.Text = "Count";
            // 
            // checkBox3
            // 
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.FlatStyle = FlatStyle.System;
            checkBox3.Location = new Point(465, 236);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 20);
            checkBox3.TabIndex = 61;
            checkBox3.Text = "Average";
            // 
            // checkBox4
            // 
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatStyle = FlatStyle.System;
            checkBox4.Location = new Point(385, 262);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(57, 20);
            checkBox4.TabIndex = 62;
            checkBox4.Text = "Min";
            // 
            // checkBox5
            // 
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.FlatStyle = FlatStyle.System;
            checkBox5.Location = new Point(465, 262);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(87, 20);
            checkBox5.TabIndex = 63;
            checkBox5.Text = "Max";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 212);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 64;
            label1.Text = "Summaries:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 45);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 24);
            textBox2.TabIndex = 65;
            textBox2.Text = "Full Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "General", "Left", "Center", "Right" });
            comboBox1.Location = new Point(385, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 89);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 66;
            label3.Text = "Alignment:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "General", "Currency", "Decimal", "Percent", "Short Date", "Long Date" });
            comboBox2.Location = new Point(385, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 23);
            comboBox2.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 131);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 68;
            label4.Text = "Format:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "None", "Ascending", "Descending" });
            comboBox3.Location = new Point(384, 169);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(265, 23);
            comboBox3.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 172);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 70;
            label5.Text = "Sorting:";
            // 
            // checkBox6
            // 
            checkBox6.Checked = true;
            checkBox6.CheckState = CheckState.Checked;
            checkBox6.FlatStyle = FlatStyle.System;
            checkBox6.Location = new Point(465, 210);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(103, 20);
            checkBox6.TabIndex = 72;
            checkBox6.Text = "Distinct Sum";
            // 
            // TableColumns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(checkBox6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(btnMoveDown);
            Controls.Add(btnMoveUp);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableColumns";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Report";
            Load += TableGroupings_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnNext;
        private Button btnFinish;
        private Label lblTitle;
        private Button btnBack;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private ListBox listBox1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private CheckBox checkBox6;
    }
}