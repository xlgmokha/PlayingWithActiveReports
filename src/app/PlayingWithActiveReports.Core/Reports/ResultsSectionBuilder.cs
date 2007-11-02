using PlayingWithActiveReports.Test.Reports;

namespace PlayingWithActiveReports.Core.Reports {
	public class ResultsSectionBuilder : ISectionBuilder {
		public ResultsSectionBuilder( IResultSectionTask task ) {
			_task = task;
		}

		public void BuildFrom( IMainReport report ) {
			BuildFrom( report, new ResultsSection( ) );
		}

		public void BuildFrom( IMainReport report, IResultsSection section ) {
			report.AddSection( section.BindTo( _task.GetResults( ) ) );
		}

		private readonly IResultSectionTask _task;
	}
}