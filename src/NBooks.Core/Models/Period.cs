//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Period : BaseModel<Period>
	{
		IList<PeriodCategory> categories = new List<PeriodCategory>();
		public virtual DateTime DateFrom { get; set; }
		public virtual DateTime DateTo { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual string Name { get; set; }
		
		public virtual IList<PeriodCategory> Categories {
			get { return categories; }
			set { categories = value; }
		}
		
		public Period()
		{
		}
		
		public virtual void AddCategory(Category category, double target)
		{
			AddCategory(new PeriodCategory(category, target));
		}
		
		public virtual void AddCategory(PeriodCategory category)
		{
			category.Period = this;
			categories.Add(category);
			if (CategoriesChanged != null) CategoriesChanged(this, null);
		}
		
		public virtual void RemoveCategory(PeriodCategory category)
		{
			if (categories.Contains(category)) {
				categories.Remove(category);
				if (CategoriesChanged != null) CategoriesChanged(this, null);
			}
		}
		
		public virtual event EventHandler CategoriesChanged;
	}
	
	public class PeriodCategory : BaseModel<PeriodCategory>
	{
		public virtual Period Period { get; set; }
		public virtual Category Category { get; set; }
		public virtual double Target { get; set; }
		
		public PeriodCategory()
		{
		}
		
		public PeriodCategory(Category category, double target)
		{
			this.Category = category;
			this.Target = target;
		}
	}
	
	public delegate void PeriodEventHandler(Period period, EventArgs e);
}
