/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using NBooks.Core.Models;
using NBooks.Core.Views;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for CustomerListWindow.xaml
	/// </summary>
	public partial class CustomerListWindow : Window, ICustomerListView
	{
		IList<Customer> customers;
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; }
		}
		
		public CustomerListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCustomers != null) ListCustomers(this, null);
		}
		
		public event EventHandler ListCustomers;
		public event CustomerEventHandler MakeInactiveCustomer;
		public event CustomerEventHandler DeleteCustomer;
	}
}