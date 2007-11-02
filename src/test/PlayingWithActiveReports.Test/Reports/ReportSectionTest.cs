using System.Collections.Generic;
using MbUnit.Framework;
using PlayingWithActiveReports.Core.Reports;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class ReportSectionTest {
		[Test]
		public void Should_Contain_0_Parameters( ) {
			Assert.AreEqual( 0, CreateSut( ).ParametersCount );
		}

		[Test]
		public void Should_Bind_2_Parameters_To_Section( ) {
			IList< IReportParameter > parameters = new List< IReportParameter >( );
			parameters.Add( CreateParameter( "QuestionText", "How Old Are You?" ) );
			parameters.Add( CreateParameter( "AnswerText", "23" ) );

			IReportSection section = CreateSut( );
			section.BindTo( parameters );
			Assert.AreEqual( 2, section.ParametersCount );
		}

		[RowTest]
		[Row( "Questions" )]
		[Row( "Results" )]
		[Row( "Table Of Contents" )]
		public void Should_Set_Section_Name_To( string name ) {
			Assert.AreEqual( name, CreateSut( ).WithName( name ).Name );
		}

		[Test]
		public void Should_Contain_Undefined_Name( ) {
			Assert.AreEqual( "Undefined", CreateSut( ).Name );
		}

		private IReportParameter CreateParameter( string key, string value ) {
			return new ReportParameter( key, value );
		}

		private IReportSection CreateSut( ) {
			return new ReportSection( );
		}
	}
}