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
	public class ListCustomerTypes : AbstractCommand
	{
		public override void Run()
		{
			CustomerTypeListForm form = new CustomerTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddCustomerType : AbstractCommand
	{
		public override void Run()
		{
			CustomerTypeForm form = new CustomerTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditCustomerType : AbstractCommand
	{
		CustomerType type;
		
		public EditCustomerType(CustomerType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			CustomerTypeForm form = new CustomerTypeForm();
			WorkbenchSingleton.AddChild(form, "Edit Customer Type");
		}
	}
}
