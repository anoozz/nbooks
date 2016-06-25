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
	public class ListCategories : AbstractCommand
	{
		public override void Run()
		{
			CategoryListForm form = new CategoryListForm();
			form.CategoriesList += delegate { 
				form.Categories = Category.FindAll();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddCategory : AbstractCommand
	{
		public override void Run()
		{
			CategoryForm form = new CategoryForm();
			form.CategorySave += delegate(Category sender, EventArgs e) { 
				form.Category.SaveOrUpdate();
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditCategory : AbstractCommand
	{
		Category category;
		
		public EditCategory(Category category)
		{
			this.category = category;
		}
		
		public override void Run()
		{
			CategoryForm form = new CategoryForm(category);
			form.CategorySave += delegate(Category sender, EventArgs e) { 
				form.Category.SaveOrUpdate();
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
}
