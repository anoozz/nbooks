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
	public class ListEmployeeTypes : AbstractCommand
	{
		public override void Run()
		{
			var form = new EmployeeTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddEmployeeType : AbstractCommand
	{
		public override void Run()
		{
			var form = new EmployeeTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditEmployeeType : AbstractCommand
	{
		EmployeeType type;
		
		public EditEmployeeType(EmployeeType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			var form = new EmployeeTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
