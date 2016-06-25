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
	public class ListOtherNames : AbstractCommand
	{
		public override void Run()
		{
			var form = new OtherNameListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddOtherName : AbstractCommand
	{
		public override void Run()
		{
			var form = new OtherNameForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditOtherName : AbstractCommand
	{
		OtherName name;
		
		public EditOtherName(OtherName name)
		{
			this.name = name;
		}
		
		public override void Run()
		{
			var form = new OtherNameForm(name);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
