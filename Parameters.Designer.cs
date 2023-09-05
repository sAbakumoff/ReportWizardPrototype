namespace ReportWizardPrototype
{
	partial class Parameters
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
			dataGridView1 = new DataGridView();
			ParamName = new DataGridViewTextBoxColumn();
			ParamType = new DataGridViewComboBoxColumn();
			ParamValue = new DataGridViewTextBoxColumn();
			paramInputSource = new DataGridViewComboBoxColumn();
			label6 = new Label();
			panel1 = new Panel();
			button2 = new Button();
			button1 = new Button();
			btnCancel = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.BackgroundColor = SystemColors.ControlLight;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ParamName, ParamType, ParamValue, paramInputSource });
			dataGridView1.Location = new Point(18, 65);
			dataGridView1.Margin = new Padding(2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(442, 292);
			dataGridView1.TabIndex = 3;
			// 
			// ParamName
			// 
			ParamName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ParamName.HeaderText = "Name";
			ParamName.Name = "ParamName";
			// 
			// ParamType
			// 
			ParamType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ParamType.HeaderText = "Type";
			ParamType.Items.AddRange(new object[] { "String", "Date", "Boolean", "Integer", "Float" });
			ParamType.Name = "ParamType";
			ParamType.Resizable = DataGridViewTriState.True;
			ParamType.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// ParamValue
			// 
			ParamValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ParamValue.HeaderText = "Testing Value";
			ParamValue.Name = "ParamValue";
			// 
			// paramInputSource
			// 
			paramInputSource.HeaderText = "Input Source";
			paramInputSource.Items.AddRange(new object[] { "Interactive", "Programmatic" });
			paramInputSource.Name = "paramInputSource";
			paramInputSource.Resizable = DataGridViewTriState.True;
			paramInputSource.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.ControlText;
			label6.Location = new Point(18, 22);
			label6.Name = "label6";
			label6.Size = new Size(268, 19);
			label6.TabIndex = 35;
			label6.Text = "Select Existing Parameter or Add New One";
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
			panel1.TabIndex = 36;
			// 
			// button2
			// 
			button2.Location = new Point(305, 16);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 34;
			button2.Text = "OK";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// button1
			// 
			button1.Location = new Point(386, 16);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 33;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
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
			// Parameters
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(478, 422);
			Controls.Add(panel1);
			Controls.Add(label6);
			Controls.Add(dataGridView1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Parameters";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Parameters";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label label6;
		private Panel panel1;
		private Button button2;
		private Button button1;
		private Button btnCancel;
		private DataGridViewTextBoxColumn ParamName;
		private DataGridViewComboBoxColumn ParamType;
		private DataGridViewTextBoxColumn ParamValue;
		private DataGridViewComboBoxColumn paramInputSource;
	}
}