//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Terms : BaseModel<Terms>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Terms()
		{
		}
	}
	
	public class TermsEventArgs : EventArgs
	{
		public Terms Terms { get; set; }
		
		public TermsEventArgs(Terms terms)
		{
			this.Terms = terms;
		}
	}
	
	public delegate void TermsEventHandler(Terms sender, EventArgs e);
}
