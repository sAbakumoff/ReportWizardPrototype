namespace ReportWizardPrototype
{
	partial class CSVConnection
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
			lblTitle = new Label();
			panel1 = new Panel();
			btnCancel = new Button();
			btnBack = new Button();
			btnNext = new Button();
			groupGeneral = new GroupBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			comboBox1 = new ComboBox();
			comboboxEncoding = new ComboBox();
			label3 = new Label();
			label2 = new Label();
			radioFixed = new RadioButton();
			radioDelimited = new RadioButton();
			label1 = new Label();
			btnBrowse = new Button();
			lblPath = new Label();
			txtPath = new TextBox();
			linkPath = new LinkLabel();
			groupData = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			optHeaderRow = new CheckBox();
			label4 = new Label();
			textBox1 = new TextBox();
			groupDelimiters = new GroupBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			comboBox4 = new ComboBox();
			label7 = new Label();
			checkBox2 = new CheckBox();
			comboBox3 = new ComboBox();
			label6 = new Label();
			comboBox2 = new ComboBox();
			checkBox1 = new CheckBox();
			label5 = new Label();
			panel1.SuspendLayout();
			groupGeneral.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			groupData.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			groupDelimiters.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(169, 19);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Confgure CSV Connection";
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(btnCancel);
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(btnNext);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 461);
			panel1.Name = "panel1";
			panel1.Size = new Size(661, 61);
			panel1.TabIndex = 4;
			// 
			// btnCancel
			// 
			btnCancel.FlatStyle = FlatStyle.System;
			btnCancel.Location = new Point(574, 18);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 2;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnBack
			// 
			btnBack.FlatStyle = FlatStyle.System;
			btnBack.Location = new Point(412, 18);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(75, 23);
			btnBack.TabIndex = 0;
			btnBack.Text = "< Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// btnNext
			// 
			btnNext.FlatStyle = FlatStyle.System;
			btnNext.Location = new Point(493, 18);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 1;
			btnNext.Text = "Next >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel2);
			groupGeneral.Location = new Point(18, 48);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 138);
			groupGeneral.TabIndex = 1;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 5;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
			tableLayoutPanel2.Controls.Add(comboBox1, 1, 3);
			tableLayoutPanel2.Controls.Add(comboboxEncoding, 1, 2);
			tableLayoutPanel2.Controls.Add(label3, 0, 3);
			tableLayoutPanel2.Controls.Add(label2, 0, 2);
			tableLayoutPanel2.Controls.Add(radioFixed, 2, 1);
			tableLayoutPanel2.Controls.Add(radioDelimited, 1, 1);
			tableLayoutPanel2.Controls.Add(label1, 0, 1);
			tableLayoutPanel2.Controls.Add(btnBrowse, 2, 0);
			tableLayoutPanel2.Controls.Add(lblPath, 0, 0);
			tableLayoutPanel2.Controls.Add(txtPath, 1, 0);
			tableLayoutPanel2.Controls.Add(linkPath, 3, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 19);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 4;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Size = new Size(625, 116);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// comboBox1
			// 
			tableLayoutPanel2.SetColumnSpan(comboBox1, 2);
			comboBox1.Dock = DockStyle.Fill;
			comboBox1.Items.AddRange(new object[] { "English(United States)", "Unicode(United Kingdom)", "other locales" });
			comboBox1.Location = new Point(128, 90);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(336, 23);
			comboBox1.TabIndex = 10;
			// 
			// comboboxEncoding
			// 
			tableLayoutPanel2.SetColumnSpan(comboboxEncoding, 2);
			comboboxEncoding.Dock = DockStyle.Fill;
			comboboxEncoding.Items.AddRange(new object[] { "Unicode(UTF-8)", "Unicode(UTF-32)", "other encodings" });
			comboboxEncoding.Location = new Point(128, 61);
			comboboxEncoding.Name = "comboboxEncoding";
			comboboxEncoding.Size = new Size(336, 23);
			comboboxEncoding.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 87);
			label3.Name = "label3";
			label3.Size = new Size(119, 29);
			label3.TabIndex = 9;
			label3.Text = "File Locale:";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 58);
			label2.Name = "label2";
			label2.Size = new Size(119, 29);
			label2.TabIndex = 7;
			label2.Text = "File Encoding:";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// radioFixed
			// 
			radioFixed.AutoSize = true;
			radioFixed.Dock = DockStyle.Fill;
			radioFixed.Location = new Point(299, 32);
			radioFixed.Name = "radioFixed";
			radioFixed.Size = new Size(165, 23);
			radioFixed.TabIndex = 6;
			radioFixed.Text = "Fixed";
			radioFixed.UseVisualStyleBackColor = true;
			// 
			// radioDelimited
			// 
			radioDelimited.AutoSize = true;
			radioDelimited.Checked = true;
			radioDelimited.Dock = DockStyle.Fill;
			radioDelimited.Location = new Point(128, 32);
			radioDelimited.Name = "radioDelimited";
			radioDelimited.Size = new Size(165, 23);
			radioDelimited.TabIndex = 5;
			radioDelimited.TabStop = true;
			radioDelimited.Text = "Delimited";
			radioDelimited.UseVisualStyleBackColor = true;
			radioDelimited.CheckedChanged += radioDelimited_CheckedChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 29);
			label1.Name = "label1";
			label1.Size = new Size(119, 29);
			label1.TabIndex = 4;
			label1.Text = "File Type:";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnBrowse
			// 
			btnBrowse.Dock = DockStyle.Fill;
			btnBrowse.FlatStyle = FlatStyle.System;
			btnBrowse.Location = new Point(470, 3);
			btnBrowse.Name = "btnBrowse";
			btnBrowse.Size = new Size(69, 23);
			btnBrowse.TabIndex = 2;
			btnBrowse.Text = "Browse...";
			btnBrowse.UseVisualStyleBackColor = true;
			// 
			// lblPath
			// 
			lblPath.AutoSize = true;
			lblPath.Dock = DockStyle.Fill;
			lblPath.Location = new Point(3, 0);
			lblPath.Name = "lblPath";
			lblPath.Size = new Size(119, 29);
			lblPath.TabIndex = 0;
			lblPath.Text = "File Path:";
			lblPath.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPath
			// 
			tableLayoutPanel2.SetColumnSpan(txtPath, 2);
			txtPath.Dock = DockStyle.Fill;
			txtPath.Location = new Point(128, 3);
			txtPath.Name = "txtPath";
			txtPath.Size = new Size(336, 23);
			txtPath.TabIndex = 1;
			// 
			// linkPath
			// 
			linkPath.AutoSize = true;
			linkPath.Dock = DockStyle.Fill;
			linkPath.Location = new Point(545, 0);
			linkPath.Name = "linkPath";
			linkPath.Size = new Size(77, 29);
			linkPath.TabIndex = 3;
			linkPath.TabStop = true;
			linkPath.Text = "Parameter...";
			linkPath.TextAlign = ContentAlignment.MiddleLeft;
			linkPath.LinkClicked += linkPath_LinkClicked;
			// 
			// groupData
			// 
			groupData.Controls.Add(tableLayoutPanel1);
			groupData.Location = new Point(15, 206);
			groupData.Name = "groupData";
			groupData.Size = new Size(631, 53);
			groupData.TabIndex = 2;
			groupData.TabStop = false;
			groupData.Text = "Data";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(optHeaderRow, 2, 0);
			tableLayoutPanel1.Controls.Add(label4, 0, 0);
			tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(625, 31);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// optHeaderRow
			// 
			optHeaderRow.Checked = true;
			optHeaderRow.CheckState = CheckState.Checked;
			optHeaderRow.Dock = DockStyle.Fill;
			optHeaderRow.FlatStyle = FlatStyle.System;
			optHeaderRow.Location = new Point(378, 3);
			optHeaderRow.Name = "optHeaderRow";
			optHeaderRow.Size = new Size(244, 25);
			optHeaderRow.TabIndex = 2;
			optHeaderRow.Text = "Read field names from the first row";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(119, 31);
			label4.TabIndex = 0;
			label4.Text = "Data starts at row:";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(128, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(244, 23);
			textBox1.TabIndex = 1;
			textBox1.Text = "1";
			textBox1.TextAlign = HorizontalAlignment.Right;
			// 
			// groupDelimiters
			// 
			groupDelimiters.Controls.Add(tableLayoutPanel3);
			groupDelimiters.Location = new Point(15, 284);
			groupDelimiters.Name = "groupDelimiters";
			groupDelimiters.Size = new Size(631, 103);
			groupDelimiters.TabIndex = 3;
			groupDelimiters.TabStop = false;
			groupDelimiters.Text = "Delimiters";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
			tableLayoutPanel3.Controls.Add(comboBox4, 1, 2);
			tableLayoutPanel3.Controls.Add(label7, 0, 2);
			tableLayoutPanel3.Controls.Add(checkBox2, 2, 1);
			tableLayoutPanel3.Controls.Add(comboBox3, 1, 1);
			tableLayoutPanel3.Controls.Add(label6, 0, 1);
			tableLayoutPanel3.Controls.Add(comboBox2, 1, 0);
			tableLayoutPanel3.Controls.Add(checkBox1, 2, 0);
			tableLayoutPanel3.Controls.Add(label5, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 19);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 3;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
			tableLayoutPanel3.Size = new Size(625, 81);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// comboBox4
			// 
			comboBox4.Dock = DockStyle.Fill;
			comboBox4.Items.AddRange(new object[] { "Single Quote", "Double Quote" });
			comboBox4.Location = new Point(128, 55);
			comboBox4.Name = "comboBox4";
			comboBox4.Size = new Size(244, 23);
			comboBox4.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(3, 52);
			label7.Name = "label7";
			label7.Size = new Size(119, 29);
			label7.TabIndex = 6;
			label7.Text = "Text Qualifier:";
			label7.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// checkBox2
			// 
			checkBox2.Checked = true;
			checkBox2.CheckState = CheckState.Checked;
			checkBox2.Dock = DockStyle.Fill;
			checkBox2.FlatStyle = FlatStyle.System;
			checkBox2.Location = new Point(378, 29);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(244, 20);
			checkBox2.TabIndex = 5;
			checkBox2.Text = "Merge consecutive row delimiters";
			// 
			// comboBox3
			// 
			comboBox3.Dock = DockStyle.Fill;
			comboBox3.Items.AddRange(new object[] { "Carriage Return + Line Feed (CRLF)", "Carriage Return (CR)", "Line Feed (LF)" });
			comboBox3.Location = new Point(128, 29);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(244, 23);
			comboBox3.TabIndex = 4;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Dock = DockStyle.Fill;
			label6.Location = new Point(3, 26);
			label6.Name = "label6";
			label6.Size = new Size(119, 26);
			label6.TabIndex = 3;
			label6.Text = "Row Delimiter:";
			label6.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// comboBox2
			// 
			comboBox2.Dock = DockStyle.Fill;
			comboBox2.Items.AddRange(new object[] { "Comma", "Semicolon", "Tab", "Space" });
			comboBox2.Location = new Point(128, 3);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(244, 23);
			comboBox2.TabIndex = 1;
			// 
			// checkBox1
			// 
			checkBox1.Checked = true;
			checkBox1.CheckState = CheckState.Checked;
			checkBox1.Dock = DockStyle.Fill;
			checkBox1.FlatStyle = FlatStyle.System;
			checkBox1.Location = new Point(378, 3);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(244, 20);
			checkBox1.TabIndex = 2;
			checkBox1.Text = "Merge consecutive column delimiters";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(119, 26);
			label5.TabIndex = 0;
			label5.Text = "Column Delimiter:";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// CSVConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(groupDelimiters);
			Controls.Add(groupData);
			Controls.Add(groupGeneral);
			Controls.Add(panel1);
			Controls.Add(lblTitle);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CSVConnection";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupGeneral.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			groupData.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			groupDelimiters.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTitle;
		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnNext;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel2;
		private Button btnBrowse;
		private Label lblPath;
		private TextBox txtPath;
		private LinkLabel linkPath;
		private Label label1;
		private RadioButton radioFixed;
		private RadioButton radioDelimited;
		private Label label3;
		private Label label2;
		private ComboBox comboboxEncoding;
		private ComboBox comboBox1;
		private GroupBox groupData;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label4;
		private TextBox textBox1;
		private CheckBox optHeaderRow;
		private GroupBox groupDelimiters;
		private TableLayoutPanel tableLayoutPanel3;
		private ComboBox comboBox2;
		private CheckBox checkBox1;
		private Label label5;
		private ComboBox comboBox3;
		private Label label6;
		private CheckBox checkBox2;
		private ComboBox comboBox4;
		private Label label7;
	}
}