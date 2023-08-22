using ReportWizardPrototype.VSUI;
using System.ComponentModel;

namespace ReportWizardPrototype
{
	public partial class DataSourceType : Form
	{
		private bool _connectionError;
		public DataSourceType()
		{
			InitializeComponent();

		}

		public DataSourceType(bool vsNETUI = true, bool connectionError = false)
		{
			InitializeComponent();
			this.groupBox2.Visible = vsNETUI;
			this._connectionError = connectionError;
		}


		private void btnMSSQLServer_Click(object sender, EventArgs e)
		{
			this.Hide();
			var msSqlConnDialog = new VSMSSQLConnection(_connectionError);
			msSqlConnDialog.Show();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
