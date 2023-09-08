namespace ReportWizardPrototype
{
	public partial class ObjectDataSets : Form
	{
		public event EventHandler? OnBackClicked;
		public ObjectDataSets()
		{
			InitializeComponent();
			this.Shown += (sender, args) =>
			{
				treeView1.Select();
				treeView1.ExpandAll();
				treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
				treeView1.Nodes[0].EnsureVisible();
			};
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			// var connDialog = new WebAPIConnection();
			// connDialog.ShowDialog(this);
			if (this.OnBackClicked != null)
			{
				OnBackClicked(this, EventArgs.Empty);
			}
			// Close();
		}

		private void OnNext(object sender, EventArgs e)
		{
			Hide();
			var information = new InformationDlg("ReportWizardPrototype.Resources.summary_object.rtf");
			information.BackClicked += (sender, e) =>
			{
				information.Hide();
				Show();
			};
			information.ShowDialog(this);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
