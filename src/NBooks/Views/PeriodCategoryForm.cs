//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of PeriodCategoryForm.
	/// </summary>
	public partial class PeriodCategoryForm : BaseForm
	{
		PeriodCategory category;
		IList<Category> categories;
		
		public IList<Category> Categories {
			get { return categories; }
			set { categories = value; SwfUtility.SetupComboBox(comboBoxCategory, categories, "Id", "Name", category.Category); }
		}
		
		public PeriodCategory Category {
			get { 
				category.Category = SwfUtility.GetComboBoxValue<Category>(comboBoxCategory);
				category.Target = ConvertUtility.ToDouble(textBoxTargetValue.Text);
				return category;
			}
			set { 
				category = value;
				textBoxTargetValue.Text = category.Target.ToString("0.00");
			}
		}
		
		public PeriodCategoryForm() : this(new PeriodCategory())
		{
		}
		
		public PeriodCategoryForm(PeriodCategory category)
		{
			InitializeComponent();
			this.Category = category;
//			Categories = Core.Models.Category.FindActive(); // TODO:
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCategories != null) ListCategories(this, null);
		}
		
		public event EventHandler ListCategories;
	}
}
