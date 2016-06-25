//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface ISalesTaxCodeRepository : IBaseRepository<SalesTaxCode>
	{
		void MakeInactive(SalesTaxCode code);
		IList<SalesTaxCode> FindActive();
	}
}
