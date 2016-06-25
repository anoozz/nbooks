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
	public class ListPaymentMethods : AbstractCommand
	{
		public override void Run()
		{
			var form = new PaymentMethodListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPaymentMethod : AbstractCommand
	{
		public override void Run()
		{
			var form = new PaymentMethodForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPaymentMethod : AbstractCommand
	{
		PaymentMethod method;
		
		public EditPaymentMethod(PaymentMethod method)
		{
			this.method = method;
		}
		
		public override void Run()
		{
			var form = new PaymentMethodForm(method);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
