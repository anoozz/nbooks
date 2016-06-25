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
	public class ListSubCategories : AbstractCommand
	{
		public override void Run()
		{
			var form = new SubCategoryListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddSubCategory : AbstractCommand
	{
		public override void Run()
		{
			var form = new SubCategoryForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditSubCategory : AbstractCommand
	{
		SubCategory category;
		
		public EditSubCategory(SubCategory category)
		{
			this.category = category;
		}
		
		public override void Run()
		{
			var form = new SubCategoryForm(category);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
