//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ItemListForm : BaseForm
	{
		IList<Item> items;
		
		public Item SelectedItem {
			get {
				if (listViewItems.SelectedItems.Count > 0) {
					return items[listViewItems.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Item> SelectedItems {
			get {
				IList<Item> selectedItems = new List<Item>();
				foreach (ListViewItem li in listViewItems.SelectedItems) {
					selectedItems.Add(items[li.Index]);
				}
				return selectedItems;
			}
		}
		
		public IList<Item> Items {
			get { return items; }
			set { 
				items = value;
				listViewItems.Items.Clear();
				foreach (var i in items) {
					ListViewItem li = listViewItems.Items.Add(i.Name);
					li.SubItems.Add(i.Description);
					li.SubItems.Add(ItemForm.ItemTypes[i.Type].Name);
					li.SubItems.Add(i.IncomeAccount != null ? i.IncomeAccount.Name : "");
					li.SubItems.Add(i.OnHand.ToString("###,##0.0"));
					li.SubItems.Add(i.SalesPrice.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
				toolStripDropDownButtonItem.Text = string.Format("{0} Items", items.Count);
			}
		}
		
		public ItemListForm()
		{
			InitializeComponent();
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnItemAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedItem != null) {
					OnItemEdit(new ItemEventArgs(SelectedItem));
				}
			};
			listViewItems.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var item in SelectedItems) {
					OnItemDelete(new ItemEventArgs(item));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var item in SelectedItems) {
					OnItemMakeInactive(new ItemEventArgs(item));
				}
				OnActivated(null);
			};
		}
		
		public event EventHandler<ItemEventArgs> ItemDelete;
		
		protected virtual void OnItemDelete(ItemEventArgs e)
		{
			if (ItemDelete != null) {
				ItemDelete(this, e);
			}
		}
		public event EventHandler<ItemEventArgs> ItemMakeInactive;
		
		protected virtual void OnItemMakeInactive(ItemEventArgs e)
		{
			if (ItemMakeInactive != null) {
				ItemMakeInactive(this, e);
			}
		}
		public event EventHandler<ItemEventArgs> ItemEdit;
		
		protected virtual void OnItemEdit(ItemEventArgs e)
		{
			if (ItemEdit != null) {
				ItemEdit(this, e);
			}
		}
		public event EventHandler ItemAdd;
		
		protected virtual void OnItemAdd(EventArgs e)
		{
			if (ItemAdd != null) {
				ItemAdd(this, e);
			}
		}
		public event EventHandler ItemsList;
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ItemsList != null) ItemsList(this, e);
		}
	}
}
