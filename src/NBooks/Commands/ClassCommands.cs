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
	public class ListClasses : AbstractCommand
	{
		public override void Run()
		{
			ClassListForm form = new ClassListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddClass : AbstractCommand
	{
		public override void Run()
		{
			ClassForm form = new ClassForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditClass : AbstractCommand
	{
		Class clas;
		
		public EditClass(Class clas)
		{
			this.clas = clas;
		}
		
		public override void Run()
		{
			ClassForm form = new ClassForm(clas);
			WorkbenchSingleton.AddChild(form, "Edit Class");
		}
	}
}
