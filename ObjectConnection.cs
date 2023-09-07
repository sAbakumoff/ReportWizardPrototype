namespace ReportWizardPrototype
{
	public partial class ObjectConnection : Form
	{
		public event EventHandler OnNextClicked;
		public ObjectConnection()
		{
			InitializeComponent();
			this.dataGridView1.Rows.Add("DataLayer", "1.0.0.0");
			this.dataGridView1.Rows.Add("Assemly A", "1.1.1.0");
			this.dataGridView1.Rows.Add("Assemly B", "1.1.1.0");
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			var datasourceType = new DataSourceType();
			datasourceType.ShowDialog();
			Close();

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Hide();
			if (OnNextClicked != null)
			{
				OnNextClicked(this, EventArgs.Empty);
			}
			// Close();
		}

	}
}
