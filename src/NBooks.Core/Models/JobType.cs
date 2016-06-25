//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class JobType : BaseModel<JobType>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public JobType()
		{
		}
	}
	
	public delegate void JobTypeEventHandler(JobType sender, EventArgs e);
}
