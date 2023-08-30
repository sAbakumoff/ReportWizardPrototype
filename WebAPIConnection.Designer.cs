namespace ReportWizardPrototype
{
	partial class WebAPIConnection
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
			btnTestRequest = new Button();
			btnCancel = new Button();
			btnBack = new Button();
			btnNext = new Button();
			label6 = new Label();
			groupGeneral = new GroupBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			label3 = new Label();
			txtURL = new TextBox();
			linkLabel3 = new LinkLabel();
			groupAuth = new GroupBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			linkBodyParam = new LinkLabel();
			txtBody = new TextBox();
			lblPostBody = new Label();
			radioMethodGET = new RadioButton();
			radioMethodPost = new RadioButton();
			btnHeaders = new Button();
			panel1.SuspendLayout();
			groupGeneral.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			groupAuth.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(btnTestRequest);
			panel1.Controls.Add(btnCancel);
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(btnNext);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 461);
			panel1.Name = "panel1";
			panel1.Size = new Size(661, 61);
			panel1.TabIndex = 32;
			// 
			// btnTestRequest
			// 
			btnTestRequest.Location = new Point(18, 18);
			btnTestRequest.Name = "btnTestRequest";
			btnTestRequest.Size = new Size(126, 23);
			btnTestRequest.TabIndex = 33;
			btnTestRequest.Text = "Test Request";
			btnTestRequest.UseVisualStyleBackColor = true;
			btnTestRequest.Click += btnTestRequest_Click;
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
			btnNext.Click += btnNext_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(175, 19);
			label6.TabIndex = 33;
			label6.Text = "Confgure Web API Request";
			// 
			// groupGeneral
			// 
			groupGeneral.Controls.Add(tableLayoutPanel1);
			groupGeneral.Location = new Point(18, 40);
			groupGeneral.Name = "groupGeneral";
			groupGeneral.Size = new Size(631, 55);
			groupGeneral.TabIndex = 47;
			groupGeneral.TabStop = false;
			groupGeneral.Text = "General";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Controls.Add(label3, 0, 0);
			tableLayoutPanel1.Controls.Add(txtURL, 1, 0);
			tableLayoutPanel1.Controls.Add(linkLabel3, 2, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 19);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(625, 33);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(119, 33);
			label3.TabIndex = 0;
			label3.Text = "URL:";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtURL
			// 
			txtURL.Dock = DockStyle.Fill;
			txtURL.Location = new Point(128, 3);
			txtURL.Multiline = true;
			txtURL.Name = "txtURL";
			txtURL.Size = new Size(369, 27);
			txtURL.TabIndex = 1;
			// 
			// linkLabel3
			// 
			linkLabel3.AutoSize = true;
			linkLabel3.Dock = DockStyle.Fill;
			linkLabel3.Location = new Point(503, 0);
			linkLabel3.Name = "linkLabel3";
			linkLabel3.Size = new Size(119, 33);
			linkLabel3.TabIndex = 4;
			linkLabel3.TabStop = true;
			linkLabel3.Text = "Insert parameter...";
			linkLabel3.TextAlign = ContentAlignment.MiddleLeft;
			linkLabel3.LinkClicked += linkLabel3_LinkClicked;
			// 
			// groupAuth
			// 
			groupAuth.Controls.Add(tableLayoutPanel3);
			groupAuth.Location = new Point(18, 115);
			groupAuth.Name = "groupAuth";
			groupAuth.Size = new Size(631, 159);
			groupAuth.TabIndex = 48;
			groupAuth.TabStop = false;
			groupAuth.Text = "Request method";
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.Controls.Add(linkBodyParam, 2, 1);
			tableLayoutPanel3.Controls.Add(txtBody, 1, 1);
			tableLayoutPanel3.Controls.Add(lblPostBody, 0, 1);
			tableLayoutPanel3.Controls.Add(radioMethodGET, 0, 0);
			tableLayoutPanel3.Controls.Add(radioMethodPost, 1, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 19);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 3;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			tableLayoutPanel3.Size = new Size(625, 137);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// linkBodyParam
			// 
			linkBodyParam.AutoSize = true;
			linkBodyParam.Dock = DockStyle.Fill;
			linkBodyParam.Enabled = false;
			linkBodyParam.Location = new Point(503, 27);
			linkBodyParam.Name = "linkBodyParam";
			linkBodyParam.Size = new Size(119, 54);
			linkBodyParam.TabIndex = 5;
			linkBodyParam.TabStop = true;
			linkBodyParam.Text = "Insert Parameter...";
			linkBodyParam.TextAlign = ContentAlignment.MiddleLeft;
			linkBodyParam.LinkClicked += linkBodyParam_LinkClicked;
			// 
			// txtBody
			// 
			txtBody.Dock = DockStyle.Fill;
			txtBody.Enabled = false;
			txtBody.Location = new Point(128, 30);
			txtBody.Multiline = true;
			txtBody.Name = "txtBody";
			tableLayoutPanel3.SetRowSpan(txtBody, 2);
			txtBody.Size = new Size(369, 104);
			txtBody.TabIndex = 4;
			// 
			// lblPostBody
			// 
			lblPostBody.AutoSize = true;
			lblPostBody.Dock = DockStyle.Fill;
			lblPostBody.Enabled = false;
			lblPostBody.Location = new Point(3, 27);
			lblPostBody.Name = "lblPostBody";
			lblPostBody.Size = new Size(119, 54);
			lblPostBody.TabIndex = 2;
			lblPostBody.Text = "POST Body:";
			lblPostBody.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// radioMethodGET
			// 
			radioMethodGET.AutoSize = true;
			radioMethodGET.Checked = true;
			radioMethodGET.Dock = DockStyle.Fill;
			radioMethodGET.Location = new Point(3, 3);
			radioMethodGET.Name = "radioMethodGET";
			radioMethodGET.Size = new Size(119, 21);
			radioMethodGET.TabIndex = 2;
			radioMethodGET.TabStop = true;
			radioMethodGET.Text = "GET";
			radioMethodGET.UseVisualStyleBackColor = true;
			radioMethodGET.CheckedChanged += OnMethodChanged;
			// 
			// radioMethodPost
			// 
			radioMethodPost.AutoSize = true;
			radioMethodPost.Dock = DockStyle.Fill;
			radioMethodPost.Location = new Point(128, 3);
			radioMethodPost.Name = "radioMethodPost";
			radioMethodPost.Size = new Size(369, 21);
			radioMethodPost.TabIndex = 3;
			radioMethodPost.TabStop = true;
			radioMethodPost.Text = "POST";
			radioMethodPost.UseVisualStyleBackColor = true;
			// 
			// btnHeaders
			// 
			btnHeaders.Location = new Point(18, 294);
			btnHeaders.Name = "btnHeaders";
			btnHeaders.Size = new Size(126, 23);
			btnHeaders.TabIndex = 5;
			btnHeaders.Text = "HTTP Headers...";
			btnHeaders.UseVisualStyleBackColor = true;
			btnHeaders.Click += btnHeaders_Click;
			// 
			// WebAPIConnection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(btnHeaders);
			Controls.Add(groupAuth);
			Controls.Add(groupGeneral);
			Controls.Add(label6);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "WebAPIConnection";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupGeneral.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			groupAuth.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnNext;
		private Label label6;
		private GroupBox groupGeneral;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label3;
		private TextBox txtURL;
		private LinkLabel linkLabel3;
		private GroupBox groupAuth;
		private TableLayoutPanel tableLayoutPanel3;
		private LinkLabel linkBodyParam;
		private TextBox txtBody;
		private Label lblPostBody;
		private RadioButton radioMethodGET;
		private RadioButton radioMethodPost;
		private Button btnHeaders;
		private Button btnTestRequest;
	}
}