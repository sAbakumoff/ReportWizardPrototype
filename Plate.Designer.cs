namespace ReportWizardPrototype
{
	partial class Plate
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			_iconBox = new PictureBox();
			_titleLabel = new Label();
			_descriptionLabel = new Label();
			((System.ComponentModel.ISupportInitialize)_iconBox).BeginInit();
			SuspendLayout();
			// 
			// _iconBox
			// 
			_iconBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			_iconBox.Location = new Point(8, 8);
			_iconBox.Margin = new Padding(4, 3, 4, 3);
			_iconBox.MaximumSize = new Size(37, 37);
			_iconBox.Name = "_iconBox";
			_iconBox.Size = new Size(37, 37);
			_iconBox.SizeMode = PictureBoxSizeMode.CenterImage;
			_iconBox.TabIndex = 0;
			_iconBox.TabStop = false;
			// 
			// _titleLabel
			// 
			_titleLabel.AutoSize = true;
			_titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			_titleLabel.Location = new Point(48, 8);
			_titleLabel.Margin = new Padding(4, 0, 4, 0);
			_titleLabel.Name = "_titleLabel";
			_titleLabel.Size = new Size(32, 15);
			_titleLabel.TabIndex = 1;
			_titleLabel.Text = "Title";
			// 
			// _descriptionLabel
			// 
			_descriptionLabel.AutoSize = true;
			_descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			_descriptionLabel.Location = new Point(48, 29);
			_descriptionLabel.Margin = new Padding(4, 0, 4, 0);
			_descriptionLabel.Name = "_descriptionLabel";
			_descriptionLabel.Size = new Size(67, 15);
			_descriptionLabel.TabIndex = 2;
			_descriptionLabel.Text = "Description";
			// 
			// Plate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(_descriptionLabel);
			Controls.Add(_titleLabel);
			Controls.Add(_iconBox);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Plate";
			Size = new Size(467, 52);
			((System.ComponentModel.ISupportInitialize)_iconBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox _iconBox;
		private Label _titleLabel;
		private Label _descriptionLabel;
	}
}
