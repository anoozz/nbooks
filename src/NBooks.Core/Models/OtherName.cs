//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class OtherName : Stakeholder<OtherName>
	{
		public OtherName()
		{
		}
	}
	
	public delegate void OtherNameEventHandler(OtherName sender, EventArgs e);
}
