//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class FiscalYear : BaseModel<FiscalYear>
	{
		public virtual DateTime DateFrom { get; set; }
		public virtual DateTime DateTo { get; set; }
		public virtual bool Closed { get; set; }
		
		public FiscalYear()
		{
		}
	}
}
