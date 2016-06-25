//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Models;

namespace NBooks.Data.MySql
{
	public class MySqlEstimateRepository : MySqlRepository<Estimate>, IEstimateRepository
	{
		public MySqlEstimateRepository()
		{
		}
	}
}
