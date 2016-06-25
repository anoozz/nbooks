//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using System.Data;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IVendorRepository : IBaseRepository<Vendor>
	{
		void MakeInactive(Vendor vendor);
		IList<Vendor> FindActive();
		DataSet FindActiveDS();
	}
}
