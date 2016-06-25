//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System.Collections.Generic;
using Core.Dao;
using NBooks.Core.Models;

namespace NBooks.Core.Repositories
{
	public interface IVehicleRepository : IBaseRepository<Vehicle>
	{
		void MakeInactive(Vehicle vehicle);
		IList<Vehicle> FindActive();
	}
}
