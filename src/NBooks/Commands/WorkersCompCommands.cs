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
	public class ListWorkersComps : AbstractCommand
	{
		public override void Run()
		{
			var form = new WorkersCompListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddWorkersComp : AbstractCommand
	{
		public override void Run()
		{
			var form = new WorkersCompForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditWorkersComp : AbstractCommand
	{
		WorkersComp comp;
		
		public EditWorkersComp(WorkersComp comp)
		{
			this.comp = comp;
		}
		
		public override void Run()
		{
			var form = new WorkersCompForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
