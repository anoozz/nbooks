// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using NBooks.Core.Repositories;
using NBooks.Core.Models;
using NHibernate;

namespace NBooks.Data.NHibernate
{
	public class NHibernateInvoiceRepository : NHibernateRepository<Invoice>, IInvoiceRepository
	{
		public NHibernateInvoiceRepository()
		{
		}
		
		public IList<Invoice> FindOpen()
		{
			IQuery query = NHibernateHelper.OpenSession().CreateQuery("from Invoice where status = :status order by date desc");
			query.SetEnum("status", TransactionStatus.Open);
			return query.List<Invoice>();
		}
		
		public IList<Invoice> FindByCustomer(Customer customer)
		{
			IQuery query = NHibernateHelper.OpenSession().CreateQuery("from Invoice where customer_id = :customer_id and status = :status order by date desc");
			query.SetInt32("customer_id", customer.Id);
			query.SetEnum("status", TransactionStatus.Open);
			return query.List<Invoice>();
		}
		
		public System.Data.DataSet FindOpenDS()
		{
			throw new NotImplementedException();
		}
	}
}
