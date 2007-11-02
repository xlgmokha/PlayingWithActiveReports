using System.Collections.Generic;
using DataDynamics.ActiveReports;

namespace PlayingWithActiveReports.Core.Reports {
	public class ReportSection : IReportSection {
		public ReportSection( ) : this( new Section( ) ) {
			_name = "Undefined";
		}

		public ReportSection( Section section ) {
			_name = section.Name;
			_parameters = new List< IReportParameter >( );
		}

		public void BindTo( IEnumerable< IReportParameter > parameters ) {
			_parameters = new List< IReportParameter >( parameters );
		}

		public IReportSection WithName( string name ) {
			_name = name;
			return this;
		}

		public int ParametersCount {
			get { return _parameters.Count; }
		}

		public string Name {
			get { return _name; }
		}

		public static readonly ISpecification< IReportSection > Footer = new Specification< IReportSection >(
			delegate( IReportSection section ) { return section.Name == "Footer"; }
			);

		public static readonly ISpecification< IReportSection > Header = new Specification< IReportSection >(
			delegate( IReportSection section ) { return section.Name == "Header"; } );

		public static ISpecification< IReportSection > Results = new Specification< IReportSection >(
			delegate( IReportSection section ) { return section.Name == "Results"; } );

		private string _name;
		private List< IReportParameter > _parameters;
	}
}