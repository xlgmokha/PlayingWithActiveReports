namespace PlayingWithActiveReports.Core.Dto {
	public class DisplayReportQuestionDto {
		public DisplayReportQuestionDto( string text, string answer ) {
			_text = text;
			_answer = answer;
		}

		public string Text {
			get { return _text; }
		}

		public string Answer {
			get { return _answer; }
		}

		private readonly string _answer;
		private readonly string _text;
	}
}