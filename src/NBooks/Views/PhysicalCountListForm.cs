//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PhysicalCountListForm : BaseForm
	{
		IList<PhysicalCount> counts;
		
		public IList<PhysicalCount> PhysicalCounts {
			get { return counts; }
			set { 
				counts = value;
				listView1.Items.Clear();
				foreach (var c in counts) {
					ListViewItem li = listView1.Items.Add(c.Date.ToShortDateString());
					li.SubItems.Add(c.PreparedBy);
					li.SubItems.Add(c.ApprovedBy);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PhysicalCountListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			addToolStripMenuItem.Click += delegate { WorkbenchSingleton.AddChild(new PhysicalCountForm()); };
			modifyToolStripMenuItem.Click += delegate { ListView1DoubleClick(this,null); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPhysicalCounts != null) ListPhysicalCounts(this, null);
		}
		
		public event EventHandler ListPhysicalCounts;
		public event PhysicalCountEventHandler DeletePhysicalCount;
		
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				PhysicalCount c = counts[listView1.SelectedItems[0].Index];
				WorkbenchSingleton.AddChild(new PhysicalCountForm(c), "Edit Physical Count");
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				foreach (ListViewItem li in listView1.SelectedItems) {
					PhysicalCount c = counts[li.Index];
					DeletePhysicalCount(c, null);
				}
				OnActivated(null);
			}
		}
	}
}
