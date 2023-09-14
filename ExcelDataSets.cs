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
			optionRange.CheckedChanged += OnOptionChanged;
			optionSheet.CheckedChanged += OnOptionChanged;
			optionTable.CheckedChanged += OnOptionChanged;
		}

		private void OnOptionChanged(object? sender, EventArgs e)
		{
			listSheets.Items.Clear();
			if (optionRange.Checked)
			{
				listSheets.Items.Add("Named Range$1");
				listSheets.Items.Add("Named Range$2");
				listSheets.Items.Add("Named Range$3");
			}
			if (optionSheet.Checked)
			{
				listSheets.Items.Add("Sheet$1");
				listSheets.Items.Add("Sheet$2");
				listSheets.Items.Add("Sheet$3");
			}
			if (optionTable.Checked)
			{
				listSheets.Items.Add("Table$1");
				listSheets.Items.Add("Table$2");
				listSheets.Items.Add("Table$3");
			}
			listSheets.SelectedIndex = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Hide();
			var summaryInfo = PrototypeSettings.VSNETUI ? "ReportWizardPrototype.Resources.summary.rtf" : "ReportWizardPrototype.Resources.summary_eud.rtf";
			var information = new InformationDlg(summaryInfo);

			information.BackClicked += (sender, e) =>
			{
				information.Hide();
				Show();
			};
			information.ShowDialog(this);
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
