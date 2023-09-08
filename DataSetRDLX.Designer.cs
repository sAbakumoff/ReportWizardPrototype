namespace ReportWizardPrototype
{
	partial class DataSetRDLX
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
			listBox1 = new ListBox();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			textBox1 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			linkLabel1 = new LinkLabel();
			label1 = new Label();
			textBox2 = new TextBox();
			btnValidate = new Button();
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
			btnCancel.Click += btnCancel_Click;
			// 
			// btnBack
			// 
			btnBack.Location = new Point(412, 18);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(75, 23);
			btnBack.TabIndex = 31;
			btnBack.Text = "< Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
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
			label6.Size = new Size(212, 19);
			label6.TabIndex = 33;
			label6.Text = "Confgure MS SQL Server Queries";
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "Query1" });
			listBox1.Location = new Point(28, 39);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(202, 334);
			listBox1.TabIndex = 34;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(251, 82);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(46, 19);
			radioButton1.TabIndex = 35;
			radioButton1.TabStop = true;
			radioButton1.Text = "Text";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(315, 82);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(116, 19);
			radioButton2.TabIndex = 36;
			radioButton2.TabStop = true;
			radioButton2.Text = "Stored Procedure";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(251, 117);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(398, 256);
			textBox1.TabIndex = 37;
			textBox1.Text = "Select * from Products";
			// 
			// button1
			// 
			button1.Location = new Point(28, 379);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 38;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(109, 379);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 39;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(251, 383);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(102, 15);
			linkLabel1.TabIndex = 40;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Insert Parameter...";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(251, 39);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 41;
			label1.Text = "Name:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(299, 36);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(350, 23);
			textBox2.TabIndex = 42;
			textBox2.Text = "Query1";
			// 
			// btnValidate
			// 
			btnValidate.Location = new Point(574, 383);
			btnValidate.Name = "btnValidate";
			btnValidate.Size = new Size(75, 23);
			btnValidate.TabIndex = 43;
			btnValidate.Text = "Validate";
			btnValidate.UseVisualStyleBackColor = true;
			btnValidate.Click += btnValidate_Click;
			// 
			// DataSetRDLX
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(btnValidate);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(linkLabel1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(listBox1);
			Controls.Add(label6);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DataSetRDLX";
			ShowIcon = false;
			ShowInTaskbar = false;
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
		private ListBox listBox1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private TextBox textBox1;
		private Button button1;
		private Button button2;
		private LinkLabel linkLabel1;
		private Label label1;
		private TextBox textBox2;
		private Button btnValidate;
	}
}