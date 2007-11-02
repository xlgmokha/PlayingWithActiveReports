namespace PlayingWithActiveReports.Core.Reports {
	public class ReportParameter : IReportParameter {
		public ReportParameter( string key, string value ) {
			_key = key;
			_value = value;
		}

		public string Key {
			get { return _key; }
		}

		public string Value {
			get { return _value; }
		}

		private readonly string _key;
		private readonly string _value;
	}
}