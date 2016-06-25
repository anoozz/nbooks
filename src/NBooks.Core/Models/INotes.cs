//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace NBooks.Core.Models
{
	public interface INotes
	{
		string Notes { get; set; }
		string Name { get; set; }
	}
}
