using MbUnit.Framework;
using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class ReportParameterTest {
		[RowTest]
		[Row( "key", "value" )]
		[Row( "Text", "Hello World" )]
		public void Should_Create_A_New_Report_Parameter( string key, string value ) {
			IReportParameter parameter = new ReportParameter( key, value );
			Assert.AreEqual( key, parameter.Key );
			Assert.AreEqual( value, parameter.Value );
		}
	}
}