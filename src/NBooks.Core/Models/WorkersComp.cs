//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class WorkersCompEventArgs : EventArgs
	{
		public WorkersComp WorkersComp { get; set; }
		
		public WorkersCompEventArgs(WorkersComp comp)
		{
			this.WorkersComp = comp;
		}
	}
	
	public class WorkersComp : BaseModel<WorkersComp>
	{
		public WorkersComp()
		{
		}
		
		public virtual string Code { get; set; }
		
		public virtual string Description { get; set; }
		
		public virtual double Rate { get; set; }
		
		public virtual DateTime EffectivityDate { get; set; }
		
		public virtual bool Inactive { get; set; }
	}
}
