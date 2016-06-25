//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Controllers;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks
{
	public class ControllerFactory
	{
		public ControllerFactory()
		{
		}
		
		public IController CreateController(string name)
		{
			switch (name) {
				case "Item":
					return new ItemController(new NHibernateItemRepository(), new ItemForm());
				default:
					throw new NotSupportedException();
			}
		}
	}
}
