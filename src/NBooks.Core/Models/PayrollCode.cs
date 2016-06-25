//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PayrollCode : BaseModel<PayrollCode>
	{
		public virtual DateTime DateFrom { get; set; }
		public virtual DateTime DateTo { get; set; }
		public virtual string Code { get; set; }
		public virtual bool Inactive { get; set; }
		
		public PayrollCode()
		{
		}
		
		public PayrollCode(string code, DateTime dateFrom, DateTime dateTo)
		{
			this.Code = code;
			this.DateFrom = dateFrom;
			this.DateTo = dateTo;
		}
		
		public static IList<PayrollCode> CreateForTheYear(int year)
		{
			IList<PayrollCode> codes = new List<PayrollCode>();
			for (int i = 1; i <= 12; i++) {
				string _15 = year.ToString() + i.ToString("00") + "15";
				int daysInMonth = DateTime.DaysInMonth(year, i);
				string lastDay = year.ToString() + i.ToString("00") + daysInMonth.ToString();
				codes.Add(new PayrollCode(_15, new DateTime(year, i, 15).AddDays(15), new DateTime(year, i, 15).AddDays(-5)));
//				codes.Add(new PayrollCode(lastDay, new DateTime(year, i, daysInMonth).AddDays(-5), new DateTime(year, i, 11)));
			}
			return codes;
		}
	}
	
	public delegate void PayrollCodeEventHandler(PayrollCode sender, EventArgs e);
}
