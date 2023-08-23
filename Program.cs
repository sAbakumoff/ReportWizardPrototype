using ReportWizardPrototype.VSUI;

namespace ReportWizardPrototype
{
	internal static class Program
	{
	/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			var dsType = new DataSourceType();
			dsType.Show();
			Application.Run();
		}
	}

	internal static class PrototypeSettings
	{
		public static bool VSNETUI = false;
		public static bool ConnectionError = true;
	}
}