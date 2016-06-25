//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Position : BaseModel<Position>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		
		public Position()
		{
		}
	}
	
	public class PositionEventArgs : EventArgs
	{
		public Position Position { get; set; }
		
		public PositionEventArgs(Position position)
		{
			this.Position = position;
		}
	}
	
	public delegate void PositionEventHandler(Position sender, EventArgs e);
}
