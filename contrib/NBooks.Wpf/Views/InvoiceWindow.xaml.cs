/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 11:19
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
	/// Interaction logic for InvoiceWindow.xaml
	/// </summary>
	public partial class InvoiceWindow : Window, IInvoiceView
	{
		Invoice invoice;
		IList<Customer> customers;
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; }
		}
		IList<Terms> terms;
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; }
		}
		IList<Account> accounts;
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		IList<CustomerMessage> customerMessages;
		
		public IList<CustomerMessage> CustomerMessages {
			get { return customerMessages; }
			set { customerMessages = value; }
		}
		IList<VehicleTrip> vehicleTrips;
		
		public IList<VehicleTrip> VehicleTrips {
			get { return vehicleTrips; }
			set { vehicleTrips = value; }
		}
		
		public Invoice Invoice {
			get { return invoice; }
			set { invoice = value; }
		}
		
		public InvoiceWindow() : this(new Invoice())
		{
		}
		
		public InvoiceWindow(Invoice invoice)
		{
			InitializeComponent();
			this.Invoice = invoice;
		}
		
		public event EventHandler ListVehicleTrips;
		public event EventHandler ListCustomerMessages;
		public event EventHandler ListAccounts;
		public event EventHandler ListTerms;
		public event InvoiceEventHandler SaveInvoice;
		public event InvoiceEventHandler SaveInvoiceAndClear;
		public event InvoiceEventHandler SaveInvoiceAndClose;
		public event EventHandler ListCustomers;
		public event InvoiceItemEventHandler ItemChanging;
		public event InvoiceItemEventHandler ItemAdding;
	}
}