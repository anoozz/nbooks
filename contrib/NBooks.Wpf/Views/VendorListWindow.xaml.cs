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
	/// Interaction logic for VendorListWindow.xaml
	/// </summary>
	public partial class VendorListWindow : Window, IVendorListView
	{
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { 
				vendors = value;
			}
		}
		
		public VendorListWindow()
		{
			InitializeComponent();
		}
		
		public event EventHandler ListVendors;
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVendors != null) ListVendors(this, null);
		}
		
		public event VendorEventHandler DeleteVendor;
		public event VendorEventHandler MakeInactiveVendor;
	}
}