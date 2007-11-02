using DataDynamics.ActiveReports;

namespace PlayingWithActiveReports.Core.Reports {
	internal class ReportFooterAdapter : IReportFooter {
		public ReportFooterAdapter( Section section ) {
			_section = section;
		}

		public string Name {
			get { return _section.Name; }
		}

		private readonly Section _section;
	}
}