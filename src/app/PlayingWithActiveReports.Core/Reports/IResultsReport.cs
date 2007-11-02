using System.Collections.Generic;

namespace PlayingWithActiveReports.Core.Reports {
	public interface IResultsReport {
		ResultsReport Report { get; }
		int ParametersCount { get; }
		IResultsReport BindTo( IEnumerable< IReportParameter > parameters );
		IResultsReport Execute( );
		IReportSection FindSectionBy( ISpecification< IReportSection > spectification );
	}
}