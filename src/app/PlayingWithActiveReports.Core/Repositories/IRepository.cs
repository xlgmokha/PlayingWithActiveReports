using System.Collections.Generic;

namespace PlayingWithActiveReports.Core.Repositories {
	public interface IRepository< T > {
		IEnumerable< T > FindAll( );
	}
}