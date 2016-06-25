//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Vehicle : BaseModel<Vehicle>
	{
		public Vehicle()
		{
		}
		
		public virtual string Name { get; set; }
		
		public virtual string Description { get; set; }
		
		public virtual bool Inactive { get; set; }
	}
	
	public class VehicleEventArgs : EventArgs
	{
		public VehicleEventArgs(Vehicle vehicle)
		{
			this.Vehicle = vehicle;
		}
		
		public Vehicle Vehicle { get; set; }
	}
}
