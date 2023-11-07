using ReportWizardPrototype.VSUI;

namespace ReportWizardPrototype
{
    public partial class DataSetRDLX : Form
    {
        private int _counter = 2;
        public event EventHandler OnBack;
        public DataSetRDLX()
        {
            InitializeComponent();
            this.listBox1.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //var connDialog = new VSMSSQLConnection();
            //connDialog.ShowDialog(this);
            if (this.OnBack != null)
            {
                OnBack(this, EventArgs.Empty);
            }
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
        private async Task<bool> ValidateRoutine()
        {
            await Task.Delay(500);
            return PrototypeSettings.QueryError;
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            listBox1.Enabled = button1.Enabled = button2.Enabled = btnValidate.Enabled = btnBack.Enabled = btnNext.Enabled = linkLabel1.Enabled = false;

            // Simulate some asynchronous work
            bool error = await ValidateRoutine();

            // Restore the cursor and re-enable the UI
            this.UseWaitCursor = false;
            listBox1.Enabled = button1.Enabled = button2.Enabled = btnValidate.Enabled = btnBack.Enabled = btnNext.Enabled = linkLabel1.Enabled = true;

            if (error)
            {
                var errorForm = new ErrorForm();
                errorForm.GeneralMessage = $"An error occurred while executing {listBox1.SelectedItem.ToString()}";
                errorForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void DataSetRDLX_Load(object sender, EventArgs e)
        {

        }
    }
}
