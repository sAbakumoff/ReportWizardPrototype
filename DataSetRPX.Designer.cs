namespace ReportWizardPrototype
{
	partial class DataSetRPX
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
			btnValidate = new Button();
			linkLabel1 = new LinkLabel();
			textBox1 = new TextBox();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			label6 = new Label();
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
			panel1.TabIndex = 33;
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
			btnNext.Text = "Finish >>";
			btnNext.UseVisualStyleBackColor = true;
			// 
			// btnValidate
			// 
			btnValidate.Location = new Point(574, 337);
			btnValidate.Name = "btnValidate";
			btnValidate.Size = new Size(75, 23);
			btnValidate.TabIndex = 48;
			btnValidate.Text = "Validate";
			btnValidate.UseVisualStyleBackColor = true;
			btnValidate.Click += btnValidate_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(18, 337);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(102, 15);
			linkLabel1.TabIndex = 47;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Insert Parameter...";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(18, 66);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(631, 256);
			textBox1.TabIndex = 46;
			textBox1.Text = "Select * from Products";
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(70, 41);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(116, 19);
			radioButton2.TabIndex = 45;
			radioButton2.TabStop = true;
			radioButton2.Text = "Stored Procedure";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(18, 41);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(46, 19);
			radioButton1.TabIndex = 44;
			radioButton1.TabStop = true;
			radioButton1.Text = "Text";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(203, 19);
			label6.TabIndex = 49;
			label6.Text = "Confgure MS SQL Server Query";
			// 
			// DataSetRPX
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(label6);
			Controls.Add(btnValidate);
			Controls.Add(linkLabel1);
			Controls.Add(textBox1);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DataSetRPX";
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
		private Button btnValidate;
		private LinkLabel linkLabel1;
		private TextBox textBox1;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Label label6;
	}
}