//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlLoanRepository : MySqlRepository<Loan>, ILoanRepository
	{
		public MySqlLoanRepository()
		{
		}
	}
}
