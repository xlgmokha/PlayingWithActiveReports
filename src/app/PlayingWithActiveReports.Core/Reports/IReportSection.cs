using System.Collections.Generic;

namespace PlayingWithActiveReports.Core.Reports {
	public interface IReportSection {
		int ParametersCount { get; }
		string Name { get; }
		void BindTo( IEnumerable< IReportParameter > parameters );
		IReportSection WithName( string name );
	}
}