namespace ReportWizardPrototype
{
    partial class TableFields
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
            ListViewItem listViewItem1 = new ListViewItem("(select all)");
            ListViewItem listViewItem2 = new ListViewItem("Country");
            ListViewItem listViewItem3 = new ListViewItem("City");
            ListViewItem listViewItem4 = new ListViewItem("Company");
            ListViewItem listViewItem5 = new ListViewItem("FullName");
            panel1 = new Panel();
            btnBack = new Button();
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            lblTitle = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            colField = new ColumnHeader();
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
            lblTitle.Size = new Size(196, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose Table Query and Fields";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Query1", "Query2", "Query3" });
            comboBox1.Location = new Point(66, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(583, 23);
            comboBox1.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 48);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 47;
            label2.Text = "Query:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 83);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 49;
            label1.Text = "Fields:";
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { colField });
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            listView1.Location = new Point(66, 83);
            listView1.Name = "listView1";
            listView1.Size = new Size(583, 336);
            listView1.TabIndex = 50;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colField
            // 
            colField.Text = "";
            colField.Width = 579;
            // 
            // TableFields
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableFields";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Report";
            Load += TableFields_Load;
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
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private ListView listView1;
        private ColumnHeader colField;
    }
}