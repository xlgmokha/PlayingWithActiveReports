using System;
using System.Collections.Generic;
using DataDynamics.ActiveReports;

namespace PlayingWithActiveReports.Core.Reports {
	public partial class ResultsReport : ActiveReport3, IResultsReport {
		public ResultsReport( ) {
			InitializeComponent( );
			this.pageHeader.Name = HeaderName;
			this.pageFooter.Name = FooterName;
			_parameters = new List< IReportParameter >( );
		}

		public ResultsReport Report {
			get { return this; }
		}

		public int ParametersCount {
			get { return _parameters.Count; }
		}

		//public IResultsReport BindTo< T >( IEnumerable< T > items ) {
		//    DataSource = items;
		//    return this;
		//}

		public IResultsReport Execute( ) {
			Run( false );
			return this;
		}

		public IReportSection FindSectionBy( ISpecification< IReportSection > spectification ) {
			foreach( Section section in Sections ) {
				ReportSection reportSection = new ReportSection( section );
				if( spectification.IsSatisfiedBy( reportSection ) ) {
					return reportSection;
				}
			}
			return null;
		}

		public IResultsReport BindTo( IEnumerable< IReportParameter > parameters ) {
			_parameters = new List< IReportParameter >( parameters );
			return this;
		}

		private void OnFormatDetailSection( object sender, EventArgs e ) {
			//Results.AddBookmark( uxQuestionText.Text );
		}

		private const string FooterName = "Footer";
		private const string HeaderName = "Header";
		private List< IReportParameter > _parameters;
	}
}