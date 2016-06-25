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
	public class ListVendorTypes : AbstractCommand
	{
		public override void Run()
		{
			var form = new VendorTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddVendorType : AbstractCommand
	{
		public override void Run()
		{
			var form = new VendorTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditVendorType : AbstractCommand
	{
		VendorType type;
		
		public EditVendorType(VendorType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			var form = new VendorTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
