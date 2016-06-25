//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Configuration;
using System.Data.SQLite;

using NBooks.Core.Repositories;
using NBooks.Data.SQLite;

namespace NBooks.Data
{
	public class SQLiteRepositoryFactory : RepositoryFactory
	{
		static SQLiteConnection connection = null;
		
		static SQLiteRepositoryFactory()
		{
			connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString);
		}
		
		public SQLiteRepositoryFactory()
		{
		}
		
		public static SQLiteConnection GetConnection()
		{
			return connection;
		}
		
		public override IPayrollItemRepository CreatePayrollItemDao()
		{
			return new SQLitePayrollItemRepository();
		}
		
		public override IAccountRepository CreateAccountDao()
		{
			return new SQLiteAccountRepository();
		}
		
		public override IEmployeeRepository CreateEmployeeDao()
		{
			return new SQLiteEmployeeRepository();
		}
		
		public override ITermsRepository CreateTermsDao()
		{
			return new SQLiteTermsRepository();
		}
		
		public override ICustomerRepository CreateCustomerDao()
		{
			return new SQLiteCustomerRepository();
		}
		
		public override IInvoiceRepository CreateInvoiceDao()
		{
			return new SQLiteInvoiceRepository();
		}
		
		public override IItemRepository CreateItemDao()
		{
			return new SQLiteItemRepository();
		}
		
		public override IPurchaseOrderRepository CreatePurchaseOrderDao()
		{
			return new SQLitePurchaseOrderRepository();
		}
		
		public override IToDoRepository CreateToDoDao()
		{
			return new SQLiteToDoRepository();
		}
		
		public override IVendorRepository CreateVendorDao()
		{
			return new SQLiteVendorRepository();
		}
	}
}
