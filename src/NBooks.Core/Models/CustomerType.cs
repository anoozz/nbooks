//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class CustomerType : BaseModel<CustomerType>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public CustomerType()
		{
		}
	}
	
	public delegate void CustomerTypeEventHandler(CustomerType sender, EventArgs e);
}
