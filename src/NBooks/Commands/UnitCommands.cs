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
	public class ListUnits : AbstractCommand
	{
		public override void Run()
		{
			UnitListForm form = new UnitListForm();
			IUnitRepository dao = new NHibernateUnitRepository();
			form.UnitsList += delegate { form.Units = dao.FindActive(); };
			form.UnitAdd += delegate { new AddUnit().Run(); };
			form.UnitEdit += delegate(object sender, UnitEventArgs e) { 
				new EditUnit(e.Unit).Run();
			};
			form.UnitDelete += delegate(object sender, UnitEventArgs e) { 
				dao.Delete(e.Unit);
			};
			form.UnitMakeInactive += delegate(object sender, UnitEventArgs e) { 
				dao.MakeInactive(e.Unit);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddUnit : AbstractCommand
	{
		public override void Run()
		{
			UnitForm form = new UnitForm();
			IUnitRepository dao = new NHibernateUnitRepository();
			form.UnitSave += delegate(object sender, UnitEventArgs e) { 
				dao.SaveOrUpdate(e.Unit);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditUnit : AbstractCommand
	{
		Unit unit;
		
		public EditUnit(Unit unit)
		{
			this.unit = unit;
		}
		
		public override void Run()
		{
			UnitForm form = new UnitForm(unit);
			IUnitRepository dao = new NHibernateUnitRepository();
			form.UnitSave += delegate(object sender, UnitEventArgs e) { 
				dao.SaveOrUpdate(e.Unit);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Unit");
		}
	}
}
