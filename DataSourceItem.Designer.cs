namespace ReportWizardPrototype
{
	partial class DataSourceItem
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
			_titleLabel = new Label();
			_iconBox = new PictureBox();
			((System.ComponentModel.ISupportInitialize)_iconBox).BeginInit();
			SuspendLayout();
			// 
			// _titleLabel
			// 
			_titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			_titleLabel.AutoSize = true;
			_titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			_titleLabel.Location = new Point(48, 15);
			_titleLabel.Margin = new Padding(4, 0, 4, 0);
			_titleLabel.Name = "_titleLabel";
			_titleLabel.Size = new Size(29, 15);
			_titleLabel.TabIndex = 4;
			_titleLabel.Text = "Title";
			// 
			// _iconBox
			// 
			_iconBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			_iconBox.Location = new Point(20, 10);
			_iconBox.Margin = new Padding(4, 3, 4, 3);
			_iconBox.MaximumSize = new Size(37, 37);
			_iconBox.Name = "_iconBox";
			_iconBox.Size = new Size(24, 24);
			_iconBox.SizeMode = PictureBoxSizeMode.CenterImage;
			_iconBox.TabIndex = 3;
			_iconBox.TabStop = false;
			// 
			// DataSourceItem
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(_titleLabel);
			Controls.Add(_iconBox);
			Name = "DataSourceItem";
			Size = new Size(267, 44);
			((System.ComponentModel.ISupportInitialize)_iconBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label _titleLabel;
		private PictureBox _iconBox;
	}
}
