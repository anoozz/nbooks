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
	/// Interaction logic for ItemListWindow.xaml
	/// </summary>
	public partial class ItemListWindow : Window, IItemListView
	{
		IList<Item> items;
		
		public IList<Item> Items {
			get { return items; }
			set { items = value; }
		}
		
		public ItemListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListItems != null) ListItems(this, null);
		}
		
		public event EventHandler ListItems;
		public event ItemEventHandler DeleteItem;
		public event ItemEventHandler MakeInactiveItem;
	}
}