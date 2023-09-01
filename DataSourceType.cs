using ReportWizardPrototype.VSUI;
using System.ComponentModel;
using System.Reflection;

namespace ReportWizardPrototype
{
	public partial class DataSourceType : Form
	{
		private DataSource _selectedDataSource = DataSource.MSSQL;
		public DataSourceType()
		{
			InitializeComponent();
			groupBox2.Visible = PrototypeSettings.VSNETUI;
			HelpButton = true;
			var msSql = BuildItem("ReportWizardPrototype.Resources.MSSQLSERVER_small.png", "MS SQL Server");
			tableLayoutDatabase.Controls.Add(msSql);
			tableLayoutDatabase.SetColumn(msSql, 0);
			tableLayoutDatabase.SetRow(msSql, 0);
			msSql.OnClick += (sender, agrs) =>
			{
				_selectedDataSource = DataSource.MSSQL;
			};

			var mySql = BuildItem("ReportWizardPrototype.Resources.MySQL_small.png", "MySQL");
			tableLayoutDatabase.Controls.Add(mySql);
			tableLayoutDatabase.SetColumn(mySql, 1);
			tableLayoutDatabase.SetRow(mySql, 0);
			mySql.OnClick += (sender, agrs) =>
			{
				_selectedDataSource = DataSource.MYSQL;
			};

			var sqlIte = BuildItem("ReportWizardPrototype.Resources.sqlite_small.png", "SQLite");
			tableLayoutDatabase.Controls.Add(sqlIte);
			tableLayoutDatabase.SetColumn(sqlIte, 2);
			tableLayoutDatabase.SetRow(sqlIte, 0);

			//var oracle = BuildItem("ReportWizardPrototype.Resources.oracle_small.png", "Oracle");
			//tableLayoutDatabase.Controls.Add(oracle);
			//tableLayoutDatabase.SetColumn(oracle, 3);
			//tableLayoutDatabase.SetRow(oracle, 0);

			var postgres = BuildItem("ReportWizardPrototype.Resources.PostgreSQL_small.png", "PostgreSQL");
			tableLayoutDatabase.Controls.Add(postgres);
			tableLayoutDatabase.SetColumn(postgres, 3);
			tableLayoutDatabase.SetRow(postgres, 0);

			var access = BuildItem("ReportWizardPrototype.Resources.MSAccess_small.png", "MS Access");
			tableLayoutDatabase.Controls.Add(access);
			tableLayoutDatabase.SetColumn(access, 0);
			tableLayoutDatabase.SetRow(access, 1);


			var csv = BuildItem("ReportWizardPrototype.Resources.CSV_small.png", "CSV");
			tableLayoutFile.Controls.Add(csv);
			tableLayoutFile.SetRow(msSql, 0);
			tableLayoutFile.SetColumn(msSql, 0);

			var json = BuildItem("ReportWizardPrototype.Resources.JSON_small.png", "JSON");
			tableLayoutFile.Controls.Add(json);
			tableLayoutFile.SetRow(json, 0);
			tableLayoutFile.SetColumn(json, 1);

			var xml = BuildItem("ReportWizardPrototype.Resources.XML_small.png", "XML");
			tableLayoutFile.Controls.Add(xml);
			tableLayoutFile.SetRow(xml, 0);
			tableLayoutFile.SetColumn(xml, 2);

			var xls = BuildItem("ReportWizardPrototype.Resources.XLS_small.png", "XLS");
			tableLayoutFile.Controls.Add(xls);
			tableLayoutFile.SetRow(xls, 0);
			tableLayoutFile.SetColumn(xls, 3);

			var jsonAPI = BuildItem("ReportWizardPrototype.Resources.json_api_small.png", "JSON API");
			tableLayoutWebApi.Controls.Add(jsonAPI);
			tableLayoutWebApi.SetRow(jsonAPI, 0);
			tableLayoutWebApi.SetColumn(jsonAPI, 0);
			jsonAPI.OnClick += (sender, args) =>
			{
				this._selectedDataSource = DataSource.JSONAPI;
			};

			var objectDs = BuildItem("ReportWizardPrototype.Resources.object_small.png", "Object");
			tableLayoutProgrammatic.Controls.Add(objectDs);
			tableLayoutProgrammatic.SetRow(jsonAPI, 0);
			tableLayoutProgrammatic.SetColumn(jsonAPI, 0);

		}



		private void OnCancel(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void OnBack(object sender, EventArgs e)
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

		private void OnNext(object sender, EventArgs e)
		{
			Hide();
			switch (_selectedDataSource)
			{
				case DataSource.JSONAPI:
					var webApiConnection = new WebAPIConnection();
					webApiConnection.ShowDialog(this);
					break;
				case DataSource.MSSQL:
					var msSqlConnDialog = new VSMSSQLConnection();
					msSqlConnDialog.ShowDialog(this);
					break;
				case DataSource.MYSQL:
					var mysqlConnDialog = new MySQLConnection();
					mysqlConnDialog.ShowDialog(this);
					break;
			}
			Close();
		}
	}

	internal enum DataSource
	{
		MSSQL,
		JSONAPI,
		MYSQL
	}
}
