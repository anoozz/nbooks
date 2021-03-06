﻿//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using System.Data;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface ITermsRepository : IBaseRepository<Terms>
	{
		void MakeInactive(Terms terms);
		IList<Terms> FindActive();
		DataSet FindActiveDS();
	}
}
