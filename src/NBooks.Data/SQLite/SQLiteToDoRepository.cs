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
	public class SQLiteToDoRepository : SQLiteRepository<ToDo>, IToDoRepository
	{
		public SQLiteToDoRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from to_dos where inactive = 0", "to_dos", ds);
			return ds;
		}
		
		public void MakeInactive(ToDo todo)
		{
			throw new NotImplementedException();
		}
		
		public IList<ToDo> FindActive()
		{
			throw new NotImplementedException();
		}
	}
}
