using System.Collections.Generic;
using PlayingWithActiveReports.Core.Dto;

namespace PlayingWithActiveReports.Test.Reports {
	public interface IResultSectionTask {
		IEnumerable< DisplayReportQuestionDto > GetResults( );
	}
}