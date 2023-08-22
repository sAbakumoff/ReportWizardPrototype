using ReportWizardPrototype.VSUI;

namespace ReportWizardPrototype
{
	internal static class Program
	{
		private static bool VSNETUI = true;
		private static bool ConnectionError = true;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			var dsType = new DataSourceType(VSNETUI, ConnectionError);
			dsType.Show();
			Application.Run();
		}
	}
}