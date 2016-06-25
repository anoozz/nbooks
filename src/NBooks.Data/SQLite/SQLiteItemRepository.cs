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
	public class SQLiteItemRepository : SQLiteRepository<Item>, IItemRepository
	{
		public SQLiteItemRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from items where inactive = 0", "items", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from vendors where inactive = 0", "vendors", ds);
			return ds;
		}
		
		public void MakeInactive(Item item)
		{
			throw new NotImplementedException();
		}
		
		public IList<Item> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public IList<Item> FindByName(string name)
		{
			throw new NotImplementedException();
		}
		
		public Item ReadByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
