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
	public class ListSalesReps : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesRepListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddSalesRep : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesRepForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditSalesRep : AbstractCommand
	{
		SalesRep salesRep;
		
		public EditSalesRep(SalesRep salesRep)
		{
			this.salesRep = salesRep;
		}
		
		public override void Run()
		{
			var form = new SalesRepForm(salesRep);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
