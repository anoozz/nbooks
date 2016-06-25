/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 3:34 PM
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
	/// Interaction logic for CheckWindow.xaml
	/// </summary>
	public partial class CheckWindow : Window, ICheckView
	{
		Check check;
		IList<Account> accounts;
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; }
		}
		
		public Check Check {
			get { return check; }
			set { check = value; }
		}
		
		public CheckWindow() : this(new Check())
		{
		}
		
		public CheckWindow(Check check)
		{
			InitializeComponent();
			this.Check = check;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVendors != null) ListVendors(this, null);
			if (ListAccounts != null) ListAccounts(this, null);
		}
		
		public event EventHandler ListVendors;
		public event EventHandler ListAccounts;
		public event CheckEventHandler SaveCheck;
		public event CheckEventHandler SaveCheckAndClose;
		public event CheckEventHandler SaveCheckAndClear;
	}
}