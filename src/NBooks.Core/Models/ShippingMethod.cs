//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class ShippingMethod : BaseModel<ShippingMethod>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public ShippingMethod()
		{
		}
	}
	
	public delegate void ShippingMethodEventHandler(ShippingMethod sender, EventArgs e);
}
