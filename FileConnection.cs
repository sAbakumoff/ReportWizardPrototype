namespace ReportWizardPrototype
{
	public partial class FileConnection : Form
	{
		public event EventHandler OnNextClicked;
		public FileConnection()
		{
			InitializeComponent();
			linkPath.Click += (sender, args) =>
			{
				OpenParamDialog();
			};
			linkPwd.Click += (sender, args) =>
			{
				OpenParamDialog();
			};
			this.Load += (sender, args) =>
			{
				if (!PrototypeSettings.VSNETUI || !ConfigConnectionStringEnabled)
				{
					var reducedLocation = groupBox1.Height + 20;
					groupBox1.Visible = false;
					groupGeneral.Top -= reducedLocation;
					groupAuth.Top -= reducedLocation;
					groupGeneral.Visible = true;
					groupAuth.Visible = PasswordVisible;
				}
			};
		}
		private void OpenParamDialog()
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}

		private async void btnTestConnection_Click(object sender, EventArgs e)
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

		public bool ConfigConnectionStringEnabled { get; set; }

		public string Title
		{
			get { return lblTitle.Text; }
			set { lblTitle.Text = value; }
		}

		public string PathLabelText
		{
			get { return lblPath.Text; }
			set { lblPath.Text = value; }
		}

		public bool TestConnectionVisible
		{
			get { return btnTestConnection.Visible; }
			set { btnTestConnection.Visible = value; }
		}

		public bool PasswordVisible
		{
			get;
			set;
		}

		public bool AllowPasswordProtection { get; set; }

		private async Task<bool> ConnectionRoutine()
		{
			await Task.Delay(500);
			return PrototypeSettings.ConnectionError;
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

		private void radioAppConfig_CheckedChanged(object sender, EventArgs e)
		{
			groupGeneral.Visible = radioManual.Checked;
			groupAuth.Visible = radioManual.Checked && PasswordVisible;
			txtConnStringName.Enabled = radioAppConfig.Checked;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.OK)
			{
				txtPath.Text = dialog.FileName;
			}
		}
	}
}
