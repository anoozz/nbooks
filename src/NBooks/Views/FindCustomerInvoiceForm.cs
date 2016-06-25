//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class FindCustomerInvoiceForm : BaseForm
	{
		IList<Invoice> invoices;
		
		public IList<Invoice> SelectedInvoices {
			get {
				IList<Invoice> selectedInvoices = new List<Invoice>();
				foreach (ListViewItem li in listViewInvoices.SelectedItems) {
					selectedInvoices.Add(invoices[li.Index]);
				}
				return selectedInvoices;
			}
		}
		
		public IList<Invoice> Invoices {
			get { return invoices; }
			set { 
				invoices = value; 
				listViewInvoices.Items.Clear();
				foreach (var i in invoices) {
					ListViewItem li = listViewInvoices.Items.Add(i.Customer != null ? i.Customer.Name : "");
					li.SubItems.Add("");
					li.SubItems.Add(i.Account != null ? i.Account.Name : "");
					li.SubItems.Add("");
					li.SubItems.Add(i.Id.ToString());
					li.SubItems.Add(i.Date.ToShortDateString());
					li.SubItems.Add(i.TotalAmount.ToString("###,##0.00"));
					li.SubItems.Add(i.Memo);
				}
			}
		}
		
		public FindCustomerInvoiceForm()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListInvoices != null) ListInvoices(this, null);
		}
		
		public event EventHandler ListInvoices;
		
		void ButtonSearchClick(object sender, EventArgs e)
		{
			
		}
	}
}
