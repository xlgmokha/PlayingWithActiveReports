using System.Collections.Generic;
using MbUnit.Framework;
using PlayingWithActiveReports.Core.Dto;
using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class ResultsSectionTest {
		[Test]
		public void Should_Be_Able_To_Bind_Dtos_To_Report( ) {
			IResultsSection section = CreateSut( );
			IList< DisplayReportQuestionDto > results = new List< DisplayReportQuestionDto >( );
			results.Add( CreateDto( "How are you?", "good" ) );
			results.Add( CreateDto( "How are you?", "bad" ) );
			results.Add( CreateDto( "How are you?", "hungry" ) );

			section.BindTo( results );
			Assert.AreEqual( 3, section.ResultsCount );
		}

		[Test]
		public void Should_Have_No_Results( ) {
			Assert.AreEqual( 0, CreateSut( ).ResultsCount );
		}

		private DisplayReportQuestionDto CreateDto( string question, string answer ) {
			return new DisplayReportQuestionDto( question, answer );
		}

		private IResultsSection CreateSut( ) {
			return new ResultsSection( );
		}
	}
}