//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	public class AddCheck : AbstractCommand
	{
		public override void Run()
		{
			CheckForm form = new CheckForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
