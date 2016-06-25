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
	public class SQLitePurchaseOrderRepository : SQLiteRepository<PurchaseOrder>, IPurchaseOrderRepository
	{
		public SQLitePurchaseOrderRepository()
		{
		}
		
		public DataSet FindOpenDS()
		{
			DataSet ds = new DataSet();
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from company", "company", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from purchase_orders where status = 0", "purchase_orders", ds);
			SQLiteUtility.ExecuteDataAdapter(SQLiteRepositoryFactory.GetConnection(), "select * from vendors where inactive = 0", "vendors", ds);
			return ds;
		}
	}
}
