//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Data;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IPayrollItemRepository : IBaseDao<PayrollItem>
	{
		DataSet FindActiveDS();
	}
}
