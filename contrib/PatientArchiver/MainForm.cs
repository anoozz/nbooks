/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using PatientArchiver.Gui;

namespace PatientArchiver
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : BaseForm, IWorkbench
	{
		public MainForm()
		{
			InitializeComponent();
			menuStrip1.Items.AddRange(DefaultMenu.MenuItems);
		}
		
		public event EventHandler Login;
		
		public void AddChild(Form form)
		{
			form.MdiParent = this;
			form.WindowState = FormWindowState.Maximized;
			form.Show();
		}
		
		public void CloseAllChildren()
		{
			foreach (var f in MdiChildren) {
				f.Close();
			}
		}
		
		public void FreezeControlForLogin()
		{
			throw new NotImplementedException();
		}
		
		public void UnFreezeControlForLogin()
		{
			throw new NotImplementedException();
		}
		
		public DialogResult AddDialog(Form form, FormStartPosition position)
		{
			return form.ShowDialog(this);
		}
	}
}
