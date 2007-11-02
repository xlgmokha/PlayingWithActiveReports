using MbUnit.Framework;
using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class ResultsReportTest {
		[Test]
		public void Should_Contain_Page_Header( ) {
			IReportSection header = CreateSut( ).FindSectionBy( ReportSection.Header );
			Assert.IsNotNull( header );
			Assert.AreEqual( "Header", header.Name );
		}

		[Test]
		public void Should_Contain_Page_Footer( ) {
			IReportSection footer = CreateSut( ).FindSectionBy( ReportSection.Footer );
			Assert.IsNotNull( footer );
			Assert.AreEqual( "Footer", footer.Name );
		}

		[Test]
		public void Should_Return_Questions_Results_Section( ) {
			Assert.IsNotNull( CreateSut( ).FindSectionBy( ReportSection.Results ) );
		}

		[Test]
		public void Should_Bind_All_Parameters_To_DataSource( ) {}

		private IResultsReport CreateSut( ) {
			return new ResultsReport( );
		}
	}
}