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
using NBooks.Core.Model;

namespace NBooks.Core.View
{
	public interface ICustomerView : IView
	{
		Customer Customer { get; set; }
		IList<JobType> JobTypes { get; set; }
		IList<Terms> Terms { get; set; }
		IList<CustomerType> CustomerTypes { get; set; }
		IList<PriceLevel> PriceLevels { get; set; }
		IList<PaymentMethod> PaymentMethods { get; set; }
		IList<SalesTaxCode> SalesTaxCodes { get; set; }
		event CustomerEventHandler SaveCustomer;
		event EventHandler ListPaymentMethods;
		event EventHandler ListSalesTaxCodes;
		event EventHandler ListCustomerTypes;
		event EventHandler ListJobTypes;
		event EventHandler ListTerms;
		event EventHandler ListPriceLevels;
	}
	
	public interface ICustomerListView
	{
		IList<Customer> Customers { get; set; }
		event EventHandler ListCustomers;
		event CustomerEventHandler DeleteCustomer;
		event CustomerEventHandler MakeInactiveCustomer;
	}
	
	public interface IFindCustomerInvoicesView
	{
		IList<Invoice> Invoices { get; set; }
		IList<Invoice> SelectedInvoices { get; }
		event EventHandler ListInvoices;
	}
}
