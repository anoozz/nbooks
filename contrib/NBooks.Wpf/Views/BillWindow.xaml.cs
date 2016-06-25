/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:11 AM
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
	/// Interaction logic for BillWindow.xaml
	/// </summary>
	public partial class BillWindow : Window, IBillView
	{
		Bill bill;
		IList<Vendor> vendors;
		IList<Terms> terms;
		IList<Account> accounts;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; }
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; }
		}
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		
		public Bill Bill {
			get { return bill; }
			set { bill = value; }
		}
		
		public BillWindow()
		{
			InitializeComponent();
		}
		
		public event BillEventHandler SaveBill;
		public event BillEventHandler SaveBillAndClose;
		public event BillEventHandler SaveBillAndClear;
		public event EventHandler ListVendors;
		public event EventHandler ListAccounts;
		public event EventHandler ListTerms;
		public event BillItemEventHandler ItemAdding;
		public event BillAccountEventHandler AccountAdding;
	}
}