//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface ITaxCodeRepository : IBaseDao<TaxCode>
	{
		void MakeInactive(TaxCode code);
		IList<TaxCode> FindActive();
	}
}
