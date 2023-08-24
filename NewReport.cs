using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
	public partial class NewReport : Form
	{
		public NewReport()
		{
			InitializeComponent();
			this.HelpButton = true;
			var rdlxPlate = BuildPlate("ReportWizardPrototype.Resources.rdlx.png", "Multi-section continous page layout. Use this layout by default for most reports", "RDLX");
			rdlxPlate.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var dashboardPlate = BuildPlate("ReportWizardPrototype.Resources.dashboard.png", "Multi-section pageless layout. Use this to create dashboard-like visualization and interactivity", "RDLX Dashboard");
			dashboardPlate.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var pagePlate = BuildPlate("ReportWizardPrototype.Resources.page.png", "Fixed page layout. Use this layout to build pixel-perfect reports", "Page");
			pagePlate.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = true;
			};
			var sectionPlate = BuildPlate("ReportWizardPrototype.Resources.section.png", "Banded layout. Use this layout for simple band-based reports", "Section");
			sectionPlate.Click += (sender, args) =>
			{
				PrototypeSettings.IsRDLX = false;
			};
			this.tableLayoutPanel1.Controls.Add(rdlxPlate);
			this.tableLayoutPanel1.Controls.Add(dashboardPlate);
			this.tableLayoutPanel1.Controls.Add(pagePlate);
			this.tableLayoutPanel1.Controls.Add(sectionPlate);

			this.tableLayoutPanel1.SetRow(rdlxPlate, 0);
			this.tableLayoutPanel1.SetColumn(rdlxPlate, 0);

			this.tableLayoutPanel1.SetRow(dashboardPlate, 1);
			this.tableLayoutPanel1.SetColumn(dashboardPlate, 0);

			this.tableLayoutPanel1.SetRow(pagePlate, 2);
			this.tableLayoutPanel1.SetColumn(pagePlate, 0);

			this.tableLayoutPanel1.SetRow(sectionPlate, 3);
			this.tableLayoutPanel1.SetColumn(sectionPlate, 0);

			rdlxPlate.Select();

		}

		private ReportType BuildPlate(string image, string description, string title)
		{
			var plate = new ReportType();
			plate.BackColor = SystemColors.ControlLightLight;
			plate.Title = title;
			plate.Description = description;
			Stream myStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(image);
			Bitmap bmp = new Bitmap(myStream);
			plate.Icon = bmp;
			plate.Dock = DockStyle.Fill;
			return plate;

		}


		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void onFinish(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void onNext(object sender, EventArgs e)
		{
			this.Hide();
			var dataSourceType = new DataSourceType();
			dataSourceType.ShowDialog(this);
			this.Close();
		}
	}
}
