namespace PlayingWithActiveReports.Core.Reports {
	public interface ISpecification< T > {
		bool IsSatisfiedBy( T item );
	}
}