//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListRoutes : AbstractCommand
	{
		public override void Run()
		{
			var form = new RouteListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddRoute : AbstractCommand
	{
		public override void Run()
		{
			var form = new RouteForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditRoute : AbstractCommand
	{
		Route route;
		
		public EditRoute(Route route)
		{
			this.route = route;
		}
		
		public override void Run()
		{
			var form = new RouteForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
