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
	public partial class ExcelDataSets : Form
	{
		private int _counter = 2;
		public ExcelDataSets()
		{
			InitializeComponent();
			listSheets.SelectedIndex = 0;
			listBox1.SelectedIndex = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			var excelConn = new FileConnection
			{
				Title = "Configure Excel Workbook connection",
				PasswordVisible = false,
				PathLabelText = "File path:",
				TestConnectionVisible = false,
				ConfigConnectionStringEnabled = false
			};
			excelConn.ShowDialog(this);
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Add($"Query{_counter++}");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex >= 0)
			{
				this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button2.Enabled = this.listBox1.SelectedItems.Count > 0;
			if (this.listBox1.SelectedItems.Count > 0)
			{
				this.textBox2.Text = this.listBox1.SelectedItems[0].ToString();
			}
		}
	}
}
