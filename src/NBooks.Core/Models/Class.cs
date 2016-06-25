//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Class : BaseModel<Class>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Class()
		{
		}
	}
	
	public delegate void ClassEventHandler(Class sender, EventArgs e);
}
