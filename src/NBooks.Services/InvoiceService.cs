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
using NBooks.Core.Dao;
using NBooks.Core.Model;
using NBooks.Core.Model.Formatter;
using NBooks.Core.Service;
using NBooks.Core.Util;

namespace NBooks.Services
{
	/// <summary>
	/// Description of InvoiceService.
	/// </summary>
	public class InvoiceService : IInvoiceService
	{
		IInvoiceDao dao;
		IPrinter printer;
		IInvoiceFormatter formatter;
		
		public InvoiceService(IInvoiceDao dao) : this(dao, null, null)
		{
		}
		
		public InvoiceService(IInvoiceDao dao, IPrinter printer, IInvoiceFormatter formatter)
		{
			this.dao = dao;
			this.printer = printer;
			this.formatter = formatter;
		}
		
		public void SaveOrUpdate(Invoice invoice)
		{
			foreach (var item in invoice.Items) {
				item.Item.OnHand -= item.Quantity;
			}
			invoice.Customer.Balance += invoice.TotalAmount;
			if (invoice.Account != null) invoice.Account.Balance += invoice.TotalAmount;
			dao.SaveOrUpdate(invoice);
		}
		
		public void Delete(Invoice t)
		{
			dao.Delete(t);
		}
		
		public Invoice Read(int id)
		{
			return dao.Read(id);
		}
		
		public IList<Invoice> FindAll()
		{
			return dao.FindAll();
		}
		
		public void Print(Invoice invoice)
		{
			if (printer != null && formatter != null) {
				printer.Print(formatter.Format(invoice));
			}
		}
		
		public void Email(Invoice invoice)
		{
			// TODO: Email invoice
		}
		
		public IList<Invoice> FindOpen()
		{
			return dao.FindOpen();
		}
		
		public IList<Invoice> FindByCustomer(Customer customer)
		{
			return dao.FindByCustomer(customer);
		}
	}
}
