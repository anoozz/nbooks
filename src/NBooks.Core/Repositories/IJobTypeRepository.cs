//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IJobTypeRepository : IBaseDao<JobType>
	{
		void MakeInactive(JobType type);
		IList<JobType> FindActive();
	}
}
