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
	public partial class CSVFields : Form
	{
		public event EventHandler BackClicked;
		public CSVFields()
		{
			InitializeComponent();
			dataGridView1.Rows.Add("Region", "String");
			dataGridView1.Rows.Add("Country", "String");
			dataGridView1.Rows.Add("Sales Channel", "String");
			dataGridView1.Rows.Add("Order Date", "Date");

			dataGridView2.Rows.Add("North America", "USA", "Offline", "2021/01/01");
			dataGridView2.Rows.Add("South America", "Brazil", "Online", "2021/02/01");
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if (BackClicked != null)
				BackClicked(this, EventArgs.Empty);
		}
	}
}
