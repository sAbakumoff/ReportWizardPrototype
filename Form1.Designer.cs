namespace ReportWizardPrototype
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblServerName = new Label();
			txtServerName = new TextBox();
			linkServerNameVariable = new LinkLabel();
			lblDatabase = new Label();
			txtDatabase = new TextBox();
			linkDatabaseVariable = new LinkLabel();
			btnAuthSQLServer = new RadioButton();
			btnAuthWindows = new RadioButton();
			lblUserName = new Label();
			txtUserName = new TextBox();
			linkUserNameVariable = new LinkLabel();
			lblPassword = new Label();
			txtPassword = new TextBox();
			linkPasswordVariable = new LinkLabel();
			lblType = new Label();
			btnNext = new Button();
			btnTestConnection = new Button();
			btnPrev = new Button();
			groupGeneral = new GroupBox();
			groupAuthentication = new GroupBox();
			groupConnectionOptions = new GroupBox();
			gridAdvancedOptions = new DataGridView();
			OptionName = new DataGridViewTextBoxColumn();
			OptionValue = new DataGridViewTextBoxColumn();
			Variable = new DataGridViewLinkColumn();
			groupGeneral.SuspendLayout();
			groupAuthentication.SuspendLayout();
			groupConnectionOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).BeginInit();
			SuspendLayout();
			// 
			// lblServerName
			// 
			lblServerName.AutoSize = true;
			lblServerName.FlatStyle = FlatStyle.System;
			lblServerName.Location = new Point(10, 25);
			lblServerName.Name = "lblServerName";
			lblServerName.Size = new Size(77, 15);
			lblServerName.TabIndex = 0;
			lblServerName.Text = "Server Name:";
			// 
			// txtServerName
			// 
			txtServerName.Location = new Point(125, 22);
			txtServerName.Name = "txtServerName";
			txtServerName.Size = new Size(275, 23);
			txtServerName.TabIndex = 1;
			// 
			// linkServerNameVariable
			// 
			linkServerNameVariable.AutoSize = true;
			linkServerNameVariable.Location = new Point(405, 25);
			linkServerNameVariable.Name = "linkServerNameVariable";
			linkServerNameVariable.Size = new Size(57, 15);
			linkServerNameVariable.TabIndex = 2;
			linkServerNameVariable.TabStop = true;
			linkServerNameVariable.Text = "Variable...";
			// 
			// lblDatabase
			// 
			lblDatabase.AutoSize = true;
			lblDatabase.FlatStyle = FlatStyle.System;
			lblDatabase.Location = new Point(10, 68);
			lblDatabase.Name = "lblDatabase";
			lblDatabase.Size = new Size(58, 15);
			lblDatabase.TabIndex = 3;
			lblDatabase.Text = "Database:";
			// 
			// txtDatabase
			// 
			txtDatabase.Location = new Point(125, 65);
			txtDatabase.Name = "txtDatabase";
			txtDatabase.Size = new Size(275, 23);
			txtDatabase.TabIndex = 4;
			// 
			// linkDatabaseVariable
			// 
			linkDatabaseVariable.AutoSize = true;
			linkDatabaseVariable.Location = new Point(405, 68);
			linkDatabaseVariable.Name = "linkDatabaseVariable";
			linkDatabaseVariable.Size = new Size(57, 15);
			linkDatabaseVariable.TabIndex = 5;
			linkDatabaseVariable.TabStop = true;
			linkDatabaseVariable.Text = "Variable...";
			// 
			// btnAuthSQLServer
			// 
			btnAuthSQLServer.AutoSize = true;
			btnAuthSQLServer.Checked = true;
			btnAuthSQLServer.FlatStyle = FlatStyle.System;
			btnAuthSQLServer.Location = new Point(125, 22);
			btnAuthSQLServer.Name = "btnAuthSQLServer";
			btnAuthSQLServer.Size = new Size(87, 20);
			btnAuthSQLServer.TabIndex = 6;
			btnAuthSQLServer.TabStop = true;
			btnAuthSQLServer.Text = "SQL Server";
			btnAuthSQLServer.UseVisualStyleBackColor = true;
			// 
			// btnAuthWindows
			// 
			btnAuthWindows.AutoSize = true;
			btnAuthWindows.FlatStyle = FlatStyle.System;
			btnAuthWindows.Location = new Point(230, 22);
			btnAuthWindows.Name = "btnAuthWindows";
			btnAuthWindows.Size = new Size(80, 20);
			btnAuthWindows.TabIndex = 7;
			btnAuthWindows.Text = "Windows";
			btnAuthWindows.UseVisualStyleBackColor = true;
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.FlatStyle = FlatStyle.System;
			lblUserName.Location = new Point(10, 65);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(68, 15);
			lblUserName.TabIndex = 9;
			lblUserName.Text = "User Name:";
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(125, 62);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(275, 23);
			txtUserName.TabIndex = 10;
			// 
			// linkUserNameVariable
			// 
			linkUserNameVariable.AutoSize = true;
			linkUserNameVariable.Location = new Point(405, 65);
			linkUserNameVariable.Name = "linkUserNameVariable";
			linkUserNameVariable.Size = new Size(57, 15);
			linkUserNameVariable.TabIndex = 11;
			linkUserNameVariable.TabStop = true;
			linkUserNameVariable.Text = "Variable...";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.FlatStyle = FlatStyle.System;
			lblPassword.Location = new Point(10, 108);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(60, 15);
			lblPassword.TabIndex = 12;
			lblPassword.Text = "Password:";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(125, 105);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(275, 23);
			txtPassword.TabIndex = 13;
			// 
			// linkPasswordVariable
			// 
			linkPasswordVariable.AutoSize = true;
			linkPasswordVariable.Location = new Point(405, 108);
			linkPasswordVariable.Name = "linkPasswordVariable";
			linkPasswordVariable.Size = new Size(57, 15);
			linkPasswordVariable.TabIndex = 14;
			linkPasswordVariable.TabStop = true;
			linkPasswordVariable.Text = "Variable...";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.FlatStyle = FlatStyle.System;
			lblType.Location = new Point(10, 25);
			lblType.Name = "lblType";
			lblType.Size = new Size(34, 15);
			lblType.TabIndex = 16;
			lblType.Text = "Type:";
			lblType.Click += label7_Click;
			// 
			// btnNext
			// 
			btnNext.FlatStyle = FlatStyle.System;
			btnNext.Location = new Point(404, 505);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(75, 23);
			btnNext.TabIndex = 19;
			btnNext.Text = "Next";
			btnNext.UseVisualStyleBackColor = true;
			// 
			// btnTestConnection
			// 
			btnTestConnection.Enabled = false;
			btnTestConnection.FlatStyle = FlatStyle.System;
			btnTestConnection.Location = new Point(12, 505);
			btnTestConnection.Name = "btnTestConnection";
			btnTestConnection.Size = new Size(124, 23);
			btnTestConnection.TabIndex = 20;
			btnTestConnection.Text = "Test Connection";
			btnTestConnection.UseVisualStyleBackColor = true;
			// 
			// btnPrev
			// 
			btnPrev.FlatStyle = FlatStyle.System;
			btnPrev.Location = new Point(323, 505);
			btnPrev.Name = "btnPrev";
			btnPrev.Size = new Size(75, 23);
			btnPrev.TabIndex = 21;
			btnPrev.Text = "Previous";
			btnPrev.UseVisualStyleBackColor = true;
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(txtServerName);
			groupGeneral.Controls.Add(lblServerName);
			groupGeneral.Controls.Add(linkServerNameVariable);
			groupGeneral.Controls.Add(lblDatabase);
			groupGeneral.Controls.Add(txtDatabase);
			groupGeneral.Controls.Add(linkDatabaseVariable);
			groupGeneral.FlatStyle = FlatStyle.System;
			groupGeneral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			groupGeneral.Location = new Point(9, 12);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(470, 103);
			groupGeneral.TabIndex = 22;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			// 
			// groupAuthentication
			// 
			groupAuthentication.Controls.Add(btnAuthSQLServer);
			groupAuthentication.Controls.Add(btnAuthWindows);
			groupAuthentication.Controls.Add(lblUserName);
			groupAuthentication.Controls.Add(txtUserName);
			groupAuthentication.Controls.Add(linkUserNameVariable);
			groupAuthentication.Controls.Add(lblPassword);
			groupAuthentication.Controls.Add(lblType);
			groupAuthentication.Controls.Add(txtPassword);
			groupAuthentication.Controls.Add(linkPasswordVariable);
			groupAuthentication.FlatStyle = FlatStyle.System;
			groupAuthentication.Location = new Point(9, 135);
			groupAuthentication.Name = "groupAuthentication";
			groupAuthentication.Size = new Size(470, 145);
			groupAuthentication.TabIndex = 23;
			groupAuthentication.TabStop = false;
			groupAuthentication.Text = "Authentication";
			// 
			// groupConnectionOptions
			// 
			groupConnectionOptions.Controls.Add(gridAdvancedOptions);
			groupConnectionOptions.Location = new Point(12, 300);
			groupConnectionOptions.Name = "groupConnectionOptions";
			groupConnectionOptions.Size = new Size(467, 187);
			groupConnectionOptions.TabIndex = 24;
			groupConnectionOptions.TabStop = false;
			groupConnectionOptions.Text = "Connection Options";
			// 
			// gridAdvancedOptions
			// 
			gridAdvancedOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridAdvancedOptions.Columns.AddRange(new DataGridViewColumn[] { OptionName, OptionValue, Variable });
			gridAdvancedOptions.Location = new Point(10, 25);
			gridAdvancedOptions.Name = "gridAdvancedOptions";
			gridAdvancedOptions.RowTemplate.Height = 25;
			gridAdvancedOptions.Size = new Size(449, 150);
			gridAdvancedOptions.TabIndex = 19;
			// 
			// OptionName
			// 
			OptionName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			OptionName.HeaderText = "Name";
			OptionName.Name = "OptionName";
			// 
			// OptionValue
			// 
			OptionValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			OptionValue.HeaderText = "Value";
			OptionValue.Name = "OptionValue";
			// 
			// Variable
			// 
			Variable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Variable.HeaderText = "";
			Variable.Name = "Variable";
			Variable.ReadOnly = true;
			Variable.Resizable = DataGridViewTriState.True;
			Variable.Text = "Variable...";
			Variable.UseColumnTextForLinkValue = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(661, 541);
			Controls.Add(groupConnectionOptions);
			Controls.Add(groupAuthentication);
			Controls.Add(groupGeneral);
			Controls.Add(btnPrev);
			Controls.Add(btnTestConnection);
			Controls.Add(btnNext);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			ShowInTaskbar = false;
			Text = "MS SQL Sever Connection";
			groupGeneral.ResumeLayout(false);
			groupGeneral.PerformLayout();
			groupAuthentication.ResumeLayout(false);
			groupAuthentication.PerformLayout();
			groupConnectionOptions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label lblServerName;
		private TextBox txtServerName;
		private LinkLabel linkServerNameVariable;
		private Label lblDatabase;
		private TextBox txtDatabase;
		private LinkLabel linkDatabaseVariable;
		private RadioButton btnAuthSQLServer;
		private RadioButton btnAuthWindows;
		private Label lblUserName;
		private TextBox txtUserName;
		private LinkLabel linkUserNameVariable;
		private Label lblPassword;
		private TextBox txtPassword;
		private LinkLabel linkPasswordVariable;
		private Label lblType;
		private Button btnNext;
		private Button btnTestConnection;
		private Button btnPrev;
		private GroupBox groupGeneral;
		private GroupBox groupAuthentication;
		private GroupBox groupConnectionOptions;
		private DataGridView gridAdvancedOptions;
		private DataGridViewTextBoxColumn OptionName;
		private DataGridViewTextBoxColumn OptionValue;
		private DataGridViewLinkColumn Variable;
	}
}