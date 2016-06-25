//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Util;

namespace NBooks.Commands
{
	public class OpenWindowListCommand : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.ToogleOpenWindowList();
		}
	}
	
	public class IconBarCommand : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.ToogleIconBar();
		}
	}
}
