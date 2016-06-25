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
	public partial class InvoiceListForm : BaseForm
	{
		IList<Invoice> invoices;
		
		public IList<Invoice> Invoices {
			get { return invoices; }
			set { 
				invoices = value;
				listView1.Items.Clear();
				foreach (var i in invoices) {
					ListViewItem li = listView1.Items.Add(i.Customer != null ? i.Customer.Name : "");
					li.SubItems.Add(i.Id.ToString());
					li.SubItems.Add(i.Date.ToShortDateString());
					li.SubItems.Add("");
					li.SubItems.Add("");
					li.SubItems.Add(i.TotalAmount.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public InvoiceListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			createInvoicesToolStripMenuItem.Click += delegate { new AddInvoice().Run(); };
			editTransactionToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditInvoice(invoices[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editTransactionToolStripMenuItem.PerformClick(); };
			closeToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						CloseInvoice(invoices[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		public event EventHandler ListInvoices;
		public event InvoiceEventHandler CloseInvoice;
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListInvoices != null) ListInvoices(this, null);
		}
	}
}
