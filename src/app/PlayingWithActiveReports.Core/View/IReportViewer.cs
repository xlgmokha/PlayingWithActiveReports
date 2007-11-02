using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Core.View {
	public interface IReportViewer {
		void BindTo( IResultsReport document );
	}
}