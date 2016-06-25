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
	public class ListPriceLevels : AbstractCommand
	{
		public override void Run()
		{
			var form = new PriceLevelListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPriceLevel : AbstractCommand
	{
		public override void Run()
		{
			var form = new PriceLevelForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPriceLevel : AbstractCommand
	{
		PriceLevel level;
		
		public EditPriceLevel(PriceLevel level)
		{
			this.level = level;
		}
		
		public override void Run()
		{
			var form = new PriceLevelForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
