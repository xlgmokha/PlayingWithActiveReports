using System.Collections.Generic;
using PlayingWithActiveReports.Core.Reports;
using PlayingWithActiveReports.Test.Reports;

namespace PlayingWithActiveReports.Core.Reports {
	public class MainReport : IMainReport {
		public MainReport( ) : this( new List< ISectionBuilder >( ) ) {}

		public MainReport( IList< ISectionBuilder > builders ) {
			_builders = builders;
			_sections = new List< IReportSection >( );
		}

		public void AddSection( IReportSection section ) {
			_sections.Add( section );
		}

		public IMainReport Run( ) {
			foreach( ISectionBuilder builder in _builders ) {
				builder.BuildFrom( this );
			}
			return this;
		}

		public IReportSection FindBy( ISpecification< IReportSection > criteria ) {
			foreach( IReportSection section in _sections ) {
				if( criteria.IsSatisfiedBy( section ) ) {
					return section;
				}
			}
			return null;
		}

		private readonly IList< ISectionBuilder > _builders;
		private List< IReportSection > _sections;
	}
}