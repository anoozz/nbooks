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
	public class ListSalesTaxCodes : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesTaxCodeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddSalesTaxCode : AbstractCommand
	{
		public override void Run()
		{
			var form = new SalesTaxCodeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditSalesTaxCode : AbstractCommand
	{
		SalesTaxCode code;
		
		public EditSalesTaxCode(SalesTaxCode code)
		{
			this.code = code;
		}
		
		public override void Run()
		{
			var form = new SalesTaxCodeForm(code);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
