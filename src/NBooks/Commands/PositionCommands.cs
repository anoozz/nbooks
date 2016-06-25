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
	public class ListPositions : AbstractCommand
	{
		public override void Run()
		{
			PositionListForm form = new PositionListForm();
			IPositionRepository dao = new NHibernatePositionDao();
			form.PositionsList += delegate { form.Positions = dao.FindActive(); };
			form.PositionAdd += delegate { new AddPosition().Run(); };
			form.PositionEdit += delegate(object sender, PositionEventArgs e) { 
				new EditPosition(e.Position).Run();
			};
			form.PositionDelete += delegate(object sender, PositionEventArgs e) { 
				dao.Delete(e.Position);
			};
			form.PositionMakeInactive += delegate(object sender, PositionEventArgs e) { 
				dao.MakeInactive(e.Position);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPosition : AbstractCommand
	{
		public override void Run()
		{
			PositionForm form = new PositionForm();
			IPositionRepository dao = new NHibernatePositionDao();
			form.PositionSave += delegate(object sender, PositionEventArgs e) { 
				dao.SaveOrUpdate(e.Position);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPosition : AbstractCommand
	{
		Position position;
		
		public EditPosition(Position position)
		{
			this.position = position;
		}
		
		public override void Run()
		{
			PositionForm form = new PositionForm(position);
			IPositionRepository dao = new NHibernatePositionDao();
			form.PositionSave += delegate(object sender, PositionEventArgs e) { 
				dao.SaveOrUpdate(e.Position);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Position");
		}
	}
}
