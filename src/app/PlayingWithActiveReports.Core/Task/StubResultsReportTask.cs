using System.Collections.Generic;
using PlayingWithActiveReports.Core.Domain;
using PlayingWithActiveReports.Core.Reports;
using PlayingWithActiveReports.Core.Repositories;

namespace PlayingWithActiveReports.Core.Task {
	public class StubResultsReportTask : IResultsReportTask {
		public StubResultsReportTask( ) : this( new QuestionBank( ) ) {}

		public StubResultsReportTask( IQuestionBank bank ) {
			_bank = bank;
		}

		public IResultsReport CreateReport( ) {
			_bank.CreateQuestion( "What is your name?" ).ChangeAnswerTo( "mO" );
			_bank.CreateQuestion( "How old are you?" ).ChangeAnswerTo( "23" );
			return new ResultsReport( ).BindTo( CreateParameters( ) ).Execute( );
		}

		private IEnumerable< IReportParameter > CreateParameters( ) {
			return new List< IQuestion >( _bank.FindAll( ) ).ConvertAll< IReportParameter >(
				delegate( IQuestion input ) { return new ReportParameter( input.Text, input.CurrentAnswer.Text ); }
				);
		}

		private IQuestionBank _bank;
	}
}