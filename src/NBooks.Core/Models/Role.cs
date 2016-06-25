//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Role : BaseModel<Role>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Role()
		{
		}
	}
	
	public delegate void RoleEventHandler(Role sender, EventArgs e);
}
