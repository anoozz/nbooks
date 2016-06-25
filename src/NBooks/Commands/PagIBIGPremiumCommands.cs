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
	public class ListPagIbigPremiums : AbstractCommand
	{
		public override void Run()
		{
			var form = new PagIbigPremiumListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPagIbigPremium : AbstractCommand
	{
		public override void Run()
		{
			var form = new PagIbigPremiumForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPagIbigPremium : AbstractCommand
	{
		PagIbigPremium premium;
		
		public EditPagIbigPremium(PagIbigPremium premium)
		{
			this.premium = premium;
		}
		
		public override void Run()
		{
			var form = new PagIbigPremiumForm(premium);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
