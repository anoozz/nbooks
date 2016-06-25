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
	public class TruckLoadTests
	{
		[Test]
		public void TestMethod()
		{
			TruckLoad load1 = new TruckLoad();
			load1.Customer = new Customer();
			load1.AddItem(new TruckLoadItem(new Item() { Name = "Item A", SalesPrice = 10 }, 1));
			load1.AddItem(new TruckLoadItem(new Item() { Name = "Item B", SalesPrice = 10 }, 2));
			
			TruckLoad load2 = new TruckLoad();
			load2.Customer = new Customer();
			load2.AddItem(new TruckLoadItem(new Item() { Name = "Item A", SalesPrice = 10 }, 1));
			
			TruckReturn ret = new TruckReturn();
			foreach (var l in new TruckLoad[] { load1, load2 }) {
				foreach (var i in l.Items) {
					Console.WriteLine(i.Quantity + " " + i.Item.Name + ", " + i.Amount);
					ret.AddItem(i);
				}
			}
			ret.Items[0].Quantity = 1;
			
			Console.WriteLine("Printing truck return...");
			foreach (var i in ret.Items) {
				Console.WriteLine(i.Quantity + " " + i.Item.Name + ", " + i.Amount);
			}
			
//			ITruckReturnService service = new DummyTruckReturnService();
//			service.SaveOrUpdate(ret);
		}
	}
}
