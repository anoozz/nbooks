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
	public class ListCustomerMessages : AbstractCommand
	{
		public override void Run()
		{
			CustomerMessageListForm form = new CustomerMessageListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddCustomerMessage : AbstractCommand
	{
		public override void Run()
		{
			CustomerMessageForm form = new CustomerMessageForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditCustomerMessage : AbstractCommand
	{
		CustomerMessage message;
		
		public EditCustomerMessage(CustomerMessage message)
		{
			this.message = message;
		}
		
		public override void Run()
		{
			CustomerMessageForm form = new CustomerMessageForm(message);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
