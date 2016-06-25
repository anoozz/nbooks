//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IToDoRepository : IBaseRepository<ToDo>
	{
		void MakeInactive(ToDo todo);
		IList<ToDo> FindActive();
	}
}
