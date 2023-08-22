using System.DirectoryServices.ActiveDirectory;

namespace ReportWizardPrototype.VSUI
{
	public partial class VSMSSQLConnection : Form
	{
		private bool _connectionError;
		public VSMSSQLConnection()
		{
			InitializeComponent();
		}

		public VSMSSQLConnection(bool connectionError = false)
		{
			InitializeComponent();
			_connectionError = connectionError;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			groupAuth.Enabled = groupGeneral.Enabled = btnAdvanced.Enabled = radioManual.Checked;
			txtConnStringName.Enabled = radioAppConfig.Checked;
		}

		private void radioAuthWindows_CheckedChanged(object sender, EventArgs e)
		{
			txtPwd.Enabled = txtUserName.Enabled = linkPwdParam.Enabled = linkUserNameParam.Enabled = radioAuthSQL.Checked;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			var datasourceType = new DataSourceType();
			datasourceType.ShowDialog();
			this.Close();
		}

		private async void btnTestConnection_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			this.Cursor = Cursors.AppStarting;

			// Simulate some asynchronous work
			bool error = await ConnectionRoutine();

			// Restore the cursor and re-enable the UI
			this.Cursor = Cursors.Default;
			this.Enabled = true;
			if (error)
			{
				var errorForm = new ErrorForm();
				errorForm.ShowDialog(this);
			}
			else
			{
				MessageBox.Show("Connection created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private async Task<bool> ConnectionRoutine()
		{
			await Task.Delay(2000);
			return _connectionError;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnAdvanced_Click(object sender, EventArgs e)
		{
			var advancedOptions = new MSSQLAdvancedProps();
			advancedOptions.ShowDialog(this);
		}
	}
}
