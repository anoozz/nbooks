//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class Project : BaseModel<Project>
	{
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		
		public Project()
		{
		}
	}
}
