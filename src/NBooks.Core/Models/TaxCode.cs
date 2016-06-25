//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class TaxCode : BaseModel<TaxCode>
	{
		public virtual string Code { get; set; }
		public virtual string Description { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual double PersonalExemption { get; set; }
		IList<TaxSalaryRange> ranges = new List<TaxSalaryRange>();
		
		public virtual string CodeAndDescription {
			get { return Code + " - " + Description; }
		}
		
		public virtual IList<TaxSalaryRange> Ranges {
			get { return ranges; }
			set { ranges = value; }
		}
		
		public TaxCode()
		{
		}
		
		public virtual void AddRange(TaxSalaryRange range)
		{
			range.TaxCode = this;
			ranges.Add(range);
			if (RangesChanged != null) RangesChanged(this, null);
		}
		
		public virtual event EventHandler RangesChanged;
	}
	
	public class TaxSalaryRange : BaseModel<TaxSalaryRange>
	{
		public virtual TaxCode TaxCode { get; set; }
		public virtual double MonthlyFrom { get; set; }
		public virtual double MonthlyTo { get; set; }
		public virtual double MonthlyTax { get; set; }
		public virtual double SemiMonthlyFrom { get; set; }
		public virtual double SemiMonthlyTo { get; set; }
		public virtual double SemiMonthlyTax { get; set; }
		public virtual double PercentageOver { get; set; }
		
		public TaxSalaryRange()
		{
		}
	}
	
	public delegate void TaxCodeEventHandler(TaxCode sender, EventArgs e);
}
