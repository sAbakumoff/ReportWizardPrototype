namespace ReportWizardPrototype
{
    public partial class CSVConnection : Form
    {
        public CSVConnection()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboboxEncoding.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioDelimited_CheckedChanged(object sender, EventArgs e)
        {
            groupDelimiters.Visible = radioDelimited.Checked;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var dataSourceType = new DataSourceType();
            dataSourceType.Show();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            var csvFields = new CSVFields();
            csvFields.BackClicked += (sender, args) =>
            {
                csvFields.Close();
                Show();
            };
            csvFields.ShowDialog(this);
        }

        private void linkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var paramsDlg = new Parameters();
            paramsDlg.ShowDialog(this);
        }
    }
}
