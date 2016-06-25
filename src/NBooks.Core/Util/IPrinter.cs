//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Drawing.Printing;

namespace NBooks.Core.Util
{
	public interface IPrinter
	{
		void Print(string str);
	}
}
