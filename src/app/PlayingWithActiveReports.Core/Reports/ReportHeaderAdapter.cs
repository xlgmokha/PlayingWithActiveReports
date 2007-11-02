using DataDynamics.ActiveReports;

namespace PlayingWithActiveReports.Core.Reports {
	public class ReportHeaderAdapter : IReportHeader {
		public ReportHeaderAdapter( Section header ) {
			_header = header;
		}

		public string Name {
			get { return _header.Name; }
		}

		private Section _header;
	}
}