// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Drawing;
using System.Windows.Forms;
using NBooks.Core.Util;

namespace NBooks.Core.Gui
{
	/// <summary>
	/// Description of WorkbenchSingleton.
	/// </summary>
	public class WorkbenchSingleton
	{
		static IWorkbench workbench;
		
		public static Form MainForm {
			get { return workbench as Form; }
		}
		
		public static IWorkbench Workbench {
			get { return workbench; }
		}
		
		public WorkbenchSingleton()
		{
		}
		
		public static void UnFreezeControlForLogin()
		{
			workbench.UnFreezeControlForLogin();
		}
		
		public static void FreezeControlForLogin()
		{
			workbench.FreezeControlForLogin();
		}
		
		public static void Attach(IWorkbench workbench)
		{
			WorkbenchSingleton.workbench = workbench;
			
			Form form = workbench as Form;
			form.Location = new Point((int)RegistryUtility.GetValue("X", 100), (int)RegistryUtility.GetValue("Y", 100));
			form.Size = new Size((int)RegistryUtility.GetValue("Width", 800), (int)RegistryUtility.GetValue("Height", 600));
			form.WindowState = GetWindowState((string)RegistryUtility.GetValue("WindowState", "Normal"));
			form.Closed += delegate { 
				RegistryUtility.SetValue("X", form.Location.X);
				RegistryUtility.SetValue("Y", form.Location.Y);
				RegistryUtility.SetValue("Width", form.Size.Width);
				RegistryUtility.SetValue("Height", form.Size.Height);
				RegistryUtility.SetValue("WindowState", form.WindowState);
			};
		}
		
		static FormWindowState GetWindowState(string state)
		{
			switch (state) {
				case "Minimized":
					return FormWindowState.Minimized;
				case "Maximized":
					return FormWindowState.Maximized;
				default:
					return FormWindowState.Normal;
			}
		}
		
		public static void ToogleOpenWindowList()
		{
		}
		
		public static void ToogleIconBar()
		{
		}
		
		public static void AddChild(Form form, string text)
		{
			form.Text = text;
			AddChild(form);
		}
		
		public static void AddChild(Form form)
		{
			workbench.AddChild(form);
		}
		
		public static DialogResult AddDialog(Form form, string text)
		{
			form.Text = text;
			return AddDialog(form);
		}
		
		public static DialogResult AddDialog(Form form)
		{
			return AddDialog(form, FormStartPosition.CenterParent);
		}
		
		public static DialogResult AddDialog(Form form, FormStartPosition position)
		{
//			form.MinimizeBox = form.MaximizeBox = form.ShowInTaskbar = false;
//			form.StartPosition = position;
//			form.FormBorderStyle = FormBorderStyle.FixedDialog;
//			form.KeyPreview = true;
//			form.KeyDown += delegate(object sender, KeyEventArgs e) { 
//				if (e.KeyCode == Keys.Escape) {
//					form.Close();
//				}
//			};
//			return form.ShowDialog(this);
			return workbench.AddDialog(form, position);
		}
	}
}
