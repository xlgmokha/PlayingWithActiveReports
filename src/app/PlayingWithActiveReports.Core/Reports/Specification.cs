using System;

namespace PlayingWithActiveReports.Core.Reports {
	public class Specification< T > : ISpecification< T > {
		public Specification( Predicate< T > predicate ) {
			_predicate = predicate;
		}

		public bool IsSatisfiedBy( T item ) {
			return _predicate( item );
		}

		private readonly Predicate< T > _predicate;
	}
}