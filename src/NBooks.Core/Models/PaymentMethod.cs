//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PaymentMethod : BaseModel<PaymentMethod>
	{
		public virtual string Name { get; set; }
		public virtual int Type { get; set; }
		public virtual bool Inactive { get; set; }
		
		public PaymentMethod()
		{
		}
	}
	
	public delegate void PaymentMethodEventHandler(PaymentMethod sender, EventArgs e);
}
