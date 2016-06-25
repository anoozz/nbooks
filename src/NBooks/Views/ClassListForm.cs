//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ClassListForm : BaseForm
	{
		IList<Class> classes;
		
		public IList<Class> Classes {
			get { return classes; }
			set { 
				classes = value;
				listView1.Items.Clear();
				foreach (var c in classes) {
					ListViewItem li = listView1.Items.Add(c.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public ClassListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddClass().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditClass(classes[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						ClassDelete(classes[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						ClassMakeInactive(classes[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ClassesList != null) {
				ClassesList(this, e);
			}
		}
		
		public event EventHandler ClassesList;
		public event ClassEventHandler ClassMakeInactive;
		public event ClassEventHandler ClassDelete;
	}
}
