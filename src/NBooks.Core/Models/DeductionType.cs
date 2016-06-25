//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class DeductionType : BaseModel<DeductionType>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public DeductionType()
		{
		}
	}
	
	public delegate void DeductionTypeEventHandler(DeductionType sender, EventArgs e);
}
