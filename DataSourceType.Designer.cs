namespace ReportWizardPrototype
{
	partial class DataSourceType
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
			groupFile = new GroupBox();
			tableLayoutFile = new TableLayoutPanel();
			groupBox1 = new GroupBox();
			tableLayoutWebApi = new TableLayoutPanel();
			groupBox2 = new GroupBox();
			tableLayoutProgrammatic = new TableLayoutPanel();
			panel1 = new Panel();
			btnNext = new Button();
			btnBack = new Button();
			btnCancel = new Button();
			label6 = new Label();
			groupBox3 = new GroupBox();
			tableLayoutDatabase = new TableLayoutPanel();
			groupFile.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// groupFile
			// 
			groupFile.Controls.Add(tableLayoutFile);
			groupFile.FlatStyle = FlatStyle.System;
			groupFile.Location = new Point(18, 190);
			groupFile.Name = "groupFile";
			groupFile.Padding = new Padding(3, 3, 3, 6);
			groupFile.Size = new Size(631, 75);
			groupFile.TabIndex = 2;
			groupFile.TabStop = false;
			groupFile.Text = "File";
			// 
			// tableLayoutFile
			// 
			tableLayoutFile.AutoSize = true;
			tableLayoutFile.BackColor = SystemColors.ControlLightLight;
			tableLayoutFile.ColumnCount = 4;
			tableLayoutFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutFile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutFile.Dock = DockStyle.Fill;
			tableLayoutFile.Location = new Point(3, 19);
			tableLayoutFile.Name = "tableLayoutFile";
			tableLayoutFile.RowCount = 1;
			tableLayoutFile.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutFile.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutFile.Size = new Size(625, 50);
			tableLayoutFile.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutWebApi);
			groupBox1.FlatStyle = FlatStyle.System;
			groupBox1.Location = new Point(18, 280);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 3, 3, 6);
			groupBox1.Size = new Size(631, 75);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Web API";
			// 
			// tableLayoutWebApi
			// 
			tableLayoutWebApi.AutoSize = true;
			tableLayoutWebApi.BackColor = SystemColors.ControlLightLight;
			tableLayoutWebApi.ColumnCount = 4;
			tableLayoutWebApi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutWebApi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutWebApi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutWebApi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutWebApi.Dock = DockStyle.Fill;
			tableLayoutWebApi.Location = new Point(3, 19);
			tableLayoutWebApi.Name = "tableLayoutWebApi";
			tableLayoutWebApi.RowCount = 1;
			tableLayoutWebApi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutWebApi.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutWebApi.Size = new Size(625, 50);
			tableLayoutWebApi.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(tableLayoutProgrammatic);
			groupBox2.FlatStyle = FlatStyle.System;
			groupBox2.Location = new Point(18, 370);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 3, 3, 6);
			groupBox2.Size = new Size(631, 75);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Programmatic";
			// 
			// tableLayoutProgrammatic
			// 
			tableLayoutProgrammatic.AutoSize = true;
			tableLayoutProgrammatic.BackColor = SystemColors.ControlLightLight;
			tableLayoutProgrammatic.ColumnCount = 4;
			tableLayoutProgrammatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutProgrammatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutProgrammatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutProgrammatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutProgrammatic.Dock = DockStyle.Fill;
			tableLayoutProgrammatic.Location = new Point(3, 19);
			tableLayoutProgrammatic.Name = "tableLayoutProgrammatic";
			tableLayoutProgrammatic.RowCount = 1;
			tableLayoutProgrammatic.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutProgrammatic.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutProgrammatic.Size = new Size(625, 50);
			tableLayoutProgrammatic.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(btnNext);
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(btnCancel);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 461);
			panel1.Name = "panel1";
			panel1.Size = new Size(661, 61);
			panel1.TabIndex = 32;
			// 
			// btnNext
			// 
			btnNext.Location = new Point(493, 18);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 34;
			btnNext.Text = "Next >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += OnNext;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(412, 18);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(75, 23);
			btnBack.TabIndex = 33;
			btnBack.Text = "< Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += OnBack;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(574, 18);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 32;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += OnCancel;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(165, 19);
			label6.TabIndex = 33;
			label6.Text = "Choose Data Source Type";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(tableLayoutDatabase);
			groupBox3.FlatStyle = FlatStyle.Flat;
			groupBox3.Location = new Point(18, 54);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(3, 3, 3, 6);
			groupBox3.Size = new Size(631, 120);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			groupBox3.Text = "Database";
			// 
			// tableLayoutDatabase
			// 
			tableLayoutDatabase.AutoSize = true;
			tableLayoutDatabase.BackColor = SystemColors.ControlLightLight;
			tableLayoutDatabase.ColumnCount = 4;
			tableLayoutDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutDatabase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutDatabase.Dock = DockStyle.Fill;
			tableLayoutDatabase.Location = new Point(3, 19);
			tableLayoutDatabase.Name = "tableLayoutDatabase";
			tableLayoutDatabase.RowCount = 2;
			tableLayoutDatabase.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutDatabase.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutDatabase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutDatabase.Size = new Size(625, 95);
			tableLayoutDatabase.TabIndex = 35;
			// 
			// DataSourceType
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(groupBox3);
			Controls.Add(label6);
			Controls.Add(panel1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(groupFile);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DataSourceType";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "New Report";
			groupFile.ResumeLayout(false);
			groupFile.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			panel1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private GroupBox groupFile;
		private TableLayoutPanel tableLayoutFile;
		private GroupBox groupBox1;
		private TableLayoutPanel tableLayoutWebApi;
		private GroupBox groupBox2;
		private TableLayoutPanel tableLayoutProgrammatic;
		private Panel panel1;
		private Button btnCancel;
		private Label label6;
		private Button btnBack;
		private Button btnNext;
		private GroupBox groupBox3;
		private TableLayoutPanel tableLayoutDatabase;
	}
}