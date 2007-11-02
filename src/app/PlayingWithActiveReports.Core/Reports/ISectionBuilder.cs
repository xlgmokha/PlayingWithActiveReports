using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Test.Reports {
	public interface ISectionBuilder {
		void BuildFrom( IMainReport report );
		void BuildFrom( IMainReport report, IResultsSection section );
	}
}