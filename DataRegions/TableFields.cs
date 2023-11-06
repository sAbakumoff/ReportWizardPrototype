using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class TableFields : Form
    {
        public event EventHandler BackClicked;
        public TableFields()
        {
            InitializeComponent();

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var dataSourceType = new TableGroupings();
            dataSourceType.ShowDialog(this);
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
            comboBox1.SelectedIndex = 0;
        }
    }
}
