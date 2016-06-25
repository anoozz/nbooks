//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Gui;
using NBooks.Core.Util;

namespace NBooks.Commands
{
	public class CloseAllChildren : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.Workbench.CloseAllChildren();
		}
	}
	
	public class TileHorizontally : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.MainForm.LayoutMdi(MdiLayout.TileHorizontal);
		}
	}
	
	public class TileVertically : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.MainForm.LayoutMdi(MdiLayout.TileVertical);
		}
	}
	
	public class CascadeWindows : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.MainForm.LayoutMdi(MdiLayout.Cascade);
		}
	}
	
	public class ArrangeIcons : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.MainForm.LayoutMdi(MdiLayout.ArrangeIcons);
		}
	}
}
