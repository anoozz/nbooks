//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Diagnostics;

namespace NBooks.Core.Util
{
	public class ProcessUtility
	{
		public ProcessUtility()
		{
		}
		
		public static bool CheckInstance(string processName)
		{
			return Process.GetProcessesByName(processName).Length > 1;
		}
	}
}
