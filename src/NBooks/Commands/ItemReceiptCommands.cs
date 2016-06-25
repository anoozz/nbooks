//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListItemReceipts : AbstractCommand
	{
		public override void Run()
		{
			var form = new ItemReceiptListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddItemReceipt : AbstractCommand
	{
		public override void Run()
		{
			ItemReceiptForm2 form = new ItemReceiptForm2();
			IItemReceiptRepository receiptDao = new NHibernateItemReceiptRepository();
			IVendorRepository vendorDao = new NHibernateVendorRepository();
			
			form.VendorsList += delegate { form.Vendors = vendorDao.FindActive(); };
			form.ItemReceiptSaveAndClose += delegate(object sender, ItemReceiptEventArgs e) { 
				receiptDao.SaveOrUpdate(e.ItemReceipt);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditItemReceipt : AbstractCommand
	{
		ItemReceipt receipt;
		
		public EditItemReceipt(ItemReceipt receipt)
		{
			this.receipt = receipt;
		}
		
		public override void Run()
		{
			var form = new ItemReceiptForm2(receipt);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
