namespace ReportWizardPrototype
{
	partial class FileConnection
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
			btnTestConnection = new Button();
			lblTitle = new Label();
			groupGeneral = new GroupBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			btnBrowse = new Button();
			lblPath = new Label();
			txtPath = new TextBox();
			linkPath = new LinkLabel();
			groupAuth = new GroupBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			linkPwd = new LinkLabel();
			txtUserName = new TextBox();
			label4 = new Label();
			groupBox1 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			radioAppConfig = new RadioButton();
			radioManual = new RadioButton();
			label1 = new Label();
			txtConnStringName = new TextBox();
			panel1.SuspendLayout();
			groupGeneral.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			groupAuth.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
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
			panel1.Controls.Add(btnTestConnection);
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
			// btnTestConnection
			// 
			btnTestConnection.FlatStyle = FlatStyle.System;
			btnTestConnection.Location = new Point(18, 18);
			btnTestConnection.Name = "btnTestConnection";
			btnTestConnection.Size = new Size(126, 23);
			btnTestConnection.TabIndex = 0;
			btnTestConnection.Text = "Test connection";
			btnTestConnection.UseVisualStyleBackColor = true;
			btnTestConnection.Click += btnTestConnection_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(184, 19);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Confgure SQLite Connection";
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel2);
			groupGeneral.Location = new Point(18, 190);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 53);
			groupGeneral.TabIndex = 2;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			groupGeneral.Visible = false;
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
			lblPath.Text = "Database Path:";
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
			// groupAuth
			// 
			groupAuth.Controls.Add(tableLayoutPanel3);
			groupAuth.Location = new Point(15, 263);
			groupAuth.Name = "groupAuth";
			groupAuth.Size = new Size(631, 53);
			groupAuth.TabIndex = 3;
			groupAuth.TabStop = false;
			groupAuth.Text = "Authentication";
			groupAuth.Visible = false;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
			tableLayoutPanel3.Controls.Add(linkPwd, 2, 0);
			tableLayoutPanel3.Controls.Add(txtUserName, 1, 0);
			tableLayoutPanel3.Controls.Add(label4, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 19);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(625, 31);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// linkPwd
			// 
			linkPwd.AutoSize = true;
			linkPwd.Dock = DockStyle.Fill;
			linkPwd.Location = new Point(546, 0);
			linkPwd.Name = "linkPwd";
			linkPwd.Size = new Size(76, 31);
			linkPwd.TabIndex = 2;
			linkPwd.TabStop = true;
			linkPwd.Text = "Parameter...";
			linkPwd.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtUserName
			// 
			txtUserName.Dock = DockStyle.Fill;
			txtUserName.Location = new Point(128, 3);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(412, 25);
			txtUserName.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(119, 31);
			label4.TabIndex = 0;
			label4.Text = "Password:";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutPanel1);
			groupBox1.Location = new Point(18, 48);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(631, 122);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.Controls.Add(radioAppConfig, 0, 0);
			tableLayoutPanel1.Controls.Add(radioManual, 0, 2);
			tableLayoutPanel1.Controls.Add(label1, 0, 1);
			tableLayoutPanel1.Controls.Add(txtConnStringName, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Size = new Size(625, 100);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// radioAppConfig
			// 
			radioAppConfig.AutoSize = true;
			radioAppConfig.Checked = true;
			tableLayoutPanel1.SetColumnSpan(radioAppConfig, 2);
			radioAppConfig.Dock = DockStyle.Fill;
			radioAppConfig.Location = new Point(3, 3);
			radioAppConfig.Name = "radioAppConfig";
			radioAppConfig.Size = new Size(619, 27);
			radioAppConfig.TabIndex = 0;
			radioAppConfig.TabStop = true;
			radioAppConfig.Text = "Use Existing Connection String from Configuration File";
			radioAppConfig.UseVisualStyleBackColor = true;
			radioAppConfig.CheckedChanged += radioAppConfig_CheckedChanged;
			// 
			// radioManual
			// 
			radioManual.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(radioManual, 2);
			radioManual.Dock = DockStyle.Fill;
			radioManual.Location = new Point(3, 69);
			radioManual.Name = "radioManual";
			radioManual.Size = new Size(619, 28);
			radioManual.TabIndex = 3;
			radioManual.Text = "Manually Specify Connection String";
			radioManual.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 33);
			label1.Name = "label1";
			label1.Size = new Size(181, 33);
			label1.TabIndex = 1;
			label1.Text = "Connection String Name:";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtConnStringName
			// 
			txtConnStringName.Dock = DockStyle.Fill;
			txtConnStringName.Location = new Point(190, 36);
			txtConnStringName.Multiline = true;
			txtConnStringName.Name = "txtConnStringName";
			txtConnStringName.Size = new Size(432, 27);
			txtConnStringName.TabIndex = 2;
			// 
			// FileConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(groupBox1);
			Controls.Add(groupAuth);
			Controls.Add(groupGeneral);
			Controls.Add(lblTitle);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FileConnection";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupGeneral.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			groupAuth.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
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
		private Button btnTestConnection;
		private Label lblTitle;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel2;
		private Label lblPath;
		private TextBox txtPath;
		private LinkLabel linkPath;
		private Button btnBrowse;
		private GroupBox groupAuth;
		private TableLayoutPanel tableLayoutPanel3;
		private LinkLabel linkPwd;
		private TextBox txtUserName;
		private Label label4;
		private GroupBox groupBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private RadioButton radioAppConfig;
		private RadioButton radioManual;
		private Label label1;
		private TextBox txtConnStringName;
	}
}