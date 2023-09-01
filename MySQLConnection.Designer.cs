namespace ReportWizardPrototype
{
	partial class MySQLConnection
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
			groupAuth = new GroupBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			linkPwdParam = new LinkLabel();
			txtPwd = new TextBox();
			label5 = new Label();
			linkUserNameParam = new LinkLabel();
			txtUserName = new TextBox();
			label4 = new Label();
			groupGeneral = new GroupBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			linkLabel3 = new LinkLabel();
			txtPort = new TextBox();
			label7 = new Label();
			linkLabel2 = new LinkLabel();
			label2 = new Label();
			textBox2 = new TextBox();
			label3 = new Label();
			textBox3 = new TextBox();
			linkLabel1 = new LinkLabel();
			groupBox1 = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			radioAppConfig = new RadioButton();
			radioManual = new RadioButton();
			label1 = new Label();
			txtConnStringName = new TextBox();
			lblTitle = new Label();
			panel1.SuspendLayout();
			groupAuth.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
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
			panel1.Controls.Add(btnTestConnection);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 461);
			panel1.Name = "panel1";
			panel1.Size = new Size(661, 61);
			panel1.TabIndex = 32;
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
			// btnBack
			// 
			btnBack.Location = new Point(412, 18);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(75, 23);
			btnBack.TabIndex = 31;
			btnBack.Text = "< Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += OnBack;
			// 
			// btnNext
			// 
			btnNext.Location = new Point(493, 18);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 30;
			btnNext.Text = "Next >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += OnNext;
			// 
			// btnTestConnection
			// 
			btnTestConnection.Location = new Point(18, 18);
			btnTestConnection.Name = "btnTestConnection";
			btnTestConnection.Size = new Size(126, 23);
			btnTestConnection.TabIndex = 26;
			btnTestConnection.Text = "Test connection";
			btnTestConnection.UseVisualStyleBackColor = true;
			btnTestConnection.Click += OnTestConnection;
			// 
			// groupAuth
			// 
			groupAuth.Controls.Add(tableLayoutPanel3);
			groupAuth.Location = new Point(18, 323);
			groupAuth.Name = "groupAuth";
			groupAuth.Size = new Size(631, 90);
			groupAuth.TabIndex = 35;
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
			tableLayoutPanel3.Controls.Add(linkPwdParam, 2, 1);
			tableLayoutPanel3.Controls.Add(txtPwd, 1, 1);
			tableLayoutPanel3.Controls.Add(label5, 0, 1);
			tableLayoutPanel3.Controls.Add(linkUserNameParam, 2, 0);
			tableLayoutPanel3.Controls.Add(txtUserName, 1, 0);
			tableLayoutPanel3.Controls.Add(label4, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 19);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
			tableLayoutPanel3.Size = new Size(625, 68);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// linkPwdParam
			// 
			linkPwdParam.AutoSize = true;
			linkPwdParam.Dock = DockStyle.Fill;
			linkPwdParam.Location = new Point(534, 33);
			linkPwdParam.Name = "linkPwdParam";
			linkPwdParam.Size = new Size(88, 35);
			linkPwdParam.TabIndex = 8;
			linkPwdParam.TabStop = true;
			linkPwdParam.Text = "Parameter...";
			linkPwdParam.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPwd
			// 
			txtPwd.Dock = DockStyle.Fill;
			txtPwd.Location = new Point(128, 36);
			txtPwd.Multiline = true;
			txtPwd.Name = "txtPwd";
			txtPwd.Size = new Size(400, 29);
			txtPwd.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 33);
			label5.Name = "label5";
			label5.Size = new Size(119, 35);
			label5.TabIndex = 6;
			label5.Text = "Password:";
			label5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// linkUserNameParam
			// 
			linkUserNameParam.AutoSize = true;
			linkUserNameParam.Dock = DockStyle.Fill;
			linkUserNameParam.Location = new Point(534, 0);
			linkUserNameParam.Name = "linkUserNameParam";
			linkUserNameParam.Size = new Size(88, 33);
			linkUserNameParam.TabIndex = 5;
			linkUserNameParam.TabStop = true;
			linkUserNameParam.Text = "Parameter...";
			linkUserNameParam.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtUserName
			// 
			txtUserName.Dock = DockStyle.Fill;
			txtUserName.Location = new Point(128, 3);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(400, 27);
			txtUserName.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(119, 33);
			label4.TabIndex = 2;
			label4.Text = "User Name:";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel2);
			groupGeneral.Location = new Point(18, 190);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 113);
			groupGeneral.TabIndex = 34;
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
			tableLayoutPanel2.Controls.Add(linkLabel3, 2, 2);
			tableLayoutPanel2.Controls.Add(txtPort, 1, 2);
			tableLayoutPanel2.Controls.Add(label7, 0, 2);
			tableLayoutPanel2.Controls.Add(linkLabel2, 2, 1);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(textBox2, 1, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 1);
			tableLayoutPanel2.Controls.Add(textBox3, 1, 1);
			tableLayoutPanel2.Controls.Add(linkLabel1, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 19);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel2.Size = new Size(625, 91);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// linkLabel3
			// 
			linkLabel3.AutoSize = true;
			linkLabel3.Dock = DockStyle.Fill;
			linkLabel3.Location = new Point(534, 60);
			linkLabel3.Name = "linkLabel3";
			linkLabel3.Size = new Size(88, 31);
			linkLabel3.TabIndex = 8;
			linkLabel3.TabStop = true;
			linkLabel3.Text = "Parameter...";
			linkLabel3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtPort
			// 
			txtPort.Dock = DockStyle.Fill;
			txtPort.Location = new Point(128, 63);
			txtPort.Multiline = true;
			txtPort.Name = "txtPort";
			txtPort.Size = new Size(400, 25);
			txtPort.TabIndex = 7;
			txtPort.Text = "3306";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(3, 60);
			label7.Name = "label7";
			label7.Size = new Size(119, 31);
			label7.TabIndex = 6;
			label7.Text = "Port:";
			label7.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Dock = DockStyle.Fill;
			linkLabel2.Location = new Point(534, 30);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(88, 30);
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
			label2.Size = new Size(119, 30);
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
			textBox2.Size = new Size(400, 24);
			textBox2.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 30);
			label3.Name = "label3";
			label3.Size = new Size(119, 30);
			label3.TabIndex = 2;
			label3.Text = "Database:";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			textBox3.Dock = DockStyle.Fill;
			textBox3.Location = new Point(128, 33);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(400, 24);
			textBox3.TabIndex = 3;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Dock = DockStyle.Fill;
			linkLabel1.Location = new Point(534, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(88, 30);
			linkLabel1.TabIndex = 4;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Parameter...";
			linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tableLayoutPanel1);
			groupBox1.Location = new Point(18, 48);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(631, 122);
			groupBox1.TabIndex = 33;
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
			radioAppConfig.CheckedChanged += OnSettingMethodChanged;
			// 
			// radioManual
			// 
			radioManual.AutoSize = true;
			tableLayoutPanel1.SetColumnSpan(radioManual, 2);
			radioManual.Dock = DockStyle.Fill;
			radioManual.Location = new Point(3, 69);
			radioManual.Name = "radioManual";
			radioManual.Size = new Size(619, 28);
			radioManual.TabIndex = 1;
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
			label1.TabIndex = 2;
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
			txtConnStringName.TabIndex = 3;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(231, 19);
			lblTitle.TabIndex = 36;
			lblTitle.Text = "Confgure MySQL Server Connection";
			// 
			// MySQLConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(lblTitle);
			Controls.Add(groupAuth);
			Controls.Add(groupGeneral);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MySQLConnection";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupAuth.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
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
		private Button btnTestConnection;
		private GroupBox groupAuth;
		private TableLayoutPanel tableLayoutPanel3;
		private LinkLabel linkPwdParam;
		private TextBox txtPwd;
		private Label label5;
		private LinkLabel linkUserNameParam;
		private TextBox txtUserName;
		private Label label4;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel2;
		private LinkLabel linkLabel2;
		private Label label2;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox3;
		private LinkLabel linkLabel1;
		private GroupBox groupBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private RadioButton radioAppConfig;
		private RadioButton radioManual;
		private Label label1;
		private TextBox txtConnStringName;
		private Label lblTitle;
		private TextBox txtPort;
		private Label label7;
		private LinkLabel linkLabel3;
	}
}