//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IPositionRepository : IBaseDao<Position>
	{
		void MakeInactive(Position position);
		IList<Position> FindActive();
	}
}
