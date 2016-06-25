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
	/// Interaction logic for ItemWindow.xaml
	/// </summary>
	public partial class ItemWindow : Window, IItemView
	{
		Item item;
		IList<Account> cogsAccounts;
		
		public IList<Account> CogsAccounts {
			get { return cogsAccounts; }
			set { cogsAccounts = value; }
		}
		IList<Account> incomeAccounts;
		
		public IList<Account> IncomeAccounts {
			get { return incomeAccounts; }
			set { incomeAccounts = value; }
		}
		IList<Account> assetAccounts;
		
		public IList<Account> AssetAccounts {
			get { return assetAccounts; }
			set { assetAccounts = value; }
		}
		IList<SalesTaxCode> salesTaxCodes;
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return salesTaxCodes; }
			set { salesTaxCodes = value; }
		}
		IList<Unit> units;
		
		public IList<Unit> Units {
			get { return units; }
			set { units = value; }
		}
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; }
		}
		
		public Item Item {
			get { return item; }
			set { item = value; }
		}
		
		public ItemWindow()
		{
			InitializeComponent();
		}
		
		public event ItemEventHandler SaveItem;
		public event EventHandler ListCogsAccounts;
		public event EventHandler ListSalesTaxCodes;
		public event EventHandler ListIncomeAccounts;
		public event EventHandler ListAssetAccounts;
		public event EventHandler ListVendors;
		public event EventHandler ListUnits;
	}
}