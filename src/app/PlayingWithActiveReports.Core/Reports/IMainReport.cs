namespace PlayingWithActiveReports.Core.Reports {
	public interface IMainReport {
		void AddSection( IReportSection section );
		IMainReport Run( );
		IReportSection FindBy( ISpecification< IReportSection > criteria );
	}
}