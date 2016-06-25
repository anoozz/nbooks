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
using NBooks.Core.Util;

namespace NBooks.Core.View
{
	/// <summary>
	/// Description of ISalesReceiptView.
	/// </summary>
	public interface ISalesReceiptView : IView
	{
		SalesReceipt SalesReceipt { get; set; }
		IList<Customer> Customers { get; set; }
		IList<PaymentMethod> PaymentMethods { get; set; }
		IList<CustomerMessage> CustomerMessages { get; set; }
		IList<SalesTaxCode> SalesTaxCodes { get; set; }
		IList<VehicleTrip> VehicleTrips { get; set; }
		IList<Account> Accounts { get; set; }
		event EventHandler ListAccounts;
		event EventHandler ListVehicleTrips;
		event EventHandler ListSalesTaxCodes;
		event EventHandler ListCustomerMessages;
		event EventHandler ListPaymentMethods;
		event EventHandler ListCustomers;
		event SalesReceiptEventHandler SaveSalesReceipt;
		event EventHandler<SalesReceiptEventArgs> SalesReceiptSaveAndClose;
		event SalesReceiptEventHandler SaveSalesReceiptAndClear;
		event SalesReceiptItemEventHandler ItemAdding;
	}
	
	public interface ISalesReceiptListView
	{
		IList<SalesReceipt> SalesReceipts { get; set; }
		event EventHandler ListSalesReceipts;
	}
	
	public interface ISalesReceiptItemView
	{
		SalesReceiptItem ReceiptItem { get; set; }
		event StringEventHandler FindItem;
	}
}
