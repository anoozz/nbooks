//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;

using NBooks.Core.Repositories;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Data.SQLite
{
	public class SQLiteVendorRepository : SQLiteRepository<Vendor>, IVendorRepository
	{
		public SQLiteVendorRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from vendors where inactive = 0", "vendors", ds);
			return ds;
		}
		
		public void MakeInactive(Vendor vendor)
		{
			throw new NotImplementedException();
		}
		
		public IList<Vendor> FindActive()
		{
			throw new NotImplementedException();
		}
	}
}
