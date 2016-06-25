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
	public partial class PurchaseOrderListForm : BaseForm
	{
		IList<PurchaseOrder> orders;
		
		public IList<PurchaseOrder> PurchaseOrders {
			get { return orders; }
			set { 
				orders = value; 
				listView1.Items.Clear();
				foreach (PurchaseOrder o in orders) {
					ListViewItem li = listView1.Items.Add(o.Vendor != null ? o.Vendor.Name : "");
					li.SubItems.Add(o.Id.ToString());
					li.SubItems.Add(o.Date.ToShortDateString());
					li.SubItems.Add(o.DeliveryDate.ToShortDateString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public PurchaseOrderListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width + columnHeader4.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			createPurchaseOrdersToolStripMenuItem.Click += delegate { new AddPurchaseOrder().Run(); };
			editTransactionToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditPurchaseOrder(orders[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editTransactionToolStripMenuItem.PerformClick(); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListPurchaseOrders != null) ListPurchaseOrders(this, e);
		}
		
		public event EventHandler ListPurchaseOrders;
	}
}
