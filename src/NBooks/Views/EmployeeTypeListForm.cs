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
	public partial class EmployeeTypeListForm : BaseForm
	{
		IList<EmployeeType> types;
		
		public IList<EmployeeType> EmployeeTypes {
			get { return types; }
			set { 
				types = value;
				listView1.Items.Clear();
				foreach (var t in types) {
					ListViewItem li = listView1.Items.Add(t.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public EmployeeTypeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddEmployeeType().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditEmployeeType(types[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteEmployeeType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveEmployeeType(types[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListEmployeeTypes != null) ListEmployeeTypes(this, null);
		}
		
		public event EventHandler ListEmployeeTypes;
		public event EmployeeTypeEventHandler DeleteEmployeeType;
		public event EmployeeTypeEventHandler MakeInactiveEmployeeType;
	}
}
