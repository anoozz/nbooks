﻿//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IEmployeeTypeRepository : IBaseRepository<EmployeeType>
	{
		void MakeInactive(EmployeeType type);
		IList<EmployeeType> FindActive();
	}
}
