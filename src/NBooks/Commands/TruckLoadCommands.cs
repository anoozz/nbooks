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
	public class ListTruckLoads : AbstractCommand
	{
		public override void Run()
		{
			var form = new TruckLoadListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddTruckLoad : AbstractCommand
	{
		public override void Run()
		{
			var form = new TruckLoadForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditTruckLoad : AbstractCommand
	{
		TruckLoad load;
		
		public EditTruckLoad(TruckLoad load)
		{
			this.load = load;
		}
		
		public override void Run()
		{
			var form = new TruckLoadForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
