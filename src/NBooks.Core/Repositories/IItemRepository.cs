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
	public interface IItemRepository : IBaseRepository<Item>
	{
		void MakeInactive(Item item);
		Item ReadByName(string name);
		IList<Item> FindActive();
		IList<Item> FindByName(string name);
		DataSet FindActiveDS();
	}
}
