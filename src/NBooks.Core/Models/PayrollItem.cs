//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class PayrollItem : BaseModel<PayrollItem>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public PayrollItem()
		{
		}
	}
	
	public delegate void PayrollItemEventHandler(PayrollItem sender, EventArgs e);
}
