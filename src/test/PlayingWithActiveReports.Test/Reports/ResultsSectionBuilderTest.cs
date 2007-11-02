using System.Collections.Generic;
using MbUnit.Framework;
using PlayingWithActiveReports.Core.Dto;
using PlayingWithActiveReports.Core.Reports;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class ResultsSectionBuilderTest {
		public delegate void CallBackAssertion( );

		// get list of dto items to bind to section
		// add section to the report

		[SetUp]
		public void Setup( ) {
			_mockery = new MockRepository( );
			_taskStub = _mockery.Stub< IResultSectionTask >( );
		}

		[Test]
		public void Should_Add_Section_To_Report( ) {
			IMainReport mainReportStub = _mockery.Stub< IMainReport >( );

			using( _mockery.Record( ) ) {
				mainReportStub.AddSection( null );
				LastCall.Constraints( Is.TypeOf( typeof( IResultsSection ) ) );
			}

			using( _mockery.Playback( ) ) {
				CreateSut( ).BuildFrom( mainReportStub );
			}
		}

		[Test]
		public void Should_Get_List_Of_Dtos_Using_Task( ) {
			IMainReport mainReportStub = _mockery.Stub< IMainReport >( );

			using( _mockery.Record( ) ) {
				_taskStub.GetResults( );
			}

			using( _mockery.Playback( ) ) {
				CreateSut( ).BuildFrom( mainReportStub );
			}
		}

		[Test]
		public void Should_Bind_Dtos_To_Section( ) {
			IMainReport mainReportStub = _mockery.Stub< IMainReport >( );
			IResultsSection sectionStub = _mockery.Stub< IResultsSection >( );
			IEnumerable< DisplayReportQuestionDto > returnValue = _mockery.Stub< IEnumerable< DisplayReportQuestionDto > >( );

			using( _mockery.Record( ) ) {
				Expect.Call( _taskStub.GetResults( ) ).Return( returnValue );
				sectionStub.BindTo( returnValue );
			}

			using( _mockery.Playback( ) ) {
				CreateSut( ).BuildFrom( mainReportStub, sectionStub );
			}
		}

		private ISectionBuilder CreateSut( ) {
			return new ResultsSectionBuilder( _taskStub );
		}

		private MockRepository _mockery;
		private IResultSectionTask _taskStub;
	}
}