using System.Collections.Generic;
using MbUnit.Framework;
using PlayingWithActiveReports.Core.Reports;
using Rhino.Mocks;
using Rhino.Mocks.Constraints;

namespace PlayingWithActiveReports.Test.Reports {
	[TestFixture]
	public class MainReportTest {
		[SetUp]
		public void Setup( ) {
			_mockery = new MockRepository( );
		}

		[Test]
		public void Should_Call_Build_On_Builders_When_Run( ) {
			IList< ISectionBuilder > builders = new List< ISectionBuilder >( );
			ISectionBuilder stubBuilder1 = _mockery.Stub< ISectionBuilder >( );
			ISectionBuilder stubBuilder2 = _mockery.Stub< ISectionBuilder >( );
			ISectionBuilder stubBuilder3 = _mockery.Stub< ISectionBuilder >( );

			builders.Add( stubBuilder1 );
			builders.Add( stubBuilder2 );
			builders.Add( stubBuilder3 );

			using( _mockery.Record( ) ) {
				stubBuilder1.BuildFrom( null );
				LastCall.Constraints( Is.NotNull( ) );

				stubBuilder2.BuildFrom( null );
				LastCall.Constraints( Is.NotNull( ) );

				stubBuilder3.BuildFrom( null );
				LastCall.Constraints( Is.NotNull( ) );
			}

			using( _mockery.Playback( ) ) {
				IMainReport report = CreateSut( builders ).Run( );
			}
		}

		[Test]
		public void Should_Be_Able_To_Find_Section_By_Name( ) {
			IReportSection stubSection = _mockery.Stub< IReportSection >( );
			using( _mockery.Record( ) ) {
				SetupResult.For( stubSection.Name ).Return( "sectionName" );
			}

			using( _mockery.Playback( ) ) {
				IMainReport report = CreateSut( );
				report.AddSection( stubSection );
				Assert.AreEqual( stubSection, report.FindBy(
				                              	new Specification< IReportSection >(
				                              		delegate( IReportSection section ) { return section.Name == "sectionName"; }
				                              		) ) );
			}
		}

		private IMainReport CreateSut( IList< ISectionBuilder > builders ) {
			return new MainReport( builders );
		}

		private IMainReport CreateSut( ) {
			return new MainReport( );
		}

		private MockRepository _mockery;
	}
}