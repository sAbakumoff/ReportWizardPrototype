using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class WelcomeScreen : Form
    {
        public event EventHandler BackClicked;
        public WelcomeScreen()
        {
            InitializeComponent();

        }

        public WelcomeScreen(string rtfRes)
        {
            InitializeComponent();
            LoadRtfFromResources(rtfRes);
        }
        private void LoadRtfFromResources(string rtfRes)
        {

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
    }
}
