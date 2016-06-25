//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Loan : Transaction<Loan>
	{
		public virtual Employee Employee { get; set; }
		
		public Loan()
		{
		}
	}
	
	public delegate void LoanEventHandler(Loan sender, EventArgs e);
}
