//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Department : BaseModel<Department>
	{
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Department()
		{
		}
	}
	
	public class DepartmentEventArgs : EventArgs
	{
		public Department Department { get; set; }
		
		public DepartmentEventArgs(Department department)
		{
			this.Department = department;
		}
	}
	
	public delegate void DepartmentEventHandler(Department sender, EventArgs e);
}
