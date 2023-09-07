namespace ReportWizardPrototype
{
	partial class ObjectDataSets
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
			TreeNode treeNode1 = new TreeNode("Order");
			TreeNode treeNode2 = new TreeNode("Customer");
			TreeNode treeNode3 = new TreeNode("Supplier");
			TreeNode treeNode4 = new TreeNode("Data Layer", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
			panel1 = new Panel();
			btnCancel = new Button();
			btnBack = new Button();
			btnFinish = new Button();
			label6 = new Label();
			treeView1 = new TreeView();
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
			btnFinish.Text = "Next >";
			btnFinish.UseVisualStyleBackColor = true;
			btnFinish.Click += OnNext;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(18, 9);
			label6.Name = "label6";
			label6.Size = new Size(181, 19);
			label6.TabIndex = 34;
			label6.Text = "Choose Data Classes To Use";
			// 
			// treeView1
			// 
			treeView1.Location = new Point(18, 48);
			treeView1.Name = "treeView1";
			treeNode1.Name = "Node1";
			treeNode1.Text = "Order";
			treeNode2.Name = "Node2";
			treeNode2.Text = "Customer";
			treeNode3.Name = "Node4";
			treeNode3.Text = "Supplier";
			treeNode4.Name = "Node0";
			treeNode4.Text = "Data Layer";
			treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
			treeView1.Size = new Size(631, 370);
			treeView1.TabIndex = 48;
			// 
			// ObjectDataSets
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(661, 522);
			Controls.Add(treeView1);
			Controls.Add(label6);
			Controls.Add(panel1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ObjectDataSets";
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
		private TreeView treeView1;
	}
}