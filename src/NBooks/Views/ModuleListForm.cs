//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ModuleListForm : BaseForm
	{
		IList<Module> modules;
		
		public IList<Module> Modules {
			get { return modules; }
			set {
				modules = value;
				listView1.Items.Clear();
				foreach (Module module in modules) {
					ListViewItem li = listView1.Items.Add(module.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public ModuleListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddModule().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditModule(modules[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteModule(modules[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveModule(modules[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListModules != null) ListModules(this, null);
		}
		
		public event EventHandler ListModules;
		public event ModuleEventHandler DeleteModule;
		public event ModuleEventHandler MakeInactiveModule;
		
		void ModifyToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0) {
				Module module = modules[listView1.SelectedItems[0].Index];
				WorkbenchSingleton.AddChild(new ModuleForm(module), "Edit Module");
			}
		}
	}
}
