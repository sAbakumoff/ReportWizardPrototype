namespace ReportWizardPrototype
{
    partial class TableGroupings
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
            ListViewItem listViewItem1 = new ListViewItem("Company");
            ListViewItem listViewItem2 = new ListViewItem("FullName");
            panel1 = new Panel();
            btnBack = new Button();
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            lblTitle = new Label();
            listView1 = new ListView();
            colField = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            lblTitle.Size = new Size(171, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configure Table Groupings";
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.Columns.AddRange(new ColumnHeader[] { colField });
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(18, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(246, 368);
            listView1.TabIndex = 50;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colField
            // 
            colField.Text = "";
            colField.Width = 100;
            // 
            // listView2
            // 
            listView2.AutoArrange = false;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView2.HeaderStyle = ColumnHeaderStyle.None;
            listView2.Location = new Point(372, 61);
            listView2.Name = "listView2";
            listView2.Size = new Size(277, 368);
            listView2.TabIndex = 51;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(280, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 52;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(280, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 53;
            button2.Text = "> +";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(280, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 54;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            // 
            // TableGroupings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableGroupings";
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
        private ListView listView1;
        private ColumnHeader colField;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}