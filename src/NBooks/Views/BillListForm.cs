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
	public partial class BillListForm : BaseForm
	{
		IList<Bill> bills;
		
		public IList<Bill> Bills {
			get { return bills; }
			set { 
				bills = value;
				listView1.Items.Clear();
				foreach (var b in bills) {
					ListViewItem li = listView1.Items.Add(b.Vendor.Name);
					li.SubItems.Add(b.Id.ToString());
					li.SubItems.Add(b.Date.ToShortDateString());
					li.SubItems.Add(b.DueDate.ToShortDateString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public BillListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width + columnHeader4.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			enterBillsToolStripMenuItem.Click += delegate { new AddBill().Run(); };
			editTransactionToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					if (EditBill != null) EditBill(bills[listView1.SelectedItems[0].Index], null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListBills != null) ListBills(this, null);
		}
		
		public event EventHandler ListBills;
		public event EventHandler<BillEventArgs> EditBill;
	}
}
