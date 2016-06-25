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
	public class ListPurchaseOrders : AbstractCommand
	{
		public override void Run()
		{
			var form = new PurchaseOrderListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPurchaseOrder : AbstractCommand
	{
		public override void Run()
		{
			PurchaseOrderForm form = new PurchaseOrderForm();
			IPurchaseOrderRepository orderDao = new NHibernatePurchaseOrderDao();
			IVendorRepository vendorDao = new NHibernateVendorDao();
			
			form.VendorsList += delegate { form.Vendors = vendorDao.FindActive(); };
			form.PurchaseOrderSaveAndClose += delegate(object sender, PurchaseOrderEventArgs e) { 
				orderDao.SaveOrUpdate(e.PurchaseOrder);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPurchaseOrder : AbstractCommand
	{
		PurchaseOrder order;
		
		public EditPurchaseOrder(PurchaseOrder order)
		{
			this.order = order;
		}
		
		public override void Run()
		{
			var form = new PurchaseOrderForm(order);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
