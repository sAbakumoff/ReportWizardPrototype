namespace ReportWizardPrototype
{
    partial class WelcomeScreen
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
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnFinish);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 461);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 61);
            panel1.TabIndex = 33;
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
            lblTitle.Size = new Size(284, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome to the ActiveReports Report Wizard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 55);
            label1.Name = "label1";
            label1.Size = new Size(453, 15);
            label1.TabIndex = 34;
            label1.Text = "The ActiveReports Report Wizard helps you create a report. With this wizard, you can:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 80);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 35;
            label2.Text = "• Choose the type of report you want to create";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 105);
            label3.Name = "label3";
            label3.Size = new Size(265, 15);
            label3.TabIndex = 36;
            label3.Text = "• Select a data source from which to retrieve data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 130);
            label4.Name = "label4";
            label4.Size = new Size(264, 15);
            label4.TabIndex = 37;
            label4.Text = "• Design queries to execute against a data source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 165);
            label5.Name = "label5";
            label5.Size = new Size(190, 15);
            label5.TabIndex = 38;
            label5.Text = "Click the Next button  to continue.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 190);
            label6.Name = "label6";
            label6.Size = new Size(318, 15);
            label6.TabIndex = 39;
            label6.Text = "Click the Finish button  to create a project without a report.";
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeScreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New ActiveReports Windows Forms Application";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}