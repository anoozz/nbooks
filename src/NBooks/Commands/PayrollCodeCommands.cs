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
	public class ListPayrollCodes : AbstractCommand
	{
		public override void Run()
		{
			var form = new PayrollCodeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPayrollCode : AbstractCommand
	{
		public override void Run()
		{
			var form = new PayrollCodeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPayrollCode : AbstractCommand
	{
		PayrollCode code;
		
		public EditPayrollCode(PayrollCode code)
		{
			this.code = code;
		}
		
		public override void Run()
		{
			var form = new PayrollCodeForm(code);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
