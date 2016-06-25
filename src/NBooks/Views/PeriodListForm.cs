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
	public partial class PeriodListForm : BaseForm
	{
		IList<Period> periods;
		
		public IList<Period> Periods {
			get { return periods; }
			set { 
				periods = value;
				listView1.Items.Clear();
				foreach (var p in periods) {
					ListViewItem li = listView1.Items.Add(p.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PeriodListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddPeriod().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditPeriod(periods[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeletePeriod(periods[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactivePeriod(periods[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPeriods != null) ListPeriods(this, e);
		}
		
		public event EventHandler ListPeriods;
		public event PeriodEventHandler DeletePeriod;
		public event PeriodEventHandler MakeInactivePeriod;
	}
}
