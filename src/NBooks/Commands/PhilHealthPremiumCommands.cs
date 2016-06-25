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
	public class ListPhilHealthPremiums : AbstractCommand
	{
		public override void Run()
		{
			var form = new PhilHealthPremiumListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPhilHealthPremium : AbstractCommand
	{
		public override void Run()
		{
			var form = new PhilHealthPremiumForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPhilHealthPremium : AbstractCommand
	{
		PhilHealthPremium premium;
		
		public EditPhilHealthPremium(PhilHealthPremium premium)
		{
			this.premium = premium;
		}
		
		public override void Run()
		{
			var form = new PhilHealthPremiumForm(premium);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
