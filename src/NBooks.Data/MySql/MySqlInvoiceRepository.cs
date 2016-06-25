//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlInvoiceRepository : MySqlRepository<Invoice>, IInvoiceRepository
	{
		public MySqlInvoiceRepository()
		{
		}
		
		public IList<Invoice> FindOpen()
		{
			throw new NotImplementedException();
		}
		
		public IList<Invoice> FindByCustomer(Customer customer)
		{
			throw new NotImplementedException();
		}
		
		public DataSet FindOpenDS()
		{
			throw new NotImplementedException();
		}
	}
}
