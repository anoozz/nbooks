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
	public class AddSalesReceipt : AbstractCommand
	{
		public override void Run()
		{
			SalesReceiptForm receiptForm = new SalesReceiptForm();
			SalesReceiptItemForm itemForm = new SalesReceiptItemForm();
			
			ISalesReceiptRepository receiptDao = new NHibernateSalesReceiptDao();
			IVehicleTripRepository tripDao = new NHibernateVehicleTripDao();
			IAccountRepository accountDao = new NHibernateAccountDao();
			ICustomerRepository customerDao = new NHibernateCustomerDao();
			IPaymentMethodRepository methodDao =  new NHibernatePaymentMethodDao();
			IItemRepository itemDao = new NHibernateItemDao();
			
			receiptForm.VehicleTripsList += delegate { receiptForm.VehicleTrips = tripDao.FindAll(); };
			receiptForm.ListAccounts += delegate { receiptForm.Accounts = accountDao.FindIncomeAccounts(); };
			receiptForm.PaymentMethodsList += delegate { receiptForm.PaymentMethods = methodDao.FindActive(); };
			receiptForm.CustomersList += delegate { receiptForm.Customers = customerDao.FindActive(); };
			itemForm.ItemFind += delegate(object sender, ItemEventArgs e) { 
				IList<Item> items = itemDao.FindByName(e.Item.Name);
				if (items.Count == 1) {
					itemForm.ReceiptItem.Item = items[0];
				} else {
					
				}
			};
			receiptForm.ItemAdding += delegate(object sender, SalesReceiptItemEventArgs e) { 
				itemForm.ReceiptItem = e.ReceiptItem;
				if (WorkbenchSingleton.AddDialog(itemForm) == DialogResult.OK) {
					receiptForm.SalesReceipt.AddItem(itemForm.ReceiptItem);
				}
			};
			receiptForm.SalesReceiptSaveAndClose += delegate(object sender, SalesReceiptEventArgs e) { 
				receiptDao.SaveOrUpdate(e.SalesReceipt);
				receiptForm.Close();
			};
			WorkbenchSingleton.AddChild(receiptForm);
		}
	}
	
	public class EditSalesReceipt : AbstractCommand
	{
		SalesReceipt receipt;
		
		public EditSalesReceipt(SalesReceipt receipt)
		{
			this.receipt = receipt;
		}
		
		public override void Run()
		{
			SalesReceiptForm form = new SalesReceiptForm();
			ISalesReceiptRepository receiptDao = new NHibernateSalesReceiptDao();
			IVehicleTripRepository tripDao = new NHibernateVehicleTripDao();
			ICustomerRepository customerDao = new NHibernateCustomerDao();
			IPaymentMethodRepository methodDao =  new NHibernatePaymentMethodDao();
			
			form.VehicleTripsList += delegate { form.VehicleTrips = tripDao.FindAll(); };
			form.PaymentMethodsList += delegate { form.PaymentMethods = methodDao.FindActive(); };
			form.CustomersList += delegate { form.Customers = customerDao.FindActive(); };
			form.SalesReceiptSaveAndClose += delegate(object sender, SalesReceiptEventArgs e) { 
				receiptDao.SaveOrUpdate(e.SalesReceipt);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
}
