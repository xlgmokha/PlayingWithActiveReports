using MbUnit.Framework;
using PlayingWithActiveReports.Core.Domain;

namespace PlayingWithActiveReports.Test {
	[TestFixture]
	public class AnswerTest {
		[Test]
		public void Should_Be_Equal( ) {
			Assert.AreEqual( new Answer( "23" ), new Answer( "23" ) );
		}
	}
}