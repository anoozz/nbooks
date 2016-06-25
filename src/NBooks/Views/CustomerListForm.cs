//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class CustomerListForm : BaseForm
	{
		IList<Customer> customers;
		
		public Customer SelectedCustomer {
			get {
				if (listViewCustomers.SelectedItems.Count > 0) {
					return customers[listViewCustomers.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Customer> SelectedCustomers {
			get {
				IList<Customer> selectedCustomers = new List<Customer>();
				foreach (ListViewItem li in listViewCustomers.SelectedItems) {
					selectedCustomers.Add(customers[li.Index]);
				}
				return selectedCustomers;
			}
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { 
				customers = value;
				listViewCustomers.Items.Clear();
				foreach (Customer customer in customers) {
					ListViewItem li = listViewCustomers.Items.Add(customer.Name);
					li.SubItems.Add(customer.Balance.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
				toolStripDropDownButtonCustomer.Text = string.Format("{0} Customers", customers.Count);
			}
		}
		
		public CustomerListForm()
		{
			InitializeComponent();
			listViewCustomers.Resize += delegate { columnHeader1.Width = listViewCustomers.Width - 22 - (columnHeader2.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnCustomerAdd(null); };
			editToolStripMenuItem.Click  += delegate { 
				if (SelectedCustomer != null) {
					OnCustomerEdit(new CustomerEventArgs(SelectedCustomer));
				}
			};
			listViewCustomers.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var customer in SelectedCustomers) {
					OnCustomerDelete(new CustomerEventArgs(customer));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var customer in SelectedCustomers) {
					OnCustomerMakeInactive(new CustomerEventArgs(customer));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnCustomersList(e);
		}
		
		public event EventHandler CustomersList;
		
		protected virtual void OnCustomersList(EventArgs e)
		{
			if (CustomersList != null) {
				CustomersList(this, e);
			}
		}
		public event EventHandler<CustomerEventArgs> CustomerDelete;
		
		protected virtual void OnCustomerDelete(CustomerEventArgs e)
		{
			if (CustomerDelete != null) {
				CustomerDelete(this, e);
			}
		}
		public event EventHandler<CustomerEventArgs> CustomerMakeInactive;
		
		protected virtual void OnCustomerMakeInactive(CustomerEventArgs e)
		{
			if (CustomerMakeInactive != null) {
				CustomerMakeInactive(this, e);
			}
		}
		public event EventHandler<CustomerEventArgs> CustomerEdit;
		
		protected virtual void OnCustomerEdit(CustomerEventArgs e)
		{
			if (CustomerEdit != null) {
				CustomerEdit(this, e);
			}
		}
		public event EventHandler CustomerAdd;
		
		protected virtual void OnCustomerAdd(EventArgs e)
		{
			if (CustomerAdd != null) {
				CustomerAdd(this, e);
			}
		}
	}
}
