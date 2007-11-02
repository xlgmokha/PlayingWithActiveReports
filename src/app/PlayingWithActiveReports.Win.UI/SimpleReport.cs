using DataDynamics.ActiveReports;

namespace PlayingWithActiveReports.Win.UI {
	public partial class SimpleReport : ActiveReport3 {
		public SimpleReport( ) {
			InitializeComponent( );

			this.detail.Format += delegate { detail.AddBookmark( uxQuestionText.Value.ToString( ) ); };
		}
	}
}