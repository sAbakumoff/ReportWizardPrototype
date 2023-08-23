using ReportWizardPrototype.VSUI;
using System.ComponentModel;

namespace ReportWizardPrototype
{
	public partial class DataSourceType : Form
	{
		public DataSourceType()
		{
			InitializeComponent();
			this.groupBox2.Visible = PrototypeSettings.VSNETUI;

		}


		private void btnMSSQLServer_Click(object sender, EventArgs e)
		{
			this.Hide();
			var msSqlConnDialog = new VSMSSQLConnection();
			msSqlConnDialog.Show();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
