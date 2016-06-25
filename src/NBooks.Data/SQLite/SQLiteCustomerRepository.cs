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
	public class SQLiteCustomerRepository : SQLiteRepository<Customer>, ICustomerRepository
	{
		public SQLiteCustomerRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from customers where inactive = 0", "customers", ds);
			return ds;
		}
		
		public void MakeInactive(Customer customer)
		{
			throw new NotImplementedException();
		}
		
		public IList<Customer> FindActive()
		{
			throw new NotImplementedException();
		}
	}
}
