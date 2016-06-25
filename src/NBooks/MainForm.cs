//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Views;
using NBooks.Util;

namespace NBooks
{
	public partial class MainForm : BaseForm, IWorkbench
	{
		IMenu menu;
		
		public IMenu WorkbenchMenu {
			get { 
				return menu;
			}
			set { 
				menu = value;
				menuStrip.Items.AddRange(menu.CreateMenuItems());
				toolStrip1.Items.AddRange(menu.CreateToolBarButtons());
				menuStrip.MdiWindowListItem = menu.WindowMenuItem;
			}
		}
		
		public MainForm() : this(ApplicationUtility.ProductNameAndVersion)
		{
		}
		
		public MainForm(string text)
		{
			InitializeComponent();
			this.Text = text;
		}
		
		public event EventHandler Login;
		
//		public void Login()
//		{
//			FreezeControlForLogin();
//			using (var f = new LoginForm(CompanySingleton.Instance)) {
//				f.CheckUser += delegate(User sender, EventArgs e) { 
//					User dummy = User.ReadByNameAndPassword(sender.Name, sender.Password);
//					if (dummy == null) {
//						MessageService.ShowWarning(ResourceUtility.GetString("user.invalidPassword"));
//						f.ClearPassword();
//					} else {
//						UserSingleton.Instance = dummy;
//						f.DialogResult = DialogResult.OK;
//						f.Close();
//						new ShowHomePage().Run();
//					}
//				};
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.Cancel) {
//					Close();
//				}
//			}
//			UnFreezeControlForLogin();
//		}
		
		public void AddChild(Form form, string text)
		{
			form.Text = text;
			AddChild(form);
		}
		
		public void CloseAllChildren()
		{
			foreach (var f in MdiChildren) {
				f.Close();
			}
		}
		
		public void AddChild(Form form)
		{
			form.MdiParent = this;
			openWindowListPane1.AddForm(form);
			form.WindowState = FormWindowState.Maximized;
			form.KeyPreview = true;
			form.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Escape) {
					form.Close();
				}
			};
			form.Show();
		}
		
		public void FreezeControlForLogin()
		{
			menuStrip.Enabled = toolStrip1.Visible = openWindowListPane1.Visible = false;
		}
		
		public void UnFreezeControlForLogin()
		{
			menuStrip.Enabled = toolStrip1.Visible = openWindowListPane1.Visible = true;
		}
		
		public DialogResult AddDialog(Form form, string text)
		{
			form.Text = text;
			return AddDialog(form);
		}
		
		public DialogResult AddDialog(Form form)
		{
			return AddDialog(form, FormStartPosition.CenterParent);
		}
		
		public DialogResult AddDialog(Form form, FormStartPosition position)
		{
			form.MinimizeBox = form.MaximizeBox = form.ShowInTaskbar = false;
			form.StartPosition = position;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.KeyPreview = true;
			form.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Escape) {
					form.Close();
				}
			};
			return form.ShowDialog(this);
		}
		
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.Visible = true;
			if (Login != null) Login(this, null);
		}
	}
}
