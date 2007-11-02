using System;
using System.Windows.Forms;

namespace PlayingWithActiveReports.Win.UI {
	internal static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main( ) {
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			//Application.Run( new ResultsReportView( ) );
			Application.Run( new SimpleReportView( ) );
		}
	}
}