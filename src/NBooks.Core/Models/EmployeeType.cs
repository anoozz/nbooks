//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class EmployeeType : BaseModel<EmployeeType>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public EmployeeType()
		{
		}
	}
	
	public delegate void EmployeeTypeEventHandler(EmployeeType sender, EventArgs e);
}
