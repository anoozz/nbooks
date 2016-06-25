/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 13:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NBooks.Controllers;
using NBooks.Core.Controllers;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Wpf.Views;

namespace NBooks.Wpf.Commands
{
	public class AddVehicle : AbstractCommand
	{
		public override void Run()
		{
			IVehicleController controller = new VehicleController(
				new VehicleWindow(),
				new NHibernateVehicleDao()
			);
		}
	}
}
