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
	public class ListShippingMethods : AbstractCommand
	{
		public override void Run()
		{
			var form = new ShippingMethodListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddShippingMethod : AbstractCommand
	{
		public override void Run()
		{
			var form = new ShippingMethodForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditShippingMethod : AbstractCommand
	{
		ShippingMethod method;
		
		public EditShippingMethod(ShippingMethod method)
		{
			this.method = method;
		}
		
		public override void Run()
		{
			var form = new ShippingMethodForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
