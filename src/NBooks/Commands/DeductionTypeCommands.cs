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
	public class ListDeductionTypes : AbstractCommand
	{
		public override void Run()
		{
			DeductionTypeListForm form = new DeductionTypeListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddDeductionType : AbstractCommand
	{
		public override void Run()
		{
			DeductionTypeForm form = new DeductionTypeForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditDeductionType : AbstractCommand
	{
		DeductionType type;
		
		public EditDeductionType(DeductionType type)
		{
			this.type = type;
		}
		
		public override void Run()
		{
			DeductionTypeForm form = new DeductionTypeForm();
			WorkbenchSingleton.AddChild(form, "Edit Deduction Type");
		}
	}
}
