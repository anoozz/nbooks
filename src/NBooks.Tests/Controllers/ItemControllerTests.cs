//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Controllers;
using NBooks.Core.Repositories;
using NBooks.Core.Views;
using NBooks.Tests.Models;
using NBooks.Views;
using NUnit.Framework;

namespace NBooks.Tests.Controllers
{
	[TestFixture]
	public class ItemControllerTests
	{
		ItemController c;
		
		[SetUp]
		public void Setup()
		{
			c = new ItemController(new ItemRepositoryStub(), new ItemForm());
		}
		
		[Test]
		public void TestMethod()
		{
			c.Add();
		}
	}
}
