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
	public interface IEmployeeRepository : IBaseDao<Employee>
	{
		void MakeInactive(Employee employee);
		IList<Employee> FindActive();
		DataSet FindActiveDS();
	}
}
