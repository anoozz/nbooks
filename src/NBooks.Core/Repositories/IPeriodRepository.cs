//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IPeriodRepository : IBaseRepository<Period>
	{
		void MakeInactive(Period period);
		IList<Period> FindActive();
	}
}
