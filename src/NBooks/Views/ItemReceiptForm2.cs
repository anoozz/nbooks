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
	public partial class ItemReceiptForm2 : BaseForm
	{
		ItemReceipt receipt;
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set {
				vendors = value; 
				SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", receipt.Vendor);
			}
		}
		
		ItemReceiptItem SelectedItem {
			get { 
				if (listViewItems.SelectedItems.Count > 0) {
					return receipt.Items[listViewItems.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		ItemReceiptAccount SelectedAccount {
			get { 
				if (listViewAccounts.SelectedItems.Count > 0) {
					return receipt.Accounts[listViewAccounts.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public ItemReceipt ItemReceipt {
			get { 
				receipt.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				receipt.Date = dateTimePickerDate.Value;
				receipt.ReferenceNo = textBoxRefNo.Text;
				receipt.Memo = textBoxMemo.Text;
				return receipt; 
			}
			set {
				receipt = value;
				dateTimePickerDate.Value = DateUtility.GetValid(receipt.Date);
				textBoxRefNo.Text = receipt.ReferenceNo;
				textBoxMemo.Text = receipt.Memo;
				receipt.ItemsChanged += new EventHandler(ReceiptItemsChanged);
				ReceiptItemsChanged(this, null);
			}
		}
		
		public ItemReceiptForm2() : this(new ItemReceipt())
		{
		}
		
		public ItemReceiptForm2(ItemReceipt receipt)
		{
			InitializeComponent();
			this.ItemReceipt = receipt;
			
			newItemToolStripMenuItem.Click += delegate { 
				if (ItemAdding != null) ItemAdding(new ItemReceiptItem(), null);
			};
			editItemToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					if (ItemChanging != null) {
						ItemChanging(SelectedItem, null);
					}
				}
			};
			deleteItemToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					receipt.RemoveItem(SelectedItem);
				}
			};
			
			newAccountToolStripMenuItem.Click += delegate { 
				if (AccountAdding != null) AccountAdding(new ItemReceiptAccount(), null);
			};
			editAccountToolStripMenuItem.Click += delegate { 
				if (listViewAccounts.SelectedItems.Count > 0) {
					if (AccountChanging != null) {
						AccountChanging(SelectedAccount, null);
					}
				}
			};
			deleteAccountToolStripMenuItem.Click += delegate { 
				if (listViewAccounts.SelectedItems.Count > 0) {
					receipt.RemoveAccount(SelectedAccount);
				}
			};
		}
		
		void ReceiptItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in receipt.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.PurchaseDescription);
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Unit != null ? i.Unit.Name : "");
				li.SubItems.Add(i.UnitPrice.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				li.SubItems.Add(i.Customer != null ? i.Customer.Name : "");
				li.SubItems.Add(i.Billable ? "Yes" : "No");
			}
			textBoxTotal.Text = receipt.TotalAmount.ToString("###,##0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (VendorsList != null) VendorsList(this, null);
		}
		
		public event EventHandler VendorsList;
		public event ItemReceiptEventHandler SaveItemReceipt;
		public event ItemReceiptEventHandler SaveItemReceiptAndClear;
		public event EventHandler<ItemReceiptEventArgs> ItemReceiptSaveAndClose;
		
		protected virtual void OnItemReceiptSaveAndClose(ItemReceiptEventArgs e)
		{
			if (ItemReceiptSaveAndClose != null) {
				ItemReceiptSaveAndClose(this, e);
			}
		}
		public event ItemReceiptItemEventHandler ItemAdding;
		public event ItemReceiptItemEventHandler ItemChanging;
		public event ItemReceiptAccountEventHandler AccountAdding;
		public event ItemReceiptAccountEventHandler AccountChanging;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnItemReceiptSaveAndClose(new ItemReceiptEventArgs(ItemReceipt));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveItemReceiptAndClear != null) {
				SaveItemReceiptAndClear(ItemReceipt, e);
			}
		}
		
//		void NewItemToolStripMenuItemClick(object sender, EventArgs e)
//		{
//			using (var f = new ItemReceiptItemForm()) {
//				f.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
//				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//					receipt.AddItem(f.ReceiptItem);
//				}
//			}
//		}
		
//		void DeleteItemToolStripMenuItemClick(object sender, EventArgs e)
//		{
//			if (listView1.SelectedItems.Count > 0) {
//				receipt.RemoveItem(receipt.Items[listView1.SelectedItems[0].Index]);
//			}
//		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SaveItemReceipt != null) SaveItemReceipt(ItemReceipt, e);
		}
	}
}
