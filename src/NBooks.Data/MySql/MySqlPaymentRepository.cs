//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Data;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlPaymentRepository : MySqlRepository<Payment>, IPaymentRepository
	{
		public MySqlPaymentRepository()
		{
		}
	}
}
