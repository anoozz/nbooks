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
	public class ListPhysicalCounts : AbstractCommand
	{
		public override void Run()
		{
			var form = new PhysicalCountListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddPhysicalCount : AbstractCommand
	{
		public override void Run()
		{
			var form = new PhysicalCountForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPhysicalCount : AbstractCommand
	{
		PhysicalCount count;
		
		public EditPhysicalCount(PhysicalCount count)
		{
			this.count = count;
		}
		
		public override void Run()
		{
			var form = new PhysicalCountForm(count);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
