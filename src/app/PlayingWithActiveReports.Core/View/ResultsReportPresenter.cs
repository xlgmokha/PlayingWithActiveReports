using PlayingWithActiveReports.Core.Task;
using PlayingWithActiveReports.Core.View;

namespace PlayingWithActiveReports.Core.View {
	public class ResultsReportPresenter {
		public ResultsReportPresenter( IResultsReportView view ) : this( view, new StubResultsReportTask( ) ) {}

		public ResultsReportPresenter( IResultsReportView view, IResultsReportTask task ) {
			_view = view;
			_task = task;
		}

		public void Initialize( ) {
			_view.ReportViewer.BindTo( _task.CreateReport( ) );
		}

		private IResultsReportTask _task;
		private IResultsReportView _view;
	}
}