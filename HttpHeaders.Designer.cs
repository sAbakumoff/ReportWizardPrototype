namespace ReportWizardPrototype
{
	partial class HttpHeaders
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
			button2 = new Button();
			button1 = new Button();
			btnCancel = new Button();
			label6 = new Label();
			gridAdvancedOptions = new DataGridView();
			OptionName = new DataGridViewTextBoxColumn();
			OptionValue = new DataGridViewTextBoxColumn();
			Variable = new DataGridViewLinkColumn();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(btnCancel);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 367);
			panel1.Name = "panel1";
			panel1.Size = new Size(478, 55);
			panel1.TabIndex = 38;
			// 
			// button2
			// 
			button2.Location = new Point(305, 16);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 34;
			button2.Text = "OK";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(386, 16);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 33;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(574, 18);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 32;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 5);
			label6.Name = "label6";
			label6.Size = new Size(159, 19);
			label6.TabIndex = 37;
			label6.Text = "Configure HTTP Headers";
			// 
			// gridAdvancedOptions
			// 
			gridAdvancedOptions.BackgroundColor = SystemColors.ControlLight;
			gridAdvancedOptions.BorderStyle = BorderStyle.None;
			gridAdvancedOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridAdvancedOptions.Columns.AddRange(new DataGridViewColumn[] { OptionName, OptionValue, Variable });
			gridAdvancedOptions.Location = new Point(18, 38);
			gridAdvancedOptions.Name = "gridAdvancedOptions";
			gridAdvancedOptions.RowTemplate.Height = 25;
			gridAdvancedOptions.Size = new Size(443, 307);
			gridAdvancedOptions.TabIndex = 36;
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
			Variable.Text = "Parameter...";
			Variable.UseColumnTextForLinkValue = true;
			// 
			// HttpHeaders
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(478, 422);
			Controls.Add(panel1);
			Controls.Add(label6);
			Controls.Add(gridAdvancedOptions);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "HttpHeaders";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "HTTP Headers";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button button2;
		private Button button1;
		private Button btnCancel;
		private Label label6;
		private DataGridView gridAdvancedOptions;
		private DataGridViewTextBoxColumn OptionName;
		private DataGridViewTextBoxColumn OptionValue;
		private DataGridViewLinkColumn Variable;
	}
}