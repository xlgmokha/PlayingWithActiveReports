namespace PlayingWithActiveReports.Core.Domain {
	public interface IQuestion {
		string Text { get; }
		string Id { get; }
		IAnswer CurrentAnswer { get; }
		void ChangeAnswerTo( string answer );
	}
}