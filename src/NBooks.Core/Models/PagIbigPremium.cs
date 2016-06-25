//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PagIbigPremium : BaseModel<PagIbigPremium>
	{
		public virtual string Code { get; set; }
		public virtual string Description { get; set; }
		public virtual double RangeFrom { get; set; }
		public virtual double RangeTo { get; set; }
		public virtual double PS { get; set; }
		public virtual double ES { get; set; }
		public virtual double Contribution { get; set; }
		public virtual bool Inactive { get; set; }
		
		public PagIbigPremium()
		{
		}
	}
	
	public delegate void PagIbigPremiumEventHandler(PagIbigPremium sender, EventArgs e);
}
