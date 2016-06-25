/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:12 AM
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
	/// Interaction logic for ItemReceiptWindow.xaml
	/// </summary>
	public partial class ItemReceiptWindow : Window, IItemReceiptView
	{
		ItemReceipt itemReceipt;
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; }
		}
		
		public ItemReceipt ItemReceipt {
			get { return itemReceipt; }
			set { itemReceipt = value; }
		}
		
		public ItemReceiptWindow()
		{
			InitializeComponent();
		}
		
		public event EventHandler ListVendors;
		public event ItemReceiptEventHandler SaveItemReceipt;
		public event ItemReceiptEventHandler SaveItemReceiptAndClear;
		public event ItemReceiptEventHandler SaveItemReceiptAndClose;
		public event ItemReceiptItemEventHandler ItemAdding;
		public event ItemReceiptItemEventHandler ItemChanging;
	}
}