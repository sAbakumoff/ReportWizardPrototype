namespace ReportWizardPrototype
{
	partial class XMLConnection
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
			lblTitle = new Label();
			groupGeneral = new GroupBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnBrowse = new Button();
			lblPath = new Label();
			txtPath = new TextBox();
			linkPath = new LinkLabel();
			groupBox1 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			linkLabel1 = new LinkLabel();
			panel1.SuspendLayout();
			groupGeneral.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			groupBox1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
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
			// btnBack
			// 
			btnBack.FlatStyle = FlatStyle.System;
			btnBack.Location = new Point(412, 18);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(75, 23);
			btnBack.TabIndex = 1;
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
			btnNext.TabIndex = 2;
			btnNext.Text = "Next >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(172, 19);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Confgure XML Connection";
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel2);
			groupGeneral.Location = new Point(18, 48);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 53);
			groupGeneral.TabIndex = 2;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
			tableLayoutPanel2.Controls.Add(btnBrowse, 2, 0);
			tableLayoutPanel2.Controls.Add(lblPath, 0, 0);
			tableLayoutPanel2.Controls.Add(txtPath, 1, 0);
			tableLayoutPanel2.Controls.Add(linkPath, 3, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 19);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(625, 31);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// btnBrowse
			// 
			btnBrowse.Dock = DockStyle.Fill;
			btnBrowse.FlatStyle = FlatStyle.System;
			btnBrowse.Location = new Point(471, 3);
			btnBrowse.Name = "btnBrowse";
			btnBrowse.Size = new Size(69, 25);
			btnBrowse.TabIndex = 2;
			btnBrowse.Text = "Browse...";
			btnBrowse.UseVisualStyleBackColor = true;
			btnBrowse.Click += btnBrowse_Click;
			// 
			// lblPath
			// 
			lblPath.AutoSize = true;
			lblPath.Dock = DockStyle.Fill;
			lblPath.Location = new Point(3, 0);
			lblPath.Name = "lblPath";
			lblPath.Size = new Size(119, 31);
			lblPath.TabIndex = 0;
			lblPath.Text = "File Path:";
			lblPath.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPath
			// 
			txtPath.Dock = DockStyle.Fill;
			txtPath.Location = new Point(128, 3);
			txtPath.Name = "txtPath";
			txtPath.Size = new Size(337, 23);
			txtPath.TabIndex = 1;
			// 
			// linkPath
			// 
			linkPath.AutoSize = true;
			linkPath.Dock = DockStyle.Fill;
			linkPath.Location = new Point(546, 0);
			linkPath.Name = "linkPath";
			linkPath.Size = new Size(76, 31);
			linkPath.TabIndex = 3;
			linkPath.TabStop = true;
			linkPath.Text = "Parameter...";
			linkPath.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutPanel1);
			groupBox1.Location = new Point(18, 121);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(631, 53);
			groupBox1.TabIndex = 34;
			groupBox1.TabStop = false;
			groupBox1.Text = "Transformation";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
			tableLayoutPanel1.Controls.Add(button1, 2, 0);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
			tableLayoutPanel1.Controls.Add(linkLabel1, 3, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(625, 31);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.FlatStyle = FlatStyle.System;
			button1.Location = new Point(471, 3);
			button1.Name = "button1";
			button1.Size = new Size(69, 25);
			button1.TabIndex = 2;
			button1.Text = "Browse...";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(119, 31);
			label1.TabIndex = 0;
			label1.Text = "XSLT File Path:";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(128, 3);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(337, 23);
			textBox1.TabIndex = 1;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Dock = DockStyle.Fill;
			linkLabel1.Location = new Point(546, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(76, 31);
			linkLabel1.TabIndex = 3;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Parameter...";
			linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// XMLConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(groupBox1);
			Controls.Add(groupGeneral);
			Controls.Add(lblTitle);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "XMLConnection";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupGeneral.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			groupBox1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnNext;
		private Label lblTitle;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel2;
		private Label lblPath;
		private TextBox txtPath;
		private LinkLabel linkPath;
		private Button btnBrowse;
		private GroupBox groupBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private Button button1;
		private Label label1;
		private TextBox textBox1;
		private LinkLabel linkLabel1;
	}
}