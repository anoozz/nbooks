//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Data;
using System.Collections.Generic;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlItemReceiptRepository : MySqlRepository<ItemReceipt>, IItemReceiptRepository
	{
		public MySqlItemReceiptRepository()
		{
		}
		
		public IList<ItemReceipt> FindOpen()
		{
			throw new NotImplementedException();
		}
	}
}
