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
	public class MySqlCustomerRepository : MySqlRepository<Customer>, ICustomerRepository
	{
		public MySqlCustomerRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			MySqlUtility.ExecuteDataAdapter(null, "select * from company", "company", ds);
			MySqlUtility.ExecuteDataAdapter(null, "select * from customers where inactive = 0", "customers", ds);
			return ds;
		}
		
		public IList<Customer> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public void MakeInactive(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
