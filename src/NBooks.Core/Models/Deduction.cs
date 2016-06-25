//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Deduction : Transaction<Deduction>
	{
		public Deduction()
		{
		}
	}
	
	public delegate void DeductionEventHandler(Deduction sender, EventArgs e);
}
