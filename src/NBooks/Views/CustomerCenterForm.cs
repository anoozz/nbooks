//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of CustomerCenterForm.
	/// </summary>
	public partial class CustomerCenterForm : BaseForm
	{
		IList<Customer> customers;
		
		public IList<Customer> Customers {
			get { return customers; }
			set {
				customers = value;
				listViewCustomers.Items.Clear();
				foreach (var c in customers) {
					ListViewItem li = listViewCustomers.Items.Add(c.Name);
					li.SubItems.Add(c.Balance.ToString("###,##0.00"));
				}
			}
		}
		
		public CustomerCenterForm()
		{
			InitializeComponent();
			toolStripButtonNewCustomer.Click += delegate { OnCustomerAdd(null); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnCustomersList(e);
		}
		
		public event EventHandler CustomersList;
		public event EventHandler CustomerAdd;
		
		protected virtual void OnCustomerAdd(EventArgs e)
		{
			if (CustomerAdd != null) {
				CustomerAdd(this, e);
			}
		}
		
		protected virtual void OnCustomersList(EventArgs e)
		{
			if (CustomersList != null) {
				CustomersList(this, e);
			}
		}
	}
}
