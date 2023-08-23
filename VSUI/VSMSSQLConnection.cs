using System.DirectoryServices.ActiveDirectory;

namespace ReportWizardPrototype.VSUI
{
	public partial class VSMSSQLConnection : Form
	{
		public VSMSSQLConnection()
		{
			InitializeComponent();
			linkLabel1.Click += OpenParamsDialog;
			linkLabel2.Click += OpenParamsDialog;
			linkUserNameParam.Click += OpenParamsDialog;
			linkPwdParam.Click += OpenParamsDialog;
			if (!PrototypeSettings.VSNETUI)
			{
				var reducedLocation = groupBox1.Height + 20;
				groupBox1.Visible = false;
				groupGeneral.Top -= reducedLocation;
				groupAuth.Top -= reducedLocation;
				btnAdvanced.Top -= reducedLocation;
				btnTestConnection.Top -= reducedLocation;
				groupAuth.Enabled = groupGeneral.Enabled = btnAdvanced.Enabled = true;
			}
		}

		private void OpenParamsDialog(object? sender, EventArgs args)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
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
			groupBox1.Enabled = btnAdvanced.Enabled = btnTestConnection.Enabled = btnNext.Enabled = btnBack.Enabled = groupGeneral.Enabled = groupAuth.Enabled = btnAdvanced.Enabled = btnTestConnection.Enabled = btnNext.Enabled = btnBack.Enabled = false;
			UseWaitCursor = true;

			// Simulate some asynchronous work
			bool error = await ConnectionRoutine();

			// Restore the cursor and re-enable the UI
			this.UseWaitCursor = false;
			groupBox1.Enabled = btnAdvanced.Enabled = btnTestConnection.Enabled = btnNext.Enabled = btnBack.Enabled = groupGeneral.Enabled = groupAuth.Enabled = btnAdvanced.Enabled = btnTestConnection.Enabled = btnNext.Enabled = btnBack.Enabled = true;
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
			return PrototypeSettings.ConnectionError;
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

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Hide();
			var datasetsDialog = new DataSetRDLX();
			datasetsDialog.ShowDialog(this);
			this.Close();
		}
	}
}
