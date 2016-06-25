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
	public class MySqlItemRepository : MySqlRepository<Item>, IItemRepository
	{
		public MySqlItemRepository()
		{
		}
		
		public IList<Item> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			MySqlUtility.ExecuteDataAdapter(null, "select * from company", "company", ds);
			MySqlUtility.ExecuteDataAdapter(null, "select * from items where inactive = 0", "items", ds);
			return ds;
		}
		
		public IList<Item> FindByName(string name)
		{
			throw new NotImplementedException();
		}
		
		public void MakeInactive(Item item)
		{
			throw new NotImplementedException();
		}
		
		public Item ReadByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
