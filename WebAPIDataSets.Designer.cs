namespace ReportWizardPrototype
{
	partial class WebAPIDataSets
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
			TreeNode treeNode10 = new TreeNode("ProductName");
			TreeNode treeNode11 = new TreeNode("Unit Price");
			TreeNode treeNode12 = new TreeNode("[*]", new TreeNode[] { treeNode10, treeNode11 });
			TreeNode treeNode13 = new TreeNode("Products", new TreeNode[] { treeNode12 });
			TreeNode treeNode14 = new TreeNode("CustomerID");
			TreeNode treeNode15 = new TreeNode("CompanyName");
			TreeNode treeNode16 = new TreeNode("[*]", new TreeNode[] { treeNode14, treeNode15 });
			TreeNode treeNode17 = new TreeNode("Customers", new TreeNode[] { treeNode16 });
			TreeNode treeNode18 = new TreeNode("$", new TreeNode[] { treeNode13, treeNode17 });
			panel1 = new Panel();
			btnCancel = new Button();
			btnBack = new Button();
			btnFinish = new Button();
			label6 = new Label();
			button2 = new Button();
			button1 = new Button();
			listBox1 = new ListBox();
			textBox2 = new TextBox();
			label1 = new Label();
			treeView1 = new TreeView();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			linkLabel1 = new LinkLabel();
			panel1.SuspendLayout();
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
			// btnFinish
			// 
			btnFinish.Location = new Point(493, 18);
			btnFinish.Name = "btnFinish";
			btnFinish.Size = new Size(75, 23);
			btnFinish.TabIndex = 30;
			btnFinish.Text = "Finish >>";
			btnFinish.UseVisualStyleBackColor = true;
			btnFinish.Click += btnFinish_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(154, 19);
			label6.TabIndex = 34;
			label6.Text = "Confgure JSON Queries";
			// 
			// button2
			// 
			button2.Location = new Point(99, 385);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 42;
			button2.Text = "Delete";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(18, 385);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 41;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Items.AddRange(new object[] { "Query1" });
			listBox1.Location = new Point(18, 45);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(202, 334);
			listBox1.TabIndex = 40;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(299, 42);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(350, 23);
			textBox2.TabIndex = 47;
			textBox2.Text = "Query1";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(251, 45);
			label1.Name = "label1";
			label1.Size = new Size(42, 15);
			label1.TabIndex = 46;
			label1.Text = "Name:";
			// 
			// treeView1
			// 
			treeView1.Location = new Point(299, 80);
			treeView1.Name = "treeView1";
			treeNode10.Name = "Node3";
			treeNode10.Text = "ProductName";
			treeNode11.Name = "Node4";
			treeNode11.Text = "Unit Price";
			treeNode12.Name = "Node2";
			treeNode12.Text = "[*]";
			treeNode13.Name = "Node1";
			treeNode13.Text = "Products";
			treeNode14.Name = "Node7";
			treeNode14.Text = "CustomerID";
			treeNode15.Name = "Node8";
			treeNode15.Text = "CompanyName";
			treeNode16.Name = "Node6";
			treeNode16.Text = "[*]";
			treeNode17.Name = "Node5";
			treeNode17.Text = "Customers";
			treeNode18.Name = "Node0";
			treeNode18.Text = "$";
			treeView1.Nodes.AddRange(new TreeNode[] { treeNode18 });
			treeView1.Size = new Size(350, 270);
			treeView1.TabIndex = 48;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(251, 80);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 49;
			label2.Text = "Path:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(251, 359);
			label3.Name = "label3";
			label3.Size = new Size(42, 15);
			label3.TabIndex = 50;
			label3.Text = "Query:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(299, 356);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(350, 23);
			textBox1.TabIndex = 51;
			textBox1.Text = "$.Products.*";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(547, 393);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(102, 15);
			linkLabel1.TabIndex = 52;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Insert Parameter...";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// WebAPIDataSets
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(linkLabel1);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(treeView1);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(listBox1);
			Controls.Add(label6);
			Controls.Add(panel1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "WebAPIDataSets";
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
		private Button btnFinish;
		private Label label6;
		private Button button2;
		private Button button1;
		private ListBox listBox1;
		private TextBox textBox2;
		private Label label1;
		private TreeView treeView1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private LinkLabel linkLabel1;
	}
}