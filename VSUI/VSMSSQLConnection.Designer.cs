﻿namespace ReportWizardPrototype.VSUI
{
	partial class VSMSSQLConnection
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
			groupBox1 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			radioAppConfig = new RadioButton();
			radioManual = new RadioButton();
			label1 = new Label();
			txtConnStringName = new TextBox();
			groupGeneral = new GroupBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			linkLabel2 = new LinkLabel();
			label2 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			linkLabel1 = new LinkLabel();
			groupAuth = new GroupBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			linkPwdParam = new LinkLabel();
			txtPwd = new TextBox();
			label5 = new Label();
			linkUserNameParam = new LinkLabel();
			txtUserName = new TextBox();
			label4 = new Label();
			radioAuthSQL = new RadioButton();
			radioAuthWindows = new RadioButton();
			btnTestConnection = new Button();
			btnAdvanced = new Button();
			panel1 = new Panel();
			btnCancel = new Button();
			btnBack = new Button();
			btnNext = new Button();
			label6 = new Label();
			groupBox1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			groupGeneral.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			groupAuth.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutPanel1);
			groupBox1.Location = new Point(18, 40);
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
			radioManual.CheckedChanged += radioButton2_CheckedChanged;
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
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel2);
			groupGeneral.Location = new Point(18, 182);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 90);
			groupGeneral.TabIndex = 2;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			groupGeneral.Visible = false;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
			tableLayoutPanel2.Controls.Add(linkLabel2, 2, 1);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(textBox2, 1, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 1);
			tableLayoutPanel2.Controls.Add(textBox3, 1, 1);
			tableLayoutPanel2.Controls.Add(linkLabel1, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 19);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(625, 68);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Dock = DockStyle.Fill;
			linkLabel2.Location = new Point(534, 34);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(88, 34);
			linkLabel2.TabIndex = 5;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Parameter...";
			linkLabel2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(119, 34);
			label2.TabIndex = 0;
			label2.Text = "Server Name:";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox2
			// 
			textBox2.Dock = DockStyle.Fill;
			textBox2.Location = new Point(128, 3);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(400, 28);
			textBox2.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 34);
			label3.Name = "label3";
			label3.Size = new Size(119, 34);
			label3.TabIndex = 3;
			label3.Text = "Database:";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			textBox3.Dock = DockStyle.Fill;
			textBox3.Location = new Point(128, 37);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(400, 28);
			textBox3.TabIndex = 4;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Dock = DockStyle.Fill;
			linkLabel1.Location = new Point(534, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(88, 34);
			linkLabel1.TabIndex = 2;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Parameter...";
			linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupAuth
			// 
			groupAuth.Controls.Add(tableLayoutPanel3);
			groupAuth.Location = new Point(18, 292);
			groupAuth.Name = "groupAuth";
			groupAuth.Size = new Size(631, 113);
			groupAuth.TabIndex = 3;
			groupAuth.TabStop = false;
			groupAuth.Text = "Authentication";
			groupAuth.Visible = false;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
			tableLayoutPanel3.Controls.Add(linkPwdParam, 2, 2);
			tableLayoutPanel3.Controls.Add(txtPwd, 1, 2);
			tableLayoutPanel3.Controls.Add(label5, 0, 2);
			tableLayoutPanel3.Controls.Add(linkUserNameParam, 2, 1);
			tableLayoutPanel3.Controls.Add(txtUserName, 1, 1);
			tableLayoutPanel3.Controls.Add(label4, 0, 1);
			tableLayoutPanel3.Controls.Add(radioAuthSQL, 0, 0);
			tableLayoutPanel3.Controls.Add(radioAuthWindows, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 19);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 3;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel3.Size = new Size(625, 91);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// linkPwdParam
			// 
			linkPwdParam.AutoSize = true;
			linkPwdParam.Dock = DockStyle.Fill;
			linkPwdParam.Location = new Point(534, 60);
			linkPwdParam.Name = "linkPwdParam";
			linkPwdParam.Size = new Size(88, 31);
			linkPwdParam.TabIndex = 7;
			linkPwdParam.TabStop = true;
			linkPwdParam.Text = "Parameter...";
			linkPwdParam.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPwd
			// 
			txtPwd.Dock = DockStyle.Fill;
			txtPwd.Location = new Point(128, 63);
			txtPwd.Multiline = true;
			txtPwd.Name = "txtPwd";
			txtPwd.Size = new Size(400, 25);
			txtPwd.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 60);
			label5.Name = "label5";
			label5.Size = new Size(119, 31);
			label5.TabIndex = 5;
			label5.Text = "Password:";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// linkUserNameParam
			// 
			linkUserNameParam.AutoSize = true;
			linkUserNameParam.Dock = DockStyle.Fill;
			linkUserNameParam.Location = new Point(534, 30);
			linkUserNameParam.Name = "linkUserNameParam";
			linkUserNameParam.Size = new Size(88, 30);
			linkUserNameParam.TabIndex = 4;
			linkUserNameParam.TabStop = true;
			linkUserNameParam.Text = "Parameter...";
			linkUserNameParam.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtUserName
			// 
			txtUserName.Dock = DockStyle.Fill;
			txtUserName.Location = new Point(128, 33);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(400, 24);
			txtUserName.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 30);
			label4.Name = "label4";
			label4.Size = new Size(119, 30);
			label4.TabIndex = 2;
			label4.Text = "User Name:";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// radioAuthSQL
			// 
			radioAuthSQL.AutoSize = true;
			radioAuthSQL.Checked = true;
			radioAuthSQL.Dock = DockStyle.Fill;
			radioAuthSQL.Location = new Point(3, 3);
			radioAuthSQL.Name = "radioAuthSQL";
			radioAuthSQL.Size = new Size(119, 24);
			radioAuthSQL.TabIndex = 0;
			radioAuthSQL.TabStop = true;
			radioAuthSQL.Text = "SQL Server";
			radioAuthSQL.UseVisualStyleBackColor = true;
			// 
			// radioAuthWindows
			// 
			radioAuthWindows.AutoSize = true;
			radioAuthWindows.Dock = DockStyle.Fill;
			radioAuthWindows.Location = new Point(128, 3);
			radioAuthWindows.Name = "radioAuthWindows";
			radioAuthWindows.Size = new Size(400, 24);
			radioAuthWindows.TabIndex = 1;
			radioAuthWindows.TabStop = true;
			radioAuthWindows.Text = "Windows";
			radioAuthWindows.UseVisualStyleBackColor = true;
			radioAuthWindows.CheckedChanged += radioAuthWindows_CheckedChanged;
			// 
			// btnTestConnection
			// 
			btnTestConnection.Location = new Point(18, 18);
			btnTestConnection.Name = "btnTestConnection";
			btnTestConnection.Size = new Size(126, 23);
			btnTestConnection.TabIndex = 0;
			btnTestConnection.Text = "Test connection";
			btnTestConnection.UseVisualStyleBackColor = true;
			btnTestConnection.Click += btnTestConnection_Click;
			// 
			// btnAdvanced
			// 
			btnAdvanced.Location = new Point(18, 419);
			btnAdvanced.Name = "btnAdvanced";
			btnAdvanced.Size = new Size(126, 23);
			btnAdvanced.TabIndex = 4;
			btnAdvanced.Text = "Advanced...";
			btnAdvanced.UseVisualStyleBackColor = true;
			btnAdvanced.Visible = false;
			btnAdvanced.Click += btnAdvanced_Click;
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
			panel1.TabIndex = 31;
			// 
			// btnCancel
			// 
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
			btnNext.Location = new Point(493, 18);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 2;
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
			label6.Size = new Size(235, 19);
			label6.TabIndex = 0;
			label6.Text = "Confgure MS SQL Server Connection";
			// 
			// VSMSSQLConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			CancelButton = btnCancel;
			ClientSize = new Size(661, 522);
			Controls.Add(label6);
			Controls.Add(panel1);
			Controls.Add(btnAdvanced);
			Controls.Add(groupAuth);
			Controls.Add(groupGeneral);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "VSMSSQLConnection";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "New Report";
			groupBox1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			groupGeneral.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			groupAuth.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private RadioButton radioAppConfig;
		private RadioButton radioManual;
		private Label label1;
		private TextBox txtConnStringName;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label2;
		private TextBox textBox2;
		private LinkLabel linkLabel2;
		private Label label3;
		private TextBox textBox3;
		private LinkLabel linkLabel1;
		private GroupBox groupAuth;
		private TableLayoutPanel tableLayoutPanel3;
		private RadioButton radioAuthSQL;
		private LinkLabel linkPwdParam;
		private TextBox txtPwd;
		private Label label5;
		private LinkLabel linkUserNameParam;
		private TextBox txtUserName;
		private Label label4;
		private RadioButton radioAuthWindows;
		private Button btnTestConnection;
		private Button btnAdvanced;
		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnNext;
		private Label label6;
	}
}