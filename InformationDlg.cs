using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
	public partial class InformationDlg : Form
	{
		public event EventHandler BackClicked;
		public InformationDlg()
		{
			InitializeComponent();
			
		}

		public InformationDlg(string rtfRes)
		{
			InitializeComponent();
			LoadRtfFromResources(rtfRes);
		}
		private void LoadRtfFromResources(string rtfRes)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			using (Stream stream = assembly.GetManifestResourceStream(rtfRes))
			{
				if (stream != null)
				{
					infoBox.LoadFile(stream, RichTextBoxStreamType.RichText);
				}
				else
				{
					MessageBox.Show("Could not find the embedded resource!");
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			if(BackClicked != null)	
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
