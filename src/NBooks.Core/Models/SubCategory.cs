//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SubCategory : BaseModel<SubCategory>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public SubCategory()
		{
		}
	}
	
	public delegate void SubCategoryEventHandler(SubCategory sender, EventArgs e);
}
