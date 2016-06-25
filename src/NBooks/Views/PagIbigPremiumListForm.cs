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
	public partial class PagIbigPremiumListForm : BaseForm
	{
		IList<PagIbigPremium> premiums;
		
		public IList<PagIbigPremium> PagIbigPremiums {
			get { return premiums; }
			set { 
				premiums = value;
				listView1.Items.Clear();
				foreach (var p in premiums) {
					ListViewItem li = listView1.Items.Add(p.Code);
					li.SubItems.Add(p.RangeFrom.ToString("###,##0.00"));
					li.SubItems.Add(p.RangeTo.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PagIbigPremiumListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddPagIbigPremium().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditPagIbigPremium(premiums[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeletePagIbigPremium(premiums[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactivePagIbigPremium(premiums[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPagIbigPremiums != null) ListPagIbigPremiums(this, e);
		}
		
		public event EventHandler ListPagIbigPremiums;
		public event PagIbigPremiumEventHandler DeletePagIbigPremium;
		public event PagIbigPremiumEventHandler MakeInactivePagIbigPremium;
	}
}
