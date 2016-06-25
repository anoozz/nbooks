//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SSPremium : BaseModel<SSPremium>
	{
		public virtual bool Inactive { get; set; }
		public virtual string Code { get; set; }
		public virtual double RangeFrom { get; set; }
		public virtual double RangeTo { get; set; }
		public virtual double ER { get; set; }
		public virtual double EC { get; set; }
		public virtual double EE { get; set; }
		public virtual double Contribution { get; set; }
		
		public SSPremium()
		{
		}
	}
	
	public delegate void SSPremiumEventHandler(SSPremium sender, EventArgs e);
}
