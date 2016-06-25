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
	public class MySqlAccountRepository : MySqlRepository<Account>, IAccountRepository
	{
		public MySqlAccountRepository()
		{
		}
		
		public DataSet FindActiveDS()
		{
			DataSet ds = new DataSet();
			MySqlUtility.ExecuteDataAdapter(null, "select * from company", "company", ds);
			MySqlUtility.ExecuteDataAdapter(null, "select * from accounts", "accounts", ds);
			return ds;
		}
		
		public IList<Account> FindActive()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindIncomeAccounts()
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
		
		public IList<Account> FindAccountsReceivables()
		{
			throw new NotImplementedException();
		}
		
		public IList<Account> FindAccountsPayables()
		{
			throw new NotImplementedException();
		}
		
		public void MakeInactive(Account account)
		{
			throw new NotImplementedException();
		}
	}
}
