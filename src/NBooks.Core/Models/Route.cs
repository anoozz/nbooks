//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Route : BaseModel<Route>
	{
		public virtual string Code { get; set; }
		public virtual string Description { get; set; }
		public virtual bool Inactive { get; set; }
		
		public virtual string CodeAndDescription {
			get { return Code + " - " + Description; }
		}
		
		public Route()
		{
		}
	}
	
	public delegate void RouteEventHandler(Route sender, EventArgs e);
}
