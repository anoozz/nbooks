//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Diagnostics;
using NBooks.Core.Util;

namespace NBooks.Commands
{
	public class UseCalculator : AbstractCommand
	{
		public override void Run()
		{
			Process.Start("calc");
		}
	}
}
