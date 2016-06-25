//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IVendorTypeRepository : IBaseDao<VendorType>
	{
		void MakeInactive(VendorType type);
		IList<VendorType> FindActive();
	}
}
