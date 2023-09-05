namespace ReportWizardPrototype
{
	public partial class WebAPIDataSets : Form
	{
		private int _counter = 2;
		public event EventHandler OnBackClicked;
		public WebAPIDataSets()
		{
			InitializeComponent();
			this.listBox1.SelectedIndex = 0;
			treeView1.ExpandAll();
			TreeNode[] nodes = treeView1.Nodes.Find("Node2", true);
			if (nodes.Length > 0)
			{
				treeView1.SelectedNode = nodes[0];
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			// var connDialog = new WebAPIConnection();
			// connDialog.ShowDialog(this);
			if(this.OnBackClicked != null)
			{
				OnBackClicked(this, EventArgs.Empty);
			}
			Close();
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Add($"Query{_counter++}");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex > -1)
			{
				this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button2.Enabled = this.listBox1.SelectedItems.Count > 0;
			if (this.listBox1.SelectedItems.Count > 0)
			{
				this.textBox2.Text = this.listBox1.SelectedItems[0].ToString();
			}
		}
	}
}
