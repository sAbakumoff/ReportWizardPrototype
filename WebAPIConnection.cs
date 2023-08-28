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
	}
}
