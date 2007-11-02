using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Core.Task {
	public interface IResultsReportTask {
		IResultsReport CreateReport( );
	}
}