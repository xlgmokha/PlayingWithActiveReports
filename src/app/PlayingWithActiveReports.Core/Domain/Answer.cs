using System;

namespace PlayingWithActiveReports.Core.Domain {
	public class Answer : IAnswer, IEquatable< Answer > {
		public Answer( string answerText ) {
			_answerText = answerText;
		}

		public string Text {
			get { return _answerText; }
		}

		public bool Equals( Answer answer ) {
			if( answer == null ) {
				return false;
			}
			return Equals( _answerText, answer._answerText );
		}

		public override bool Equals( object obj ) {
			if( ReferenceEquals( this, obj ) ) {
				return true;
			}
			return Equals( obj as Answer );
		}

		public override int GetHashCode( ) {
			return _answerText != null ? _answerText.GetHashCode( ) : 0;
		}

		private readonly string _answerText;
	}
}