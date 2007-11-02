using System.Collections.Generic;
using MbUnit.Framework;
using PlayingWithActiveReports.Core.Domain;
using PlayingWithActiveReports.Core.Repositories;

namespace PlayingWithActiveReports.Test {
	[TestFixture]
	public class QuestionBankTest {
		[Test]
		public void Should_Be_Able_To_Create_A_New_Question( ) {
			const string withText = "How are you?";
			IQuestionBank bank = CreateSut( );
			IQuestion question = bank.CreateQuestion( withText );

			Assert.AreEqual( withText, question.Text );
			Assert.IsNotNull( question.Id );
		}

		[Test]
		public void Should_Contain_No_Items( ) {
			IEnumerable< IQuestion > allQuestions = CreateSut( ).FindAll( );
			Assert.AreEqual( 0, GetCountFor( allQuestions ) );
		}

		[Test]
		public void Should_Return_Count_Of_2( ) {
			IQuestionBank bank = CreateSut( );
			bank.CreateQuestion( "What is your name?" );
			bank.CreateQuestion( "How old are you?" );

			Assert.AreEqual( 2, bank.Count );
		}

		[RowTest]
		[Row( 1 )]
		[Row( 2 )]
		[Row( 3 )]
		[Row( 4 )]
		public void Should_Return_2_Items( int expectedCount ) {
			IQuestionBank bank = CreateSut( );

			for( int i = 0; i < expectedCount; i++ ) {
				bank.CreateQuestion( "How old are you?" );
			}

			Assert.AreEqual( expectedCount, GetCountFor( bank.FindAll( ) ) );
		}

		private int GetCountFor< T >( IEnumerable< T > items ) {
			return new List< T >( items ).Count;
		}

		private IQuestionBank CreateSut( ) {
			return new QuestionBank( );
		}
	}
}