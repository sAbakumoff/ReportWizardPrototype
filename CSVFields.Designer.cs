namespace ReportWizardPrototype
{
	partial class CSVFields
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
			btnFinish = new Button();
			groupData = new GroupBox();
			dataGridView1 = new DataGridView();
			ParamName = new DataGridViewTextBoxColumn();
			ParamType = new DataGridViewComboBoxColumn();
			lblTitle = new Label();
			groupBox1 = new GroupBox();
			dataGridView2 = new DataGridView();
			Region = new DataGridViewTextBoxColumn();
			Country = new DataGridViewTextBoxColumn();
			SalesChannel = new DataGridViewTextBoxColumn();
			OrderDate = new DataGridViewTextBoxColumn();
			panel1.SuspendLayout();
			groupData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(btnCancel);
			panel1.Controls.Add(btnBack);
			panel1.Controls.Add(btnFinish);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 461);
			panel1.Name = "panel1";
			panel1.Size = new Size(661, 61);
			panel1.TabIndex = 5;
			// 
			// btnCancel
			// 
			btnCancel.FlatStyle = FlatStyle.System;
			btnCancel.Location = new Point(574, 18);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 2;
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
			btnBack.TabIndex = 0;
			btnBack.Text = "< Back";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// btnFinish
			// 
			btnFinish.FlatStyle = FlatStyle.System;
			btnFinish.Location = new Point(493, 18);
			btnFinish.Name = "btnFinish";
			btnFinish.Size = new Size(75, 23);
			btnFinish.TabIndex = 1;
			btnFinish.Text = "Finish > >";
			btnFinish.UseVisualStyleBackColor = true;
			btnFinish.Click += btnFinish_Click;
			// 
			// groupData
			// 
			groupData.Controls.Add(dataGridView1);
			groupData.Location = new Point(18, 48);
			groupData.Name = "groupData";
			groupData.Size = new Size(631, 190);
			groupData.TabIndex = 6;
			groupData.TabStop = false;
			groupData.Text = "Fields";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.BackgroundColor = SystemColors.ControlLight;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ParamName, ParamType });
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(3, 19);
			dataGridView1.Margin = new Padding(2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(625, 168);
			dataGridView1.TabIndex = 4;
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
			ParamType.Items.AddRange(new object[] { "String", "Date", "Boolean", "Integer", "Float", "Decimal", "Double", "Long" });
			ParamType.Name = "ParamType";
			ParamType.Resizable = DataGridViewTriState.True;
			ParamType.SortMode = DataGridViewColumnSortMode.Automatic;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			lblTitle.Location = new Point(18, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(166, 19);
			lblTitle.TabIndex = 7;
			lblTitle.Text = "Confgure CSV Data Fields";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dataGridView2);
			groupBox1.Location = new Point(15, 258);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(631, 175);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Preview";
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			dataGridView2.BackgroundColor = SystemColors.ControlLight;
			dataGridView2.BorderStyle = BorderStyle.None;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Region, Country, SalesChannel, OrderDate });
			dataGridView2.Dock = DockStyle.Fill;
			dataGridView2.Location = new Point(3, 19);
			dataGridView2.Margin = new Padding(2);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.RowTemplate.Height = 25;
			dataGridView2.Size = new Size(625, 153);
			dataGridView2.TabIndex = 4;
			// 
			// Region
			// 
			Region.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Region.HeaderText = "Region";
			Region.Name = "Region";
			Region.ReadOnly = true;
			// 
			// Country
			// 
			Country.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Country.HeaderText = "Country";
			Country.Name = "Country";
			Country.ReadOnly = true;
			Country.Resizable = DataGridViewTriState.True;
			// 
			// SalesChannel
			// 
			SalesChannel.HeaderText = "Sales Channel";
			SalesChannel.Name = "SalesChannel";
			SalesChannel.ReadOnly = true;
			// 
			// OrderDate
			// 
			OrderDate.HeaderText = "Order Date";
			OrderDate.Name = "OrderDate";
			OrderDate.ReadOnly = true;
			// 
			// CSVFields
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(groupBox1);
			Controls.Add(lblTitle);
			Controls.Add(groupData);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "CSVFields";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "New Report";
			panel1.ResumeLayout(false);
			groupData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Button btnCancel;
		private Button btnBack;
		private Button btnFinish;
		private GroupBox groupData;
		private Label lblTitle;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn ParamName;
		private DataGridViewComboBoxColumn ParamType;
		private GroupBox groupBox1;
		private DataGridView dataGridView2;
		private DataGridViewTextBoxColumn Region;
		private DataGridViewTextBoxColumn Country;
		private DataGridViewTextBoxColumn SalesChannel;
		private DataGridViewTextBoxColumn OrderDate;
	}
}