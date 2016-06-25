/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using NBooks.Core.Gui;
using NBooks.Core.Util;

namespace PatientArchiver.Command
{
	public class ExitCommand : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.MainForm.Close();
		}
	}
}
