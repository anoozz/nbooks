//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IUserRepository : IBaseRepository<User>
	{
		void MakeInactive(User user);
		IList<User> FindActive();
		User ReadByNameAndPassword(string name, string password);
	}
}
