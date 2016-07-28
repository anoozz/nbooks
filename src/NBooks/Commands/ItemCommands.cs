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
	public class ListItems : AbstractCommand
	{
		public override void Run()
		{
			ItemListForm form = new ItemListForm();
			IItemRepository dao = new NHibernateItemRepository();
			form.ItemsList += delegate { form.Items = dao.FindActive(); };
			form.ItemAdd += delegate { new AddItem().Run(); };
			form.ItemEdit += delegate(object sender, ItemEventArgs e) { 
				new EditItem(e.Item).Run();
			};
			form.ItemDelete += delegate(object sender, ItemEventArgs e) { 
				dao.Delete(e.Item);
			};
			form.ItemMakeInactive += delegate(object sender, ItemEventArgs e) { 
				dao.MakeInactive(e.Item);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddItem : AbstractCommand
	{
		public override void Run()
		{
			ItemForm form = new ItemForm();
			IItemRepository itemRepository = new NHibernateItemRepository();
			IUnitRepository unitRepository = new NHibernateUnitRepository();
			IVendorRepository vendorRepository = new NHibernateVendorRepository();
			
			form.UnitsList += delegate { form.Units = unitRepository.FindActive(); };
			form.VendorsList += delegate { form.Vendors = vendorRepository.FindActive(); };
			form.ItemSave += delegate(object sender, ItemEventArgs e) { 
				itemRepository.SaveOrUpdate(e.Item);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditItem : AbstractCommand
	{
		Item item;
		
		public EditItem(Item item)
		{
			this.item = item;
		}
		
		public override void Run()
		{
			ItemForm form = new ItemForm(item);
			IItemRepository itemDao = new NHibernateItemRepository();
			IUnitRepository unitDao = new NHibernateUnitRepository();
			IVendorRepository vendorDao = new NHibernateVendorRepository();
			
			form.UnitsList += delegate { form.Units = unitDao.FindActive(); };
			form.VendorsList += delegate { form.Vendors = vendorDao.FindActive(); };
			form.ItemSave += delegate(object sender, ItemEventArgs e) { 
				itemDao.SaveOrUpdate(e.Item);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Item");
		}
	}
}
