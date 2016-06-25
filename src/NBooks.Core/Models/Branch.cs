//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Branch : BaseModel<Branch>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Branch()
		{
		}
	}
	
	public delegate void BranchEventHandler(Branch sender, EventArgs e);
}
