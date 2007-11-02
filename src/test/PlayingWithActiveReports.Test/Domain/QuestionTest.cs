using MbUnit.Framework;
using PlayingWithActiveReports.Core.Domain;

namespace PlayingWithActiveReports.Test.Domain {
	[TestFixture]
	public class QuestionTest {
		[Test]
		public void Should_Be_Able_To_Change_Answer( ) {
			IQuestion question = new Question( "How old Are You?" );
			question.ChangeAnswerTo( "23" );

			Assert.AreEqual( new Answer( "23" ), question.CurrentAnswer );
		}
	}
}