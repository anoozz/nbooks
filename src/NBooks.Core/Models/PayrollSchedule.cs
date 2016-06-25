//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PayrollSchedule : BaseModel<PayrollSchedule>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual int Frequency { get; set; }
		public virtual DateTime CheckDate { get; set; }
		public virtual DateTime PayPeriodDate { get; set; }
		
		public PayrollSchedule()
		{
		}
	}
	
	public class PayFrequency
	{
		public string Name { get; set; }
		
		public PayFrequency()
		{
		}
	}
	
	public delegate void PayrollScheduleEventHandler(PayrollSchedule sender, EventArgs e);
}
