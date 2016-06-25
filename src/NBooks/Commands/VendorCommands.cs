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
	public class PostEndingQuantity : AbstractCommand
	{
		public override void Run()
		{
//			EndingQuantity e = EndingQuantity.ReadByDate(DateTime.Now.AddDays(-1).ToShortDateString());
//			if (e == null) {
//				e = new EndingQuantity();
//				e.Date = DateTime.Now.AddDays(-1).ToShortDateString();
//				IList<Item> items = Item.FindActive();
//				foreach (Item i in items) {
//					e.AddItem(i);
//				}
//				e.SaveOrUpdate();
//			} // TODO:
		}
	}
	
	public class AutoConvertEmptyBottles : AbstractCommand
	{
		public override void Run()
		{
//			string[] codeFrom = {"MTB-C8", "MTB-CL", "MTB-J2J5", "MTB-C 500ML"};
//			string[] codeTo = {"MT-C8", "MT-CL", "MT-J2", "MT-C 500ML"};
//			string[] shells = {"SH-C8", "SH-CL", "SH-CL", "SH-CL"};
//			double[] qtyTo = {24, 12, 12, 24};
//			for (int i = 0; i < codeFrom.Length; i++) {
//				Item itemFrom = Item.ReadByName(codeFrom[i]);
//				if (itemFrom != null) {
//					Item itemTo = Item.ReadByName(codeTo[i]);
//					if (itemTo != null) {
//						if (itemFrom.OnHand > 0) {
//							int toQty = (int)(Math.Abs(itemFrom.OnHand / qtyTo[i]));
//							itemTo.OnHand += toQty;
//							double dummy = toQty * qtyTo[i];
//							itemFrom.OnHand -= dummy;
//							itemFrom.SaveOrUpdate();
//							itemTo.SaveOrUpdate();
//							Item shell = Item.ReadByName(shells[i]);
//							if (shell != null) {
//								shell.OnHand -= toQty;
//								shell.SaveOrUpdate();
//							}
//						}	
//					}
//				}
//			} // TODO:
		}
	}
	
	public class ListVendors : AbstractCommand
	{
		public override void Run()
		{
			VendorListForm form = new VendorListForm();
			IVendorRepository dao = new NHibernateVendorRepository();
			form.VendorsList += delegate { form.Vendors = dao.FindActive(); };
			form.VendorAdd += delegate { new AddVendor().Run(); };
			form.VendorEdit += delegate(object sender, VendorEventArgs e) { 
				new EditVendor(e.Vendor).Run();
			};
			form.VendorDelete += delegate(object sender, VendorEventArgs e) { 
				dao.Delete(e.Vendor);
			};
			form.VendorMakeInactive += delegate(object sender, VendorEventArgs e) { 
				dao.MakeInactive(e.Vendor);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddVendor : AbstractCommand
	{
		public override void Run()
		{
			VendorForm form = new VendorForm();
			IVendorRepository dao = new NHibernateVendorRepository();
			form.VendorSave += delegate(object sender, VendorEventArgs e) { 
				dao.SaveOrUpdate(e.Vendor);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditVendor : AbstractCommand
	{
		Vendor vendor;
		
		public EditVendor(Vendor vendor)
		{
			this.vendor = vendor;
		}
		
		public override void Run()
		{
			VendorForm form = new VendorForm(vendor);
			IVendorRepository dao = new NHibernateVendorRepository();
			form.VendorSave += delegate(object sender, VendorEventArgs e) { 
				dao.SaveOrUpdate(e.Vendor);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Vendor");
		}
	}
}
