namespace ReportWizardPrototype
{
    partial class ReportTheme
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
            listBox1 = new ListBox();
            groupAuth = new GroupBox();
            _iconBox = new PictureBox();
            panel1.SuspendLayout();
            groupAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_iconBox).BeginInit();
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
            lblTitle.Size = new Size(188, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose Report Color Scheme";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Active", "Casual", "Cheerful", "Coral", "Crisp", "High Contrast", "Material", "Muted", "Organic", "SS Dark", "Utility", "Vibrant", "Warm" });
            listBox1.Location = new Point(18, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 394);
            listBox1.TabIndex = 55;
            // 
            // groupAuth
            // 
            groupAuth.BackColor = SystemColors.ControlLightLight;
            groupAuth.Controls.Add(_iconBox);
            groupAuth.Location = new Point(257, 48);
            groupAuth.Name = "groupAuth";
            groupAuth.Size = new Size(392, 394);
            groupAuth.TabIndex = 56;
            groupAuth.TabStop = false;
            groupAuth.Text = "Preview";
            // 
            // _iconBox
            // 
            _iconBox.BackColor = SystemColors.ControlLightLight;
            _iconBox.Dock = DockStyle.Fill;
            _iconBox.Location = new Point(3, 19);
            _iconBox.Margin = new Padding(4, 3, 4, 3);
            _iconBox.Name = "_iconBox";
            _iconBox.Size = new Size(386, 372);
            _iconBox.SizeMode = PictureBoxSizeMode.CenterImage;
            _iconBox.TabIndex = 1;
            _iconBox.TabStop = false;
            // 
            // ReportTheme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(groupAuth);
            Controls.Add(listBox1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportTheme";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Report";
            Load += TableFields_Load;
            panel1.ResumeLayout(false);
            groupAuth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_iconBox).EndInit();
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
        private ListBox listBox1;
        private GroupBox groupAuth;
        private PictureBox _iconBox;
    }
}