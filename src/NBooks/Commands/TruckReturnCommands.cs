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
	public class ListTruckReturns : AbstractCommand
	{
		public override void Run()
		{
			var form = new TruckReturnListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddTruckReturn : AbstractCommand
	{
		public override void Run()
		{
			var form = new TruckReturnForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditTruckReturn : AbstractCommand
	{
		TruckReturn _return;
		
		public EditTruckReturn(TruckReturn _return)
		{
			this._return = _return;
		}
		
		public override void Run()
		{
			var form = new TruckReturnForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
