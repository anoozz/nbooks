//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Configuration;
using NBooks.Core.Repositories;

namespace NBooks.Data
{
	public class RepositoryFactory
	{
		public RepositoryFactory()
		{
		}
		
		public static RepositoryFactory GetDaoFactory()
		{
			switch (ConfigurationManager.AppSettings["dao"]) {
				case "sqlite":
					return new SQLiteRepositoryFactory();
				case "mysql":
					return new MySqlRepositoryFactory();
				default:
					throw new NotImplementedException();
			}
		}
		
		public virtual IPayrollItemRepository CreatePayrollItemDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IAccountRepository CreateAccountDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IEmployeeRepository CreateEmployeeDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual ITermsRepository CreateTermsDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IInvoiceRepository CreateInvoiceDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IToDoRepository CreateToDoDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IPurchaseOrderRepository CreatePurchaseOrderDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual ICustomerRepository CreateCustomerDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IVendorRepository CreateVendorDao()
		{
			throw new NotImplementedException();
		}
		
		public virtual IItemRepository CreateItemDao()
		{
			throw new NotImplementedException();
		}
	}
}
