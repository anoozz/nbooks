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
	public class AddVehicleTrip : AbstractCommand
	{
		public override void Run()
		{
			VehicleTripForm form = new VehicleTripForm();
			IVehicleTripRepository tripDao = new NHibernateVehicleTripRepository();
			IVehicleRepository vehicleDao = new NHibernateVehicleRepository();
			form.VehiclesList += delegate { form.Vehicles = vehicleDao.FindAll(); };
			form.VehicleTripSaveAndClose += delegate(object sender, VehicleTripEventArgs e) { 
				tripDao.SaveOrUpdate(e.VehicleTrip);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class ListVehicleTrips : AbstractCommand
	{
		public override void Run()
		{
			VehicleTripListForm form = new VehicleTripListForm();
			IVehicleTripRepository dao = new NHibernateVehicleTripRepository();
			form.VehicleTripsList += delegate { form.VehicleTrips = dao.FindAll(); };
			WorkbenchSingleton.AddChild(form);
		}
	}
}
