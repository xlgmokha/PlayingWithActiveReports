using System;
using System.Collections.Generic;
using DataDynamics.ActiveReports;
using PlayingWithActiveReports.Core.Dto;

namespace PlayingWithActiveReports.Core.Reports {
	public partial class ResultsSection : ActiveReport3, IResultsSection {
		public ResultsSection( ) {
			InitializeComponent( );
			_results = new List< DisplayReportQuestionDto >( );
		}

		public int ResultsCount {
			get { return _results.Count; }
		}

		public IResultsSection BindTo( IEnumerable< DisplayReportQuestionDto > results ) {
			_results = ( null == results )
			           	? new List< DisplayReportQuestionDto >( )
			           	: new List< DisplayReportQuestionDto >( results );
			return this;
		}

		public int ParametersCount {
			get { throw new NotImplementedException( ); }
		}

		public void BindTo( IEnumerable< IReportParameter > parameters ) {
			throw new NotImplementedException( );
		}

		public IReportSection WithName( string name ) {
			throw new NotImplementedException( );
		}

		private IList< DisplayReportQuestionDto > _results;
	}
}