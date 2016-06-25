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
	public class ListShifts : AbstractCommand
	{
		public override void Run()
		{
			var form = new ShiftListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddShift : AbstractCommand
	{
		public override void Run()
		{
			var form = new ShiftForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditShift : AbstractCommand
	{
		Shift shift;
		
		public EditShift(Shift shift)
		{
			this.shift = shift;
		}
		
		public override void Run()
		{
			var form = new ShiftForm(shift);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
