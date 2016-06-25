//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Util
{
	public class ConvertUtility
	{
		public ConvertUtility()
		{
		}
		
		public static double ToDouble(object val)
		{
			double ret = 0;
			try { ret = Convert.ToDouble(val); } 
			catch { }
			return ret;
		}
		
		public static int ToInt32(object val)
		{
			int ret = 0;
			try { ret = Convert.ToInt32(val); } 
			catch { }
			return ret;
		}
	}
}
