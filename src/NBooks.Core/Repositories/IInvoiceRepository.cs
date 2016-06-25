//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using System.Data;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IInvoiceRepository : IBaseRepository<Invoice>
	{
		IList<Invoice> FindOpen();
		DataSet FindOpenDS();
		IList<Invoice> FindByCustomer(Customer customer);
	}
}
