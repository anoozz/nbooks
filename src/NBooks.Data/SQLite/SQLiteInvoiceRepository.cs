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
	public class SQLiteInvoiceRepository : SQLiteRepository<Invoice>, IInvoiceRepository
	{
		public SQLiteInvoiceRepository()
		{
		}
		
		public DataSet FindOpenDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from invoices where status = 0", "invoices", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from customers where inactive = 0", "customers", ds);
			return ds;
		}
		
		public IList<Invoice> FindOpen()
		{
			throw new NotImplementedException();
		}
		
		public IList<Invoice> FindByCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
