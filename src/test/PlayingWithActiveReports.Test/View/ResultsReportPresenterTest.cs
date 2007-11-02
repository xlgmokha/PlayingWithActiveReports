using MbUnit.Framework;
using PlayingWithActiveReports.Core.Reports;
using PlayingWithActiveReports.Core.Task;
using PlayingWithActiveReports.Core.View;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace PlayingWithActiveReports.Test.View {
	[TestFixture]
	public class ResultsReportPresenterTest {
		[SetUp]
		public void Setup( ) {
			_mockery = new MockRepository( );
			_stubView = _mockery.Stub< IResultsReportView >( );
			_stubTask = _mockery.Stub< IResultsReportTask >( );
		}

		[Test]
		public void Should_Bind_Report_To_Report_Viewer( ) {
			IReportViewer stubViewer = _mockery.Stub< IReportViewer >( );
			IResultsReport stubReport = _mockery.Stub< IResultsReport >( );

			using( _mockery.Record( ) ) {
				Expect.Call( _stubTask.CreateReport( ) ).Return( stubReport );
				Expect.Call( _stubView.ReportViewer ).Return( stubViewer );

				stubViewer.BindTo( null );
				LastCall.On( stubViewer ).Constraints( Is.Equal( stubReport ) );
			}

			using( _mockery.Playback( ) ) {
				new ResultsReportPresenter( _stubView, _stubTask ).Initialize( );
			}
		}

		private MockRepository _mockery;
		private IResultsReportTask _stubTask;
		private IResultsReportView _stubView;
	}
}