namespace ReportWizardPrototype
{
	public partial class XMLConnection : Form
	{
		public event EventHandler OnNextClicked;
		public XMLConnection()
		{
			InitializeComponent();
			linkPath.Click += (sender, args) =>
			{
				OpenParamDialog();
			};
			linkLabel1.Click += (sender, args) =>
			{
				OpenParamDialog();
			};
		}
		private void OpenParamDialog()
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
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

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Multiselect = false,
			};
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.OK)
			{
				txtPath.Text = dialog.FileName;
			}
		}
	}
}
