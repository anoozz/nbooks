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
	public class ListModules : AbstractCommand
	{
		public override void Run()
		{
			var form = new ModuleListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddModule : AbstractCommand
	{
		public override void Run()
		{
			var form = new ModuleForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditModule : AbstractCommand
	{
		Module module;
		
		public EditModule(Module module)
		{
			this.module = module;
		}
		
		public override void Run()
		{
			var form = new ModuleForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
