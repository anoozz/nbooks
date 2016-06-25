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
	public class SQLiteEmployeeRepository : SQLiteRepository<Employee>, IEmployeeRepository
	{
		public SQLiteEmployeeRepository()
		{
		}
		
		public void MakeInactive(Employee employee)
		{
			throw new NotImplementedException();
		}
		
		public IList<Employee> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from employees where inactive = 0", "employees", ds);
			return ds;
		}
	}
}
