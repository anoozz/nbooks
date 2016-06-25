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
	public class PeriodTests
	{
		[Test]
		public void TestMethod()
		{
			Period p = new Period();
			p.Name = "Period 1";
			p.DateFrom = DateTime.Now;
			p.DateTo = DateTime.Now.AddDays(10);
			
			Category c1 = new Category("Category 1");
			Category c2 = new Category("Category 2");
			Category c3 = new Category("Category 3");
//			c1.SaveOrUpdate();
//			c2.SaveOrUpdate();
//			c3.SaveOrUpdate();
			
			p.AddCategory(c1, 500);
			p.AddCategory(c2, 456);
			p.AddCategory(c3, 222);
//			p.SaveOrUpdate();
		}
	}
}
