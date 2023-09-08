namespace ReportWizardPrototype
{
	partial class ExcelDataSets
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
			btnBack = new Button();
			btnNext = new Button();
			label6 = new Label();
			button2 = new Button();
			button1 = new Button();
			listBox1 = new ListBox();
			textBox2 = new TextBox();
			label1 = new Label();
			listSheets = new ListBox();
			optionRange = new RadioButton();
			optionSheet = new RadioButton();
			optionTable = new RadioButton();
			optHeaderRow = new CheckBox();
			checkBox1 = new CheckBox();
			checkBox2 = new CheckBox();
			checkBox3 = new CheckBox();
			panel1.SuspendLayout();
			SuspendLayout();
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
			panel1.TabIndex = 8;
			// 
			// btnCancel
			// 
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
			btnNext.Location = new Point(493, 18);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 1;
			btnNext.Text = "Next >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(217, 19);
			label6.TabIndex = 0;
			label6.Text = "Confgure Excel Workbook Queries";
			// 
			// button2
			// 
			button2.Location = new Point(99, 388);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(18, 388);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "Query1" });
			listBox1.Location = new Point(18, 48);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(202, 334);
			listBox1.TabIndex = 1;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(299, 48);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(350, 23);
			textBox2.TabIndex = 5;
			textBox2.Text = "Query1";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(251, 51);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 4;
			label1.Text = "Name:";
			// 
			// listSheets
			// 
			listSheets.FormattingEnabled = true;
			listSheets.ItemHeight = 15;
			listSheets.Items.AddRange(new object[] { "Sheet$1", "Sheet$2", "Sheet$3", "Sheet$4" });
			listSheets.Location = new Point(251, 123);
			listSheets.Name = "listSheets";
			listSheets.Size = new Size(398, 199);
			listSheets.TabIndex = 9;
			// 
			// optionRange
			// 
			optionRange.AutoSize = true;
			optionRange.FlatStyle = FlatStyle.System;
			optionRange.Location = new Point(317, 90);
			optionRange.Name = "optionRange";
			optionRange.Size = new Size(106, 20);
			optionRange.TabIndex = 7;
			optionRange.TabStop = true;
			optionRange.Text = "Named Range";
			optionRange.UseVisualStyleBackColor = true;
			// 
			// optionSheet
			// 
			optionSheet.AutoSize = true;
			optionSheet.Checked = true;
			optionSheet.FlatStyle = FlatStyle.System;
			optionSheet.Location = new Point(251, 90);
			optionSheet.Name = "optionSheet";
			optionSheet.Size = new Size(60, 20);
			optionSheet.TabIndex = 6;
			optionSheet.TabStop = true;
			optionSheet.Text = "Sheet";
			optionSheet.UseVisualStyleBackColor = true;
			// 
			// optionTable
			// 
			optionTable.AutoSize = true;
			optionTable.FlatStyle = FlatStyle.System;
			optionTable.Location = new Point(435, 90);
			optionTable.Name = "optionTable";
			optionTable.Size = new Size(58, 20);
			optionTable.TabIndex = 8;
			optionTable.TabStop = true;
			optionTable.Text = "Table";
			optionTable.UseVisualStyleBackColor = true;
			// 
			// optHeaderRow
			// 
			optHeaderRow.Checked = true;
			optHeaderRow.CheckState = CheckState.Checked;
			optHeaderRow.FlatStyle = FlatStyle.System;
			optHeaderRow.Location = new Point(251, 328);
			optHeaderRow.Name = "optHeaderRow";
			optHeaderRow.Size = new Size(221, 24);
			optHeaderRow.TabIndex = 10;
			optHeaderRow.Text = "Read field names from the first row";
			// 
			// checkBox1
			// 
			checkBox1.Checked = true;
			checkBox1.CheckState = CheckState.Checked;
			checkBox1.FlatStyle = FlatStyle.System;
			checkBox1.Location = new Point(251, 358);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(221, 24);
			checkBox1.TabIndex = 11;
			checkBox1.Text = "Skip empty rows";
			// 
			// checkBox2
			// 
			checkBox2.Checked = true;
			checkBox2.CheckState = CheckState.Checked;
			checkBox2.FlatStyle = FlatStyle.System;
			checkBox2.Location = new Point(478, 358);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(171, 24);
			checkBox2.TabIndex = 13;
			checkBox2.Text = "Skip hidden rows";
			// 
			// checkBox3
			// 
			checkBox3.Checked = true;
			checkBox3.CheckState = CheckState.Checked;
			checkBox3.FlatStyle = FlatStyle.System;
			checkBox3.Location = new Point(478, 328);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(171, 24);
			checkBox3.TabIndex = 12;
			checkBox3.Text = "Skip hidden columns";
			// 
			// ExcelDataSets
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(checkBox3);
			Controls.Add(checkBox2);
			Controls.Add(checkBox1);
			Controls.Add(optionTable);
			Controls.Add(optionRange);
			Controls.Add(optionSheet);
			Controls.Add(listSheets);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(listBox1);
			Controls.Add(label6);
			Controls.Add(panel1);
			Controls.Add(optHeaderRow);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ExcelDataSets";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnNext;
		private Label label6;
		private Button button2;
		private Button button1;
		private ListBox listBox1;
		private TextBox textBox2;
		private Label label1;
		private ListBox listSheets;
		private RadioButton optionRange;
		private RadioButton optionSheet;
		private RadioButton optionTable;
		private CheckBox optHeaderRow;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
	}
}