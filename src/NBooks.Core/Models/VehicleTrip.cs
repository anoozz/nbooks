//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public class VehicleTrip : BaseModel<VehicleTrip>
	{
		public VehicleTrip()
		{
		}
		
		public virtual Vehicle Vehicle { get; set; }
		
		public virtual DateTime StartDate { get; set; }
		
		public virtual DateTime EndDate { get; set; }
		
		public virtual string Notes { get; set; }
		
		public virtual bool Inactive { get; set; }
	}
	
	public class VehicleTripEventArgs : EventArgs
	{
		public VehicleTrip VehicleTrip { get; set; }
		
		public VehicleTripEventArgs(VehicleTrip trip)
		{
			this.VehicleTrip = trip;
		}
	}
}
