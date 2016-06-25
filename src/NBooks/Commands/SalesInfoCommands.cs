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
	public class ListSalesInfos : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesInfoListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddSalesInfo : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesInfoForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditSalesInfo : AbstractCommand
	{
		SalesInfo info;
		
		public EditSalesInfo(SalesInfo info)
		{
			this.info = info;
		}
		
		public override void Run()
		{
			var form = new SalesInfoForm(info);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
