//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class CategoryForm : BaseForm
	{
		Category category;
		
		public Category Category {
			get {
				category.Name = textBoxName.Text;
				category.Inactive = checkBoxInactive.Checked;
				return category;
			}
			set { 
				category = value;
				textBoxName.Text = category.Name;
				checkBoxInactive.Checked = category.Inactive;
			}
		}
		
		public CategoryForm() : this(new Category())
		{
		}
		
		public CategoryForm(Category category)
		{
			InitializeComponent();
			this.Category = category;
		}
		
		public event CategoryEventHandler CategorySave;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (CategorySave != null) {
				CategorySave(Category, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
