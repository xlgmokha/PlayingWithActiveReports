using System.Collections.Generic;
using PlayingWithActiveReports.Core.Dto;

namespace PlayingWithActiveReports.Core.Reports {
	public interface IResultsSection : IReportSection {
		int ResultsCount { get; }
		IResultsSection BindTo( IEnumerable< DisplayReportQuestionDto > results );
	}
}