/*
 * Created by SharpDevelop.
 * User: Ian
 * Date: 7/28/2016
 * Time: 12:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NBooks.Commands;
using NUnit.Framework;

namespace NBooks.Tests.Commands
{
	[TestFixture]
	public class ItemCommandsTests
	{
		AddItem a;
		
		[SetUp]
		public void Setup()
		{
			a = new AddItem();
		}
		
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
		}
	}
}
