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
	public class SQLiteTermsRepository : SQLiteRepository<Terms>, ITermsRepository
	{
		public SQLiteTermsRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from terms where inactive = 0", "terms", ds);
			return ds;
		}
		
		public void MakeInactive(Terms terms)
		{
			throw new NotImplementedException();
		}
		
		public IList<Terms> FindActive()
		{
			throw new NotImplementedException();
		}
	}
}
