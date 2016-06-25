//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Timesheet : BaseModel<Timesheet>
	{
		public virtual Employee Employee { get; set; }
		public virtual DateTime Date { get; set; }
		public virtual bool In { get; set; }
		
		public virtual string Type {
			get { return In ? "Time In" : "Time Out"; }
		}
		
		public Timesheet()
		{
		}
		
		public Timesheet(Employee employee)
		{
			this.Employee = employee;
		}
		
		public override void Validate()
		{
			base.Validate();
			if (Employee == null) Errors.Add("Employee is required!");
		}
	}
	
	public delegate void TimesheetEventHandler(Timesheet sender, EventArgs e);
}
