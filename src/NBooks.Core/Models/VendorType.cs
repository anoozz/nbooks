//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class VendorTypeEventArgs : EventArgs
	{
		public VendorType Type { get; set; }
		
		public VendorTypeEventArgs(VendorType type)
		{
			this.Type = type;
		}
	}
	
	public class VendorType : BaseModel<VendorType>
	{
		public VendorType()
		{
		}
		
		public virtual string Name { get; set; }
		
		public virtual bool Inactive { get; set; }
	}
}
