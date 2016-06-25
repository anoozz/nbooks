//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NUnit.Framework;

namespace NBooks.Tests.Models
{
	[TestFixture]
	public class PayrollCodeTests
	{
		[Test]
		public void TestMethod()
		{
			foreach (var p in PayrollCode.CreateForTheYear(2010)) {
				Console.WriteLine(p.Code + ", " + p.DateFrom.ToShortDateString() + ", " + p.DateTo.ToShortDateString());
			}
		}
	}
}
