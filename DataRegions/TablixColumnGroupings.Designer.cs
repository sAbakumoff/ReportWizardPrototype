namespace ReportWizardPrototype
{
    partial class TablixColumnGroupings
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
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
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
            lblTitle.Size = new Size(225, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configure Tablix Column Groupings";
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
            // button2
            // 
            button2.Location = new Point(132, 416);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 56;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 416);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 55;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Country" });
            listBox1.Location = new Point(18, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 364);
            listBox1.TabIndex = 54;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Country", "City", "FullName", "CompanyName" });
            comboBox1.Location = new Point(372, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 23);
            comboBox1.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 49);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 57;
            label2.Text = "Group By:";
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(372, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(277, 20);
            checkBox1.TabIndex = 59;
            checkBox1.Text = "Include Total Rows";
            // 
            // checkBox2
            // 
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(372, 153);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(277, 20);
            checkBox2.TabIndex = 60;
            checkBox2.Text = "Display Total Rows First";
            // 
            // checkBox4
            // 
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatStyle = FlatStyle.System;
            checkBox4.Location = new Point(372, 179);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(277, 20);
            checkBox4.TabIndex = 62;
            checkBox4.Text = "Start each group on a new page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 129);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 64;
            label1.Text = "Layout:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "Ascending", "Descending" });
            comboBox2.Location = new Point(372, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(277, 23);
            comboBox2.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 90);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 65;
            label3.Text = "Sorting:";
            // 
            // TablixColumnGroupings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(btnMoveDown);
            Controls.Add(btnMoveUp);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TablixColumnGroupings";
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
        private Button button1;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private Button button2;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private Label label1;
        private ComboBox comboBox2;
        private Label label3;
    }
}