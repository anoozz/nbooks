//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Shift : BaseModel<Shift>
	{
		public virtual string Notes { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual double GracePeriod { get; set; }
		public virtual double RegularHours { get; set; }
		IList<ShiftTime> times = new List<ShiftTime>();
		
		public virtual IList<ShiftTime> Times {
			get { return times; }
			set { times = value; }
		}
		
		public Shift()
		{
		}
		
		public virtual void AddTime(ShiftTime time)
		{
			time.Shift = this;
			times.Insert(0, time);
			if (TimesChanged != null) TimesChanged(this, null);
		}
		
		public virtual void RemoveTime(ShiftTime time)
		{
			if (times.Contains(time)) {
				times.Remove(time);
				if (TimesChanged != null) TimesChanged(this, null);
			}
		}
		
		public virtual event EventHandler TimesChanged;
	}
	
	public class ShiftTime : BaseModel<ShiftTime>
	{
		public virtual Shift Shift { get; set; }
		public virtual int TimeIn { get; set; }
		public virtual int TimeOut { get; set; }
		
		public ShiftTime()
		{
		}
	}
	
	public delegate void ShiftEventHandler(Shift sender, EventArgs e);
	public delegate void ShiftTimeEventHandler(ShiftTime sender, EventArgs e);
}
