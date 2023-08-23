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
	public partial class DataSetRDLX : Form
	{
		private int _counter = 2;
		public DataSetRDLX()
		{
			InitializeComponent();
			this.listBox1.SelectedIndex = 0;
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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var paramsDialog = new Parameters();
			paramsDialog.ShowDialog(this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Add($"Query{_counter++}");
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button2.Enabled = this.listBox1.SelectedItems.Count > 0;
			if (this.listBox1.SelectedItems.Count > 0)
			{
				this.textBox2.Text = this.listBox1.SelectedItems[0].ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
		}
	}
}
