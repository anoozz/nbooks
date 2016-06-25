//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class LoanType : BaseModel<LoanType>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public LoanType()
		{
		}
	}
	
	public delegate void LoanTypeEventHandler(LoanType sender, EventArgs e);
}
