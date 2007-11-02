using System.Windows.Forms;
using PlayingWithActiveReports.Core.View;
using PlayingWithActiveReports.Win.UI.Adapters;

namespace PlayingWithActiveReports.Win.UI {
	public partial class ResultsReportView : Form, IResultsReportView {
		public ResultsReportView( ) {
			InitializeComponent( );

			//ResultsReport report = new ResultsReport( );
			//report.subReport1.Report = new ResultsSection( );
			//report.Run( false );

			//this.viewer1.Document = report.Document;

			_presenter = new ResultsReportPresenter( this );
			_presenter.Initialize( );
		}

		public IReportViewer ReportViewer {
			get { return new ReportViewer( viewer1 ); }
		}

		private ResultsReportPresenter _presenter;
	}
}