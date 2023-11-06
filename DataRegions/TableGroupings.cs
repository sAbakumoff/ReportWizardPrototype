using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class TableGroupings : Form
    {
        public event EventHandler BackClicked;
        public TableGroupings()
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

        private void TableFields_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("Country");
            item1.SubItems.Add("City");
            listView2.Items.Add(item1);
        }
    }
}
