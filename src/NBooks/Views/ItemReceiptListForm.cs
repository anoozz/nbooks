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
	public partial class ItemReceiptListForm : BaseForm
	{
		IList<ItemReceipt> receipts;
		
		public IList<ItemReceipt> ItemReceipts {
			get { return receipts; }
			set { 
				receipts = value;
				listView1.Items.Clear();
				foreach (var r in receipts) {
					ListViewItem li = listView1.Items.Add(r.Vendor.Name);
					li.SubItems.Add(r.Id.ToString());
					li.SubItems.Add(r.Date.ToShortDateString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public ItemReceiptListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width); };
			enterItemReceiptsToolStripMenuItem.Click += delegate { new AddItemReceipt().Run(); };
			editTransactionToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditItemReceipt(receipts[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editTransactionToolStripMenuItem.PerformClick(); };
			closeToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						CloseItemReceipt(receipts[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListItemReceipts != null) ListItemReceipts(this, null);
		}
		
		public event EventHandler ListItemReceipts;
		public event ItemReceiptEventHandler CloseItemReceipt;
	}
}
