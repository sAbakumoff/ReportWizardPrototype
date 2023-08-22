namespace ReportWizardPrototype
{
	partial class MSSQLAdvancedProps
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
			gridAdvancedOptions = new DataGridView();
			OptionName = new DataGridViewTextBoxColumn();
			OptionValue = new DataGridViewTextBoxColumn();
			Variable = new DataGridViewLinkColumn();
			label6 = new Label();
			panel1 = new Panel();
			button2 = new Button();
			button1 = new Button();
			btnCancel = new Button();
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// gridAdvancedOptions
			// 
			gridAdvancedOptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridAdvancedOptions.Columns.AddRange(new DataGridViewColumn[] { OptionName, OptionValue, Variable });
			gridAdvancedOptions.Location = new Point(18, 42);
			gridAdvancedOptions.Name = "gridAdvancedOptions";
			gridAdvancedOptions.RowTemplate.Height = 25;
			gridAdvancedOptions.Size = new Size(443, 307);
			gridAdvancedOptions.TabIndex = 20;
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
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(196, 19);
			label6.TabIndex = 34;
			label6.Text = "Configure Connection Options";
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
			panel1.TabIndex = 35;
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
			// MSSQLAdvancedProps
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
			Name = "MSSQLAdvancedProps";
			StartPosition = FormStartPosition.CenterParent;
			Text = "MS SQL Connection";
			((System.ComponentModel.ISupportInitialize)gridAdvancedOptions).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView gridAdvancedOptions;
		private Label label6;
		private Panel panel1;
		private Button button2;
		private Button button1;
		private Button btnCancel;
		private DataGridViewTextBoxColumn OptionName;
		private DataGridViewTextBoxColumn OptionValue;
		private DataGridViewLinkColumn Variable;
	}
}