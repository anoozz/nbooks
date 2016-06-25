//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SalesTaxCode : BaseModel<SalesTaxCode>
	{
		public virtual string Code { get; set; }
		public virtual string Description { get; set; }
		public virtual bool Taxable { get; set; }
		public virtual bool Inactive { get; set; }
		
		public SalesTaxCode()
		{
		}
	}
	
	public delegate void SalesTaxCodeEventHandler(SalesTaxCode sender, EventArgs e);
}
