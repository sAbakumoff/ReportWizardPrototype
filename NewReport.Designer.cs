namespace ReportWizardPrototype
{
    partial class NewReport
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
            btnHelp = new Button();
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnHelp);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnFinish);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 461);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 61);
            panel1.TabIndex = 34;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(12, 18);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 33;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += OnHelp;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(574, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnCancel;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(412, 18);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 35;
            btnNext.Text = "Next >";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += OnNext;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(493, 18);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 23);
            btnFinish.TabIndex = 37;
            btnFinish.Text = "Finish >>";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += OnFinish;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 9);
            label6.Name = "label6";
            label6.Size = new Size(135, 19);
            label6.TabIndex = 50;
            label6.Text = "Choose Report Type:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Location = new Point(18, 46);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.Size = new Size(631, 366);
            tableLayoutPanel1.TabIndex = 51;
            // 
            // NewReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewReport";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Report";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnNext;
        private Button btnFinish;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHelp;
    }
}