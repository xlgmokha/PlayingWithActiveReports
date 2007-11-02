using System;

namespace PlayingWithActiveReports.Core.Domain {
	public class Question : IQuestion {
		public Question( string id, string text ) {
			_id = id;
			_text = text;
		}

		public Question( string text ) : this( Guid.NewGuid( ).ToString( ), text ) {}

		public string Text {
			get { return _text; }
		}

		public string Id {
			get { return _id; }
		}

		public IAnswer CurrentAnswer {
			get { return new Answer( _answer ); }
		}

		public void ChangeAnswerTo( string answer ) {
			_answer = answer;
		}

		private readonly string _id;
		private readonly string _text;
		private string _answer;
	}
}