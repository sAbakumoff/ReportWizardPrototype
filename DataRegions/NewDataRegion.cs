using System.Diagnostics;
using System.Reflection;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace ReportWizardPrototype
{
    public partial class NewDataRegion : Form
    {
        public NewDataRegion()
        {
            InitializeComponent();
            var tableItem = BuildReportTypeItem("ReportWizardPrototype.Resources.Table.png", "Grid-like layout that visualizes your data  in a multicolumn, multirow fashion.", "Table");

            var tablixItem = BuildReportTypeItem("ReportWizardPrototype.Resources.Tablix.png", "Pivot table-like layout that condenses your data into groups and displays summary values.", "Tablix");

            var chartItem = BuildReportTypeItem("ReportWizardPrototype.Resources.Chart.png", "A graphical representation of patterns and trends in your data.", "Chart");

            tableLayoutPanel1.Controls.Add(tableItem);
            tableLayoutPanel1.Controls.Add(tablixItem);
            tableLayoutPanel1.Controls.Add(chartItem);

            tableLayoutPanel1.SetRow(tableItem, 0);
            tableLayoutPanel1.SetColumn(tableItem, 0);

            tableLayoutPanel1.SetRow(tablixItem, 1);
            tableLayoutPanel1.SetColumn(tablixItem, 0);

            tableLayoutPanel1.SetRow(chartItem, 2);
            tableLayoutPanel1.SetColumn(chartItem, 0);

            tableItem.Select();
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
            Hide();
            var dataSourceType = new TableFields();
            dataSourceType.ShowDialog(this);
            Close();
        }

        private void OnHelp(object sender, EventArgs e)
        {
            var helpUrl = "https://www.grapecity.com/activereportsnet/docs/latest/online/reporttypes.html";
            Process.Start(new ProcessStartInfo { FileName = helpUrl, UseShellExecute = true });
        }
    }
}
