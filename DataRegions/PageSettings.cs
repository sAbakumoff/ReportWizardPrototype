using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class PageSettings : Form
    {
        public event EventHandler BackClicked;
        public PageSettings()
        {
            InitializeComponent();

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            if (BackClicked != null)
                BackClicked(this, EventArgs.Empty);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void PageSettings_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
