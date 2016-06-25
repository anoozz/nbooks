//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SalesRep : Stakeholder<SalesRep>
	{
		public SalesRep()
		{
		}
	}
	
	public delegate void SalesRepEventHandler(SalesRep sender, EventArgs e);
}
