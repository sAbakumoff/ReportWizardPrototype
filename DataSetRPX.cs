using ReportWizardPrototype.VSUI;
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
	public partial class DataSetRPX : Form
	{
		public DataSetRPX()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}
		private async Task<bool> ValidateRoutine()
		{
			await Task.Delay(500);
			return PrototypeSettings.QueryError;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			var connDialog = new VSMSSQLConnection();
			connDialog.ShowDialog(this);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private async void btnValidate_Click(object sender, EventArgs e)
		{
			UseWaitCursor = true;
			radioButton1.Enabled = radioButton2.Enabled =  textBox1.Enabled = btnValidate.Enabled = btnBack.Enabled = btnNext.Enabled = linkLabel1.Enabled = false;

			// Simulate some asynchronous work
			bool error = await ValidateRoutine();

			// Restore the cursor and re-enable the UI
			this.UseWaitCursor = false;
			radioButton1.Enabled = radioButton2.Enabled = textBox1.Enabled = btnValidate.Enabled = btnBack.Enabled = btnNext.Enabled = linkLabel1.Enabled = true;

			if (error)
			{
				var errorForm = new ErrorForm();
				errorForm.GeneralMessage = $"An error occurred while executing your query";
				errorForm.ShowDialog(this);
			}
			else
			{
				MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
