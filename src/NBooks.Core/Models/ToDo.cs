//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class ToDo : Reminder<ToDo>
	{
		public virtual string Note { get; set; }
		public virtual DateTime RemindOn { get; set; }
		public virtual bool Done { get; set; }
		public virtual bool Inactive { get; set; }
		
		public ToDo()
		{
		}
		
		public override void Validate()
		{
			base.Validate();
			if (Note == "") Errors.Add("Note is required.");
		}
	}
	
	public delegate void ToDoEventHandler(ToDo sender, EventArgs e);
}
