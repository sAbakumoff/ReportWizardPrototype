﻿using ReportWizardPrototype.VSUI;
using System.ComponentModel;
using System.Reflection;

namespace ReportWizardPrototype
{
	public partial class DataSourceType : Form
	{
		public DataSourceType()
		{
			InitializeComponent();
			groupBox2.Visible = PrototypeSettings.VSNETUI;
			HelpButton = true;
			var msSql = BuildItem("ReportWizardPrototype.Resources.MSSQLSERVER_small.png", "MS SQL Server");
			tableLayoutDatabase.Controls.Add(msSql);
			tableLayoutDatabase.SetColumn(msSql, 0);
			tableLayoutDatabase.SetRow(msSql, 0);

			var mySql = BuildItem("ReportWizardPrototype.Resources.MySQL_small.png", "MySQL");
			tableLayoutDatabase.Controls.Add(mySql);
			tableLayoutDatabase.SetColumn(mySql, 1);
			tableLayoutDatabase.SetRow(mySql, 0);

			var sqlIte = BuildItem("ReportWizardPrototype.Resources.sqlite_small.png", "SQLite");
			tableLayoutDatabase.Controls.Add(sqlIte);
			tableLayoutDatabase.SetColumn(sqlIte, 2);
			tableLayoutDatabase.SetRow(sqlIte, 0);

			var oracle = BuildItem("ReportWizardPrototype.Resources.oracle_small.png", "Oracle");
			tableLayoutDatabase.Controls.Add(oracle);
			tableLayoutDatabase.SetColumn(oracle, 3);
			tableLayoutDatabase.SetRow(oracle, 0);

			var postgres = BuildItem("ReportWizardPrototype.Resources.PostgreSQL_small.png", "PostgreSQL");
			tableLayoutDatabase.Controls.Add(postgres);
			tableLayoutDatabase.SetColumn(postgres, 0);
			tableLayoutDatabase.SetRow(postgres, 1);

			var access = BuildItem("ReportWizardPrototype.Resources.MSAccess_small.png", "MS Access");
			tableLayoutDatabase.Controls.Add(access);
			tableLayoutDatabase.SetColumn(access, 1);
			tableLayoutDatabase.SetRow(access, 1);


			var csv = BuildItem("ReportWizardPrototype.Resources.CSV_small.png", "CSV");
			tableLayoutFile.Controls.Add(csv);
			tableLayoutFile.SetRow(msSql, 0);
			tableLayoutFile.SetColumn(msSql, 0);

			var json = BuildItem("ReportWizardPrototype.Resources.JSON_small.png", "JSON");
			tableLayoutFile.Controls.Add(json);
			tableLayoutFile.SetRow(json, 0);
			tableLayoutFile.SetColumn(json, 1);

			var xls = BuildItem("ReportWizardPrototype.Resources.XLS_small.png", "XLS");
			tableLayoutFile.Controls.Add(xls);
			tableLayoutFile.SetRow(xls, 0);
			tableLayoutFile.SetColumn(xls, 2);

			var xml = BuildItem("ReportWizardPrototype.Resources.XML_small.png", "XML");
			tableLayoutFile.Controls.Add(xml);
			tableLayoutFile.SetRow(xml, 0);
			tableLayoutFile.SetColumn(xml, 3);

			var jsonAPI = BuildItem("ReportWizardPrototype.Resources.json_api_small.png", "JSON API");
			tableLayoutWebApi.Controls.Add(jsonAPI);
			tableLayoutWebApi.SetRow(jsonAPI, 0);
			tableLayoutWebApi.SetColumn(jsonAPI, 0);

			var objectDs = BuildItem("ReportWizardPrototype.Resources.object_small.png", "Object");
			tableLayoutProgrammatic.Controls.Add(objectDs);
			tableLayoutProgrammatic.SetRow(jsonAPI, 0);
			tableLayoutProgrammatic.SetColumn(jsonAPI, 0);

		}



		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			var reportType = new NewReport();
			reportType.Show();
			this.Close();
		}

		private DataSourceItem BuildItem(string image, string title)
		{
			Stream myStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(image);
			Bitmap bmp = new(myStream);
			return new DataSourceItem
			{
				BackColor = SystemColors.ControlLightLight,
				Title = title,
				Icon = bmp,
				Dock = DockStyle.Fill,
				TabStop = true
			};

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.Hide();
			var msSqlConnDialog = new VSMSSQLConnection();
			msSqlConnDialog.Show();
			this.Close();
		}
	}
}
