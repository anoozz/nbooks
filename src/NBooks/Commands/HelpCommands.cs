//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Diagnostics;
using System.IO;

using NBooks.Core.Gui;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ShowHelp : AbstractCommand
	{
		public override void Run()
		{
			Process.Start("http://www.assembla.com/spaces/nbooks/");
		}
	}
	
	public class ShowAbout : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.AddDialog(new AboutForm());
		}
	}
	
	public class GoToUserCommunity : AbstractCommand
	{
		public override void Run()
		{
			Process.Start("http://nbooks.codeplex.com/discussions");
		}
	}
	
	public class ShowUserGuide : AbstractCommand
	{
		public override void Run()
		{
			Process.Start(Path.Combine(ApplicationUtility.DocDirectory, "User Guide.pdf"));
		}
	}
	
	public class GoToSupportServices : AbstractCommand
	{
		public override void Run()
		{
			Process.Start("http://nbooks.codeplex.com/wikipage?title=Help%20%26%20Services");
		}
	}
}
