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
	public class ListTaxCodes : AbstractCommand
	{
		public override void Run()
		{
			var form = new TaxCodeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddTaxCode : AbstractCommand
	{
		public override void Run()
		{
			var form = new TaxCodeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditTaxCode : AbstractCommand
	{
		TaxCode code;
		
		public EditTaxCode(TaxCode code)
		{
			this.code = code;
		}
		
		public override void Run()
		{
			var form = new TaxCodeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
