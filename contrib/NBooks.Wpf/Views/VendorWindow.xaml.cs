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
	/// Interaction logic for VendorWindow.xaml
	/// </summary>
	public partial class VendorWindow : Window, IVendorView
	{
		Vendor vendor;
		IList<Terms> terms;
		IList<Account> accountPreFill1;
		IList<Account> accountPreFill2;
		IList<Account> accountPreFill3;
		IList<VendorType> vendorTypes;
		
		public IList<VendorType> VendorTypes {
			get { return vendorTypes; }
			set { vendorTypes = value; }
		}
		
		public IList<Account> AccountPreFill3 {
			get { return accountPreFill3; }
			set { accountPreFill3 = value; }
		}
		
		public IList<Account> AccountPreFill2 {
			get { return accountPreFill2; }
			set { accountPreFill2 = value; }
		}
		
		public IList<Account> AccountPreFill1 {
			get { return accountPreFill1; }
			set { accountPreFill1 = value; }
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; }
		}
		
		public Vendor Vendor {
			get {
				return vendor;
			}
			set { 
				vendor = value;
			}
		}
		
		public VendorWindow() : this(new Vendor())
		{
		}
		
		public VendorWindow(Vendor vendor)
		{
			InitializeComponent();
			this.Vendor = vendor;
		}
		
		public event VendorEventHandler SaveVendor;
		
		protected virtual void OnSaveVendor(EventArgs e)
		{
			if (SaveVendor != null) {
				SaveVendor(Vendor, e);
			}
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVendorTypes != null) ListVendorTypes(this, null);
			if (ListTerms != null) ListTerms(this, null);
			if (ListAccountPreFill1 != null) ListAccountPreFill1(this, null);
			if (ListAccountPreFill2 != null) ListAccountPreFill2(this, null);
			if (ListAccountPreFill3 != null) ListAccountPreFill3(this, null);
		}
		
		public event EventHandler ListVendorTypes;
		public event EventHandler ListTerms;
		public event EventHandler ListAccountPreFill1;
		public event EventHandler ListAccountPreFill2;
		public event EventHandler ListAccountPreFill3;
	}
}