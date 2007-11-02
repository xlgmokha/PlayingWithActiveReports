using System.Collections.Generic;
using System.Windows.Forms;
using PlayingWithActiveReports.Core.Dto;

namespace PlayingWithActiveReports.Win.UI {
	public partial class SimpleReportView : Form {
		public SimpleReportView( ) {
			InitializeComponent( );

			SimpleReport report = new SimpleReport( );
			report.DataSource = CreateDtosList( );
			report.Run( false );
			this.uxReportViewerControl.Document = report.Document;
		}

		private IEnumerable< DisplayReportQuestionDto > CreateDtosList( ) {
			List< DisplayReportQuestionDto > dtos = new List< DisplayReportQuestionDto >( );
			dtos.Add( new DisplayReportQuestionDto( "How are you?", "good" ) );
			dtos.Add( new DisplayReportQuestionDto( "How old are you?", "23" ) );
			return dtos;
		}
	}
}