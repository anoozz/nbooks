//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Category : BaseModel<Category>
	{
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Category()
		{
		}
		
		public Category(string name)
		{
			this.Name = name;
		}
	}
	
	public delegate void CategoryEventHandler(Category sender, EventArgs e);
}
