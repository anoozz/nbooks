//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Unit : BaseModel<Unit>
	{
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual string Abbreviation { get; set; }
		public virtual string SetName { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Unit()
		{
		}
	}
	
	public class UnitEventArgs : EventArgs
	{
		public Unit Unit { get; set; }
		
		public UnitEventArgs(Unit unit)
		{
			this.Unit = unit;
		}
	}
	
	public delegate void UnitEventHandler(Unit sender, EventArgs e);
}
