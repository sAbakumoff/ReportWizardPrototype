namespace ReportWizardPrototype
{
	public partial class MySQLConnection : Form
	{
		public MySQLConnection()
		{
			InitializeComponent();
			linkLabel1.Click += OpenParamsDialog;
			linkLabel2.Click += OpenParamsDialog;
			linkLabel3.Click += OpenParamsDialog;
			linkUserNameParam.Click += OpenParamsDialog;
			linkPwdParam.Click += OpenParamsDialog;
			if (!PrototypeSettings.VSNETUI)
			{
				var reducedLocation = groupBox1.Height + 20;
				groupBox1.Visible = false;
				groupGeneral.Top -= reducedLocation;
				groupAuth.Top -= reducedLocation;
				groupAuth.Visible = groupGeneral.Visible = true;
			}

		}
		private void OpenParamsDialog(object? sender, EventArgs args)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}

		private void OnNext(object sender, EventArgs e)
		{
			Hide();
			var datasetsDialog = new DataSetRDLX();
			datasetsDialog.OnBack += (sender, args) =>
			{
				Show();
			};
			datasetsDialog.ShowDialog(this);
			// Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private async Task<bool> ConnectionRoutine()
		{
			await Task.Delay(500);
			return PrototypeSettings.ConnectionError;
		}

		private async void OnTestConnection(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			foreach (Control ctrl in Controls)
			{
				if (ctrl.Name == "btnCancel")
					continue;
				ctrl.Enabled = false;
			}


			// Simulate some asynchronous work
			bool error = await ConnectionRoutine();

			// Restore the cursor and re-enable the UI
			this.UseWaitCursor = false;

			foreach (Control ctrl in Controls)
			{
				if (ctrl.Name == "btnCancel")
					continue;
				ctrl.Enabled = true;
			}

			if (error)
			{
				var errorForm = new ErrorForm();
				// errorForm.GeneralMessage = $"An error occurred while executing Web API request";
				errorForm.ShowDialog(this);
			}
			else
			{
				MessageBox.Show("Connection created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void OnBack(object sender, EventArgs e)
		{
			Hide();
			var datasourceType = new DataSourceType();
			datasourceType.ShowDialog();
			Close();
		}

		private void OnSettingMethodChanged(object sender, EventArgs e)
		{
			groupAuth.Visible = groupGeneral.Visible = radioManual.Checked;
			txtConnStringName.Enabled = radioAppConfig.Checked;
		}

		public string Title
		{
			get
			{
				return lblTitle.Text;
			}
			set
			{
				lblTitle.Text = value;
			}
		}

		public string DefaultPort
		{
			get { return txtPort.Text; }
			set { txtPort.Text = value; }
		}
	}
}
