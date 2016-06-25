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
	public partial class OtherNameListForm : BaseForm
	{
		IList<OtherName> names;
		
		public IList<OtherName> OtherNames {
			get { return names; }
			set { 
				names = value;
				listView1.Items.Clear();
				foreach (var n in names) {
					ListViewItem li = listView1.Items.Add(n.Name);
					li.SubItems.Add(n.Notes);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public OtherNameListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddOtherName().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditOtherName(names[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteOtherName(names[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveOtherName(names[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListOtherNames != null) ListOtherNames(this, e);
		}
		
		public event EventHandler ListOtherNames;
		public event OtherNameEventHandler DeleteOtherName;
		public event OtherNameEventHandler MakeInactiveOtherName;
	}
}
