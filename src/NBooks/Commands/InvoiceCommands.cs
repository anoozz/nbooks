//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListInvoices : AbstractCommand
	{
		public override void Run()
		{
			var form = new InvoiceListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddInvoice : AbstractCommand
	{
		public override void Run()
		{
			InvoiceForm invoiceForm = new InvoiceForm();
			InvoiceItemForm itemForm = new InvoiceItemForm();
			
			IInvoiceRepository invoiceDao = new NHibernateInvoiceDao();
			IVehicleTripRepository tripDao = new NHibernateVehicleTripDao();
			ICustomerRepository customerDao = new NHibernateCustomerDao();
			IItemRepository itemDao =  new NHibernateItemDao();
			IAccountRepository accountDao = new NHibernateAccountDao();
			
			invoiceForm.VehicleTripsList += delegate { invoiceForm.VehicleTrips = tripDao.FindAll(); };
			invoiceForm.AccountsList += delegate { invoiceForm.Accounts = accountDao.FindAccountsReceivables(); };
			invoiceForm.CustomersList += delegate { invoiceForm.Customers = customerDao.FindActive(); };
			itemForm.ItemFind += delegate(object sender, ItemEventArgs e) { 
				IList<Item> items = itemDao.FindByName(e.Item.Name);
				if (items.Count == 1) {
					itemForm.InvoiceItem.Item = items[0];
				} else {
					// TODO: Add item list of value!
				}
			};
			invoiceForm.ItemAdding += delegate(object sender, InvoiceItemEventArgs e) {
				itemForm.InvoiceItem = e.InvoiceItem;
				if (WorkbenchSingleton.AddDialog(itemForm) == DialogResult.OK) {
					invoiceForm.Invoice.AddItem(itemForm.InvoiceItem);
				}
			};
			invoiceForm.InvoiceSaveAndClose += delegate(object sender, InvoiceEventArgs e) { 
				invoiceDao.SaveOrUpdate(e.Invoice);
				invoiceForm.Close();
			};
			WorkbenchSingleton.AddChild(invoiceForm);
		}
	}
	
	public class EditInvoice : AbstractCommand
	{
		Invoice invoice;
		
		public EditInvoice(Invoice invoice)
		{
			this.invoice = invoice;
		}
		
		public override void Run()
		{
			var form = new InvoiceForm(invoice);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
