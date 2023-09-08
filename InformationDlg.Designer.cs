namespace ReportWizardPrototype
{
	partial class InformationDlg
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
			infoBox = new RichTextBox();
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
			btnNext.Text = "Finish > >";
			btnNext.UseVisualStyleBackColor = true;
			btnNext.Click += btnNext_Click;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(133, 19);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Review And Confirm";
			// 
			// infoBox
			// 
			infoBox.Location = new Point(18, 48);
			infoBox.Name = "infoBox";
			infoBox.ReadOnly = true;
			infoBox.Size = new Size(631, 392);
			infoBox.TabIndex = 34;
			infoBox.Text = "";
			// 
			// InformationDlg
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(lblTitle);
			Controls.Add(panel1);
			Controls.Add(infoBox);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "InformationDlg";
			ShowIcon = false;
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
		private Label lblTitle;
		private RichTextBox infoBox;
	}
}