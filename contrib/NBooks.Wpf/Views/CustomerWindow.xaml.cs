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
	/// Interaction logic for CustomerWindow.xaml
	/// </summary>
	public partial class CustomerWindow : Window, ICustomerView
	{
		Customer customer;
		IList<JobType> jobTypes;
		IList<CustomerType> customerTypes;
		IList<PriceLevel> priceLevels;
		IList<Terms> terms;
		IList<PaymentMethod> paymentMethods;
		IList<SalesTaxCode> salesTaxCodes;
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return salesTaxCodes; }
			set { salesTaxCodes = value; }
		}
		
		public IList<PaymentMethod> PaymentMethods {
			get { return paymentMethods; }
			set { paymentMethods = value; }
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; }
		}
		
		public IList<PriceLevel> PriceLevels {
			get { return priceLevels; }
			set { priceLevels = value; }
		}
		
		public IList<CustomerType> CustomerTypes {
			get { return customerTypes; }
			set { customerTypes = value; }
		}
		
		public IList<JobType> JobTypes {
			get { return jobTypes; }
			set { jobTypes = value; }
		}
		
		public Customer Customer {
			get { 
				return customer;
			}
			set { 
				customer = value;
			}
		}
		
		public CustomerWindow() : this(new Customer())
		{
		}
		
		public CustomerWindow(Customer customer)
		{
			InitializeComponent();
			this.Customer = customer;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
		}
		
		public event CustomerEventHandler SaveCustomer;
		
		protected virtual void OnSaveCustomer(EventArgs e)
		{
			if (SaveCustomer != null) {
				SaveCustomer(Customer, e);
			}
		}
		
		public event EventHandler ListPaymentMethods;
		public event EventHandler ListSalesTaxCodes;
		public event EventHandler ListCustomerTypes;
		public event EventHandler ListJobTypes;
		public event EventHandler ListTerms;
		public event EventHandler ListPriceLevels;
	}
}