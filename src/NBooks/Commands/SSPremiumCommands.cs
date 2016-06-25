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
	public class ListSSPremiums : AbstractCommand
	{
		public override void Run()
		{
			var form = new SSPremiumListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddSSPremium : AbstractCommand
	{
		public override void Run()
		{
			var form = new SSPremiumForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditSSPremium : AbstractCommand
	{
		SSPremium premium;
		
		public EditSSPremium(SSPremium premium)
		{
			this.premium = premium;
		}
		
		public override void Run()
		{
			var form = new SSPremiumForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
