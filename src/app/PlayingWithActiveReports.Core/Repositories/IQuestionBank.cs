using PlayingWithActiveReports.Core.Domain;

namespace PlayingWithActiveReports.Core.Repositories {
	public interface IQuestionBank : IRepository< IQuestion > {
		int Count { get; }
		IQuestion CreateQuestion( string withText );
	}
}