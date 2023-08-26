using System.Diagnostics;
using System.Reflection;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace ReportWizardPrototype
{
	public partial class NewReport : Form
	{
		public NewReport()
		{
			InitializeComponent();
			var rdlxItem = BuildReportTypeItem("ReportWizardPrototype.Resources.rdlx.png", "Multi-section continous page layout. Use this layout by default for most reports.", "RDLX");
			rdlxItem.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var dashboardItem = BuildReportTypeItem("ReportWizardPrototype.Resources.dashboard.png", "Multi-section pageless layout. Use this to create dashboard-like visualization and interactivity.", "RDLX Dashboard");
			dashboardItem.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var pageItem = BuildReportTypeItem("ReportWizardPrototype.Resources.page.png", "Fixed page layout. Use this layout to build pixel-perfect reports.", "Page");
			pageItem.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var sectionItem = BuildReportTypeItem("ReportWizardPrototype.Resources.section.png", "Banded layout. Use this layout for simple band-based reports.", "Section");
			sectionItem.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = false;
			};
			tableLayoutPanel1.Controls.Add(rdlxItem);
			tableLayoutPanel1.Controls.Add(dashboardItem);
			tableLayoutPanel1.Controls.Add(pageItem);
			tableLayoutPanel1.Controls.Add(sectionItem);

			tableLayoutPanel1.SetRow(rdlxItem, 0);
			tableLayoutPanel1.SetColumn(rdlxItem, 0);

			tableLayoutPanel1.SetRow(dashboardItem, 1);
			tableLayoutPanel1.SetColumn(dashboardItem, 0);

			tableLayoutPanel1.SetRow(pageItem, 2);
			tableLayoutPanel1.SetColumn(pageItem, 0);

			tableLayoutPanel1.SetRow(sectionItem, 3);
			tableLayoutPanel1.SetColumn(sectionItem, 0);
			if (PrototypeSettings.VSNETUI)
			{
				var codeBasedItem = BuildReportTypeItem("ReportWizardPrototype.Resources.section.png", "Code-based layout. Use this layout to fully control the report output with your code.", "Code-based");
				codeBasedItem.Click += (sender, args) =>
				{
					PrototypeSettings.IsRDLX = false;
				};
				tableLayoutPanel1.Controls.Add(codeBasedItem);
				tableLayoutPanel1.SetRow(codeBasedItem, 4);
				tableLayoutPanel1.SetColumn(codeBasedItem, 0);
			}
			rdlxItem.Select();
		}

		private static ReportType BuildReportTypeItem(string image, string description, string title)
		{
			Stream myStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(image);
			Bitmap bmp = new(myStream);
			return new ReportType
			{
				BackColor = SystemColors.ControlLightLight,
				Title = title,
				Description = description,
				Icon = bmp,
				Dock = DockStyle.Fill
			};
		}


		private void OnCancel(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnFinish(object sender, EventArgs e)
		{
			// created blank report
			Application.Exit();
		}

		private void OnNext(object sender, EventArgs e)
		{
			if (PrototypeSettings.IsRDLX)
			{
				Hide();
				var dataSourceType = new DataSourceType();
				dataSourceType.ShowDialog(this);
				Close();
			}
			else
			{
				var res = MessageBox.Show("Here the Section Report Data Source dialog is displayed", "Internal Info", MessageBoxButtons.OK);
				if (res == DialogResult.OK)
				{
					Application.Exit();
				}
			}
		}

		private void OnHelp(object sender, EventArgs e)
		{
			var helpUrl = "https://www.grapecity.com/activereportsnet/docs/latest/online/reporttypes.html";
			Process.Start(new ProcessStartInfo { FileName = helpUrl, UseShellExecute = true });
		}
	}
}
