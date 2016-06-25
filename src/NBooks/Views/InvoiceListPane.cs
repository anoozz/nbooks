//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of InvoiceListPane.
	/// </summary>
	public partial class InvoiceListPane : BaseUserControl
	{
		IList<Invoice> invoices;
		
		public IList<Invoice> Invoices {
			get { return invoices; }
			set {
				invoices = value;
				listView1.Items.Clear();
				foreach (var i in invoices) {
					ListViewItem li = listView1.Items.Add(i.Customer.Name);
					li.SubItems.Add(i.Id.ToString());
					li.SubItems.Add(i.Date.ToShortDateString());
				}
			}
		}
		
		public InvoiceListPane()
		{
			InitializeComponent();
		}
	}
}
