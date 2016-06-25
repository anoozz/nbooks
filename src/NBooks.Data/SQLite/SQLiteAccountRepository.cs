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
	public class SQLiteAccountRepository : SQLiteRepository<Account>, IAccountRepository
	{
		public SQLiteAccountRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from accounts where inactive = 0", "accounts", ds);
			return ds;
		}
		
		public void MakeInactive(Account account)
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindIncomeAccounts()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindAccountsReceivables()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindAccountsPayables()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindAssetAccounts()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindCogsAccounts()
		{
			throw new NotImplementedException();
		}
	}
}
