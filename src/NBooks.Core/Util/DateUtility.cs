//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;

namespace NBooks.Core.Util
{
	public static class DateUtility
	{
		public static bool IsValid(DateTime date)
		{
			try {
				DateTimePicker dt = new DateTimePicker();
				dt.Value = date;
			} catch { return false; }
			return true;
		}
		
		public static DateTime GetValid(DateTime date)
		{
			return IsValid(date) ? date : DateTime.Now;
		}
	}
}
