using DataDynamics.ActiveReports.Viewer;
using PlayingWithActiveReports.Core.Reports;
using PlayingWithActiveReports.Core.View;

namespace PlayingWithActiveReports.Win.UI.Adapters {
	public class ReportViewer : IReportViewer {
		public ReportViewer( Viewer viewerControl ) {
			_viewerControl = viewerControl;
		}

		public void BindTo( IResultsReport document ) {
			_viewerControl.Document = document.Report.Document;
		}

		private Viewer _viewerControl;
	}
}