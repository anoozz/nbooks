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
	public class UserTests
	{
		[Test]
		public void TestMethod()
		{
			Module receivables = new Module("Accounts Receivable");
			receivables.AddCommand("Add Purchase Order", "AddPurchaseOrder");
			receivables.AddCommand("Add Item Receipt", "AddItemReceipt");
			receivables.AddCommand("Add Bill", "AddBill");
			
			Module payables = new Module("Accounts Payable");
		}
	}
}
