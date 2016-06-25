//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Util;
using NUnit.Framework;

namespace NBooks.Tests.Util
{
	[TestFixture]
	public class RegistryUtilityTests
	{
		[Test]
		public void TestMethod()
		{
			RegistryUtility.SetValue("X", 250);
			Console.WriteLine(RegistryUtility.GetValue("X", 100));
		}
	}
}
