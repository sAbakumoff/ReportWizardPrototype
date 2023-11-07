using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class ReportTheme : Form
    {
        public event EventHandler BackClicked;
        public ReportTheme()
        {
            InitializeComponent();

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            // var dataSourceType = new TableGroupings();
            // dataSourceType.ShowDialog(this);
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

        private void TableFields_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
