//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlEmployeeRepository : MySqlRepository<Employee>, IEmployeeRepository
	{
		public MySqlEmployeeRepository()
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
			throw new NotImplementedException();
		}
	}
}
