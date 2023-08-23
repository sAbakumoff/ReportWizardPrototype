namespace ReportWizardPrototype
{
	partial class ErrorForm
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
			pictureBox1 = new PictureBox();
			lblGeneralMessage = new Label();
			btnOK = new Button();
			btnDetails = new Button();
			txtDetails = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(15, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(45, 45);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// lblGeneralMessage
			// 
			lblGeneralMessage.AutoSize = true;
			lblGeneralMessage.Location = new Point(70, 13);
			lblGeneralMessage.Name = "lblGeneralMessage";
			lblGeneralMessage.Size = new Size(297, 30);
			lblGeneralMessage.TabIndex = 1;
			lblGeneralMessage.Text = "Unable to connect to a data source. \r\nPlease verify the connection properties and credentials.";
			// 
			// btnOK
			// 
			btnOK.Location = new Point(386, 13);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnDetails
			// 
			btnDetails.Location = new Point(386, 42);
			btnDetails.Name = "btnDetails";
			btnDetails.Size = new Size(75, 23);
			btnDetails.TabIndex = 3;
			btnDetails.Text = "Details >>";
			btnDetails.UseVisualStyleBackColor = true;
			btnDetails.Click += button2_Click;
			// 
			// txtDetails
			// 
			txtDetails.Location = new Point(15, 76);
			txtDetails.Multiline = true;
			txtDetails.Name = "txtDetails";
			txtDetails.ScrollBars = ScrollBars.Vertical;
			txtDetails.Size = new Size(446, 98);
			txtDetails.TabIndex = 4;
			txtDetails.Text = "Here goes the full text of the error.";
			// 
			// ErrorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(473, 186);
			Controls.Add(txtDetails);
			Controls.Add(btnDetails);
			Controls.Add(btnOK);
			Controls.Add(lblGeneralMessage);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ErrorForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Error";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label lblGeneralMessage;
		private Button btnOK;
		private Button btnDetails;
		private TextBox txtDetails;
	}
}