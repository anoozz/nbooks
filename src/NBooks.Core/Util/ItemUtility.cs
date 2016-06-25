//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Utils
{
	public class ItemUtility
	{
		public ItemUtility()
		{
		}
		
		public static bool IsEmpty(string name)
		{
			return name.ToUpper().IndexOf("MT") != -1;
		}
	}
}
