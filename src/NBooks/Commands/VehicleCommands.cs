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
	public class ListVehicles : AbstractCommand
	{
		public override void Run()
		{
			VehicleListForm form = new VehicleListForm();
			IVehicleRepository dao = new NHibernateVehicleRepository();
			form.VehiclesList += delegate { form.Vehicles = dao.FindActive(); };
			form.VehicleAdd += delegate { new AddVehicle().Run(); };
			form.VehicleEdit += delegate(object sender, VehicleEventArgs e) { 
				new EditVehicle(e.Vehicle).Run();
			};
			form.VehicleDelete += delegate(object sender, VehicleEventArgs e) { 
				dao.Delete(e.Vehicle);
			};
			form.VehicleMakeInactive += delegate(object sender, VehicleEventArgs e) { 
				dao.MakeInactive(e.Vehicle);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddVehicle : AbstractCommand
	{
		public override void Run()
		{
			VehicleForm form = new VehicleForm();
			IVehicleRepository dao = new NHibernateVehicleRepository();
			form.VehicleSave += delegate(object sender, VehicleEventArgs e) { 
				dao.SaveOrUpdate(e.Vehicle);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditVehicle : AbstractCommand
	{
		Vehicle vehicle;
		
		public EditVehicle(Vehicle vehicle)
		{
			this.vehicle = vehicle;
		}
		
		public override void Run()
		{
			VehicleForm form = new VehicleForm(vehicle);
			IVehicleRepository dao = new NHibernateVehicleRepository();
			form.VehicleSave += delegate(object sender, VehicleEventArgs e) { 
				dao.SaveOrUpdate(e.Vehicle);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Vehicle");
		}
	}
}
