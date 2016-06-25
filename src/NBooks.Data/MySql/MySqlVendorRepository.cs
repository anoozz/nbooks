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

namespace NBooks.Data.MySql
{
	public class MySqlVendorRepository : MySqlRepository<Vendor>, IVendorRepository
	{
		public MySqlVendorRepository()
		{
		}
		
		public override DataSet FindAllDS()
		{
			DataSet ds = new DataSet();
			MySqlUtility.ExecuteDataAdapter(null, "select * from company", "company", ds);
			MySqlUtility.ExecuteDataAdapter(null, "select * from vendors", "vendors", ds);
			return ds;
		}
		
		public IList<Vendor> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public void MakeInactive(Vendor vendor)
		{
			throw new NotImplementedException();
		}
		
		public DataSet FindActiveDS()
		{
			throw new NotImplementedException();
		}
	}
}
