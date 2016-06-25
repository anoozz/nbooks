﻿//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;

using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IAccountRepository : IBaseDao<Account>
	{
		void MakeInactive(Account account);
		IList<Account> FindActive();
		IList<Account> FindIncomeAccounts();
		IList<Account> FindAccountsReceivables();
		IList<Account> FindAccountsPayables();
		IList<Account> FindAssetAccounts();
		IList<Account> FindCogsAccounts();
		DataSet FindActiveDS();
	}
}
