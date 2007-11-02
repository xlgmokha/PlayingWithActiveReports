using System.Collections.Generic;
using System.Collections.ObjectModel;
using PlayingWithActiveReports.Core.Domain;

namespace PlayingWithActiveReports.Core.Repositories {
	public class QuestionBank : IQuestionBank {
		public QuestionBank( ) {
			_questions = new List< IQuestion >( );
		}

		public IEnumerable< IQuestion > FindAll( ) {
			return new ReadOnlyCollection< IQuestion >( _questions );
		}

		public int Count {
			get { return _questions.Count; }
		}

		public IQuestion CreateQuestion( string withText ) {
			IQuestion question = new Question( withText );
			_questions.Add( question );
			return question;
		}

		private IList< IQuestion > _questions;
	}
}