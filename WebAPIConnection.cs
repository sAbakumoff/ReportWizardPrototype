using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
	public partial class WebAPIConnection : Form
	{

		public WebAPIConnection()
		{
			InitializeComponent();
			this.Shown += (sender, args) =>
			{
				this.txtURL.Focus();
			};
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}


		private void OnCancel(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnBack(object sender, EventArgs e)
		{
			Hide();
			var datasourceType = new DataSourceType();
			datasourceType.ShowDialog(this);
			Close();
		}

		private void OnMethodChanged(object sender, EventArgs e)
		{
			lblPostBody.Enabled = txtBody.Enabled = linkBodyParam.Enabled = !radioMethodGET.Checked;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}

		private void linkBodyParam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}

		private void btnHeaders_Click(object sender, EventArgs e)
		{
			var httpHeaders = new HttpHeaders();
			httpHeaders.ShowDialog(this);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Hide();
			var dataSetDialog = new WebAPIDataSets();
			dataSetDialog.OnBackClicked += (sender, args) =>
			{
				Show();
			};
			dataSetDialog.ShowDialog(this);
			// Close();
		}

		private async void btnTestRequest_Click(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			foreach (Control ctrl in Controls)
			{
				if (ctrl.Name == "btnCancel")
					continue;
				ctrl.Enabled = false;
			}


			// Simulate some asynchronous work
			bool error = await ValidateRoutine();

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
				errorForm.GeneralMessage = $"An error occurred while executing Web API request";
				errorForm.ShowDialog(this);
			}
			else
			{
				MessageBox.Show("Request executed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private async Task<bool> ValidateRoutine()
		{
			await Task.Delay(500);
			return PrototypeSettings.QueryError;
		}
	}
}
