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
	public class MySqlPhysicalCountRepository : MySqlRepository<PhysicalCount>, IPhysicalCountRepository
	{
		public MySqlPhysicalCountRepository()
		{
		}
	}
}
