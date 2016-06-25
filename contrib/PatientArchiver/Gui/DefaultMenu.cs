/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Windows.Forms;
using NBooks.Core.Util;
using PatientArchiver.Command;

namespace PatientArchiver.Gui
{
	/// <summary>
	/// Description of DefaultMenu.
	/// </summary>
	public class DefaultMenu
	{
		public static ToolStripItem[] MenuItems {
			get {
				return new ToolStripItem[] {
					new BToolStripMenuItem(
						"File",
						new ToolStripItem[] {
							new BToolStripMenuItem("Exit", new ExitCommand()),
						}
					),
					new BToolStripMenuItem("Clinic"),
					new BToolStripMenuItem("Reports"),
					new BToolStripMenuItem(
						"Window",
						new ToolStripItem[] {
							new BToolStripMenuItem("Arrange Icons"),
							new BToolStripMenuItem("Close All"),
							new ToolStripSeparator(),
							new BToolStripMenuItem("Tile Horizontally"),
							new BToolStripMenuItem("Tile Vertically"),
							new BToolStripMenuItem("Cascade"),
						}
					),
					new BToolStripMenuItem(
						"?",
						new ToolStripItem[] {
							new BToolStripMenuItem("About...")
						}
					),
				};
			}
		}
		
		public DefaultMenu()
		{
		}
	}
}
