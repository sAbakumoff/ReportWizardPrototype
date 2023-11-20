namespace ReportWizardPrototype
{
    partial class PageSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageSettings));
            panel1 = new Panel();
            btnBack = new Button();
            btnCancel = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            lblTitle = new Label();
            groupAuth = new GroupBox();
            _iconBox = new PictureBox();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioAppConfig = new RadioButton();
            comboBox1 = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            panel1.SuspendLayout();
            groupAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_iconBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnBack.Text = "< Back ";
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
            lblTitle.Size = new Size(156, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configure Page Settings";
            // 
            // groupAuth
            // 
            groupAuth.BackColor = SystemColors.ControlLightLight;
            groupAuth.Controls.Add(_iconBox);
            groupAuth.Location = new Point(357, 52);
            groupAuth.Name = "groupAuth";
            groupAuth.Size = new Size(292, 403);
            groupAuth.TabIndex = 36;
            groupAuth.TabStop = false;
            groupAuth.Text = "Preview";
            // 
            // _iconBox
            // 
            _iconBox.BackColor = SystemColors.ControlLight;
            _iconBox.Dock = DockStyle.Fill;
            _iconBox.Image = (Image)resources.GetObject("_iconBox.Image");
            _iconBox.Location = new Point(3, 19);
            _iconBox.Margin = new Padding(4, 3, 4, 3);
            _iconBox.Name = "_iconBox";
            _iconBox.Size = new Size(286, 381);
            _iconBox.SizeMode = PictureBoxSizeMode.CenterImage;
            _iconBox.TabIndex = 1;
            _iconBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioAppConfig);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(18, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 211);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paper";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Normal", "Narrow", "Moderate", "Wide" });
            comboBox2.Location = new Point(102, 181);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 23);
            comboBox2.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 184);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 77;
            label5.Text = "Margins:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(102, 143);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 24);
            textBox1.TabIndex = 76;
            textBox1.Text = "11cm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 146);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 75;
            label4.Text = "Height:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(102, 105);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 24);
            textBox2.TabIndex = 74;
            textBox2.Text = "29cm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 73;
            label2.Text = "Width:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 72;
            label1.Text = "Orientation:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(205, 66);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 71;
            radioButton1.TabStop = true;
            radioButton1.Text = "Landscape";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioAppConfig
            // 
            radioAppConfig.AutoSize = true;
            radioAppConfig.Location = new Point(102, 66);
            radioAppConfig.Name = "radioAppConfig";
            radioAppConfig.Size = new Size(64, 19);
            radioAppConfig.TabIndex = 70;
            radioAppConfig.Text = "Portrait";
            radioAppConfig.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A4", "Letter", "Legal", "Custom" });
            comboBox1.Location = new Point(102, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 68;
            label3.Text = "Size:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(18, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 175);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Header and Footer";
            // 
            // checkBox3
            // 
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.FlatStyle = FlatStyle.System;
            checkBox3.Location = new Point(6, 69);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(138, 20);
            checkBox3.TabIndex = 62;
            checkBox3.Text = "Show Page Numbers";
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(148, 32);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(138, 20);
            checkBox2.TabIndex = 61;
            checkBox2.Text = "Include Page Footer";
            // 
            // checkBox1
            // 
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(6, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 20);
            checkBox1.TabIndex = 60;
            checkBox1.Text = "Include Page Header";
            // 
            // checkBox4
            // 
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatStyle = FlatStyle.System;
            checkBox4.Location = new Point(148, 69);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(138, 20);
            checkBox4.TabIndex = 63;
            checkBox4.Text = "Show Current Date";
            // 
            // checkBox5
            // 
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.FlatStyle = FlatStyle.System;
            checkBox5.Location = new Point(6, 106);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(138, 20);
            checkBox5.TabIndex = 64;
            checkBox5.Text = "Show Report Name";
            // 
            // PageSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(661, 522);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupAuth);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PageSettings";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Report";
            Load += PageSettings_Load;
            panel1.ResumeLayout(false);
            groupAuth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_iconBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnNext;
        private Button btnFinish;
        private Label lblTitle;
        private GroupBox groupAuth;
        private PictureBox _iconBox;
        private Button btnBack;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioAppConfig;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}