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
	public class ListPeriods : AbstractCommand
	{
		public override void Run()
		{
			var form = new PeriodListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPeriod : AbstractCommand
	{
		public override void Run()
		{
			var form = new PeriodForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPeriod : AbstractCommand
	{
		Period period;
		
		public EditPeriod(Period period)
		{
			this.period = period;
		}
		
		public override void Run()
		{
			var form = new PeriodForm(period);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
