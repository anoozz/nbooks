//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class CustomerMessage : BaseModel<CustomerMessage>
	{
		public virtual string Message { get; set; }
		public virtual bool Inactive { get; set; }
		
		public CustomerMessage()
		{
		}
	}
	
	public delegate void CustomerMessageEventHandler(CustomerMessage sender, EventArgs e);
}
