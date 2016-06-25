//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IPriceLevelRepository : IBaseRepository<PriceLevel>
	{
		void MakeInactive(PriceLevel level);
		IList<PriceLevel> FindActive();
	}
}
