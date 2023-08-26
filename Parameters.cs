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
	public partial class Parameters : Form
	{
		public Parameters()
		{
			InitializeComponent();
			this.dataGridView1.Rows.Add("paramTimeout", "Integer", 3000, "Programmatic");
			this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
			this.dataGridView1.MultiSelect = false;
			this.Load += Parameters_Load;

		}

		private void Parameters_Load(object? sender, EventArgs e)
		{
			dataGridView1.ClearSelection();
		}

		private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
		{
			this.button2.Enabled = dataGridView1.SelectedRows.Count > 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
