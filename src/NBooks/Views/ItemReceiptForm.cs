//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	[Obsolete()]
	/// <summary>
	/// Description of ItemReceiptForm.
	/// </summary>
	public partial class ItemReceiptForm : BaseForm
	{
		ItemReceipt receipt;
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { vendors = value; SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", receipt.Vendor); }
		}
		
		public ItemReceipt ItemReceipt {
			get {
				receipt.Date = dateTimePickerDate.Value;
				receipt.ReferenceNo = textBoxReferenceNo.Text;
				receipt.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				receipt.PreparedBy = textBoxPreparedBy.Text;
				receipt.ApprovedBy = textBoxApprovedBy.Text;
				receipt.Memo = textBoxRemarks.Text;
				return receipt; 
			}
			set { 
				receipt = value;
				dateTimePickerDate.Value = DateUtility.GetValid(receipt.Date);
				textBoxReferenceNo.Text = receipt.ReferenceNo;
				textBoxPreparedBy.Text = receipt.PreparedBy;
				textBoxApprovedBy.Text = receipt.ApprovedBy;
				textBoxRemarks.Text = receipt.Memo;
				UpdateReceiptItems();
				UpdateReceiptReturnedItems();
			}
		}
		
		public ItemReceiptForm() : this(new ItemReceipt())
		{
		}
		
		public ItemReceiptForm(ItemReceipt receipt)
		{
			InitializeComponent();
			this.ItemReceipt = receipt;
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader13.Width + columnHeader14.Width); };
			listViewReturnedItems.Resize += delegate { columnHeader8.Width = listViewReturnedItems.Width - 22 - (columnHeader7.Width + columnHeader9.Width + columnHeader10.Width + columnHeader11.Width + columnHeader12.Width); };
			addToolStripMenuItem.Click += delegate { ButtonAddClick(this, null); };
			addToolStripMenuItem1.Click += delegate { ButtonAdd2Click(this, null); };
			modifyToolStripMenuItem.Click += delegate { ListView1DoubleClick(this, null); };
			modifyToolStripMenuItem1.Click += delegate { ListView2DoubleClick(this, null); };
			dateTimePickerDate.Select();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVendors != null) ListVendors(this, e);
		}
		
		public event EventHandler ListVendors;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			using (ItemReceiptItemForm receiptItemForm = new ItemReceiptItemForm()) {
				receiptItemForm.Vendor = (comboBoxVendor.DataSource as IList<Vendor>)[comboBoxVendor.SelectedIndex];
				if (WorkbenchSingleton.AddDialog(receiptItemForm) == DialogResult.OK) {
					receipt.AddItem(receiptItemForm.ReceiptItem as ItemReceiptItem);
					UpdateReceiptItems();
					
					ItemReceiptItem receiptItem = receiptItemForm.ReceiptItem;
					if (receiptItem.Item.IsFullCase()) {
						using (ItemReceiptItemForm suggestedItemForm = new ItemReceiptItemForm()) {
							suggestedItemForm.Vendor = (comboBoxVendor.DataSource as IList<Vendor>)[comboBoxVendor.SelectedIndex];
							string suggestedCode = ItemSuggestionUtility.Suggest(receiptItem.Item.Name.ToUpper().Replace("FC-", "MT-"));
							suggestedItemForm.FindCode(suggestedCode, receiptItem.Quantity);
							if (WorkbenchSingleton.AddDialog(suggestedItemForm) == DialogResult.OK) {
								receipt.AddItem(suggestedItemForm.ReceiptItem as ItemReceiptItem);
								UpdateReceiptItems();
							}
						}
					} else if (receiptItem.Item.IsSMBFullCase()) {
						using (ItemReceiptItemForm suggestedItemForm = new ItemReceiptItemForm()) {
							suggestedItemForm.Vendor = (comboBoxVendor.DataSource as IList<Vendor>)[comboBoxVendor.SelectedIndex];
							string suggestedCode = ItemSuggestionUtility.Suggest(receiptItem.Item.Name.ToUpper().Replace("SMBFC-", "SMBMT-"));
							suggestedItemForm.FindCode(suggestedCode, receiptItem.Quantity);
							if (WorkbenchSingleton.AddDialog(suggestedItemForm) == DialogResult.OK) {
								receipt.AddItem(suggestedItemForm.ReceiptItem as ItemReceiptItem);
								UpdateReceiptItems();
							}
						}
					}
				}
			}
		}
		
		void ButtonAdd2Click(object sender, EventArgs e)
		{
			using (VendorReturnedItemForm f = new VendorReturnedItemForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					receipt.AddReturnedItem(f.Item as VendorReturnedItem);
					UpdateReceiptReturnedItems();
				}
			}
		}
		
		void UpdateReceiptReturnedItems()
		{
			listViewReturnedItems.Items.Clear();
			foreach (VendorReturnedItem i in receipt.ReturnedItems) {
				ListViewItem li = listViewReturnedItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.Item.Unit != null ? i.Item.Unit.Name : "");
				li.SubItems.Add(i.Item.SalesPrice.ToString("###,##0.00"));
				li.SubItems.Add(i.Quantity.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				SwfUtility.AlternateBackColor(li);
			}
            labelTotalReturnedAmount.Text = receipt.TotalReturnedAmount.ToString("###,##0.00");
            labelTotalReturnedQuantity.Text = receipt.TotalReturnedQuantity.ToString("###,##0.00");
		}
		
		void UpdateReceiptItems()
		{
			listViewItems.Items.Clear();
			foreach (ItemReceiptItem i in receipt.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.Item.Unit != null ? i.Item.Unit.Name : "");
				li.SubItems.Add(i.Item.SalesPrice.ToString("###,##0.00"));
				li.SubItems.Add(i.Quantity.ToString("###,##0.00"));
				li.SubItems.Add(i.UCS.ToString());
				li.SubItems.Add(i.Discount.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				SwfUtility.AlternateBackColor(li);
			}
            labelTotalAmount.Text = receipt.TotalAmount.ToString("###,##0.00");
            labelTotalQuantity.Text = receipt.TotalQuantity.ToString("###,##0.00");
		}
		
		public event ItemReceiptEventHandler SaveItemReceipt;
		
		protected virtual void OnSaveItemReceipt(EventArgs e)
		{
			if (SaveItemReceipt != null) {
				SaveItemReceipt(ItemReceipt, e);
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnSaveItemReceipt(e);
			Close();
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			OnSaveItemReceipt(e);
			buttonClear.PerformClick();
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			this.ItemReceipt = new ItemReceipt();
		}
		
		void ListView1DoubleClick(object sender, EventArgs e)
		{
			if (listViewItems.SelectedItems.Count > 0) {
				ItemReceiptItem i = receipt.Items[listViewItems.SelectedItems[0].Index];
				using (ItemReceiptItemForm f = new ItemReceiptItemForm(i)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						UpdateReceiptItems();
					}
				}
			}
		}
		
		void DeleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listViewItems.SelectedItems.Count > 0) {
				ItemReceiptItem i = receipt.Items[listViewItems.SelectedItems[0].Index];
				receipt.Items.Remove(i);
				UpdateReceiptItems();
			}
		}
		
		void SumSelectedToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listViewItems.SelectedItems.Count > 0) {
				double sum = 0;
				foreach (ListViewItem li in listViewItems.SelectedItems) {
					sum += receipt.Items[li.Index].Amount;
				}
				MessageService.ShowInfo(sum.ToString("###,##0.00"));
			}
		}
		
		void TextBoxRemarksKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonSaveAndClose.PerformClick();
			}
		}
		
		void ButtonModifyClick(object sender, EventArgs e)
		{
			ListView1DoubleClick(sender, e);
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			deleteToolStripMenuItem.PerformClick();
		}
		
		void ListView1KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.F3:
					buttonAdd.PerformClick();
					break;
				default:
					break;
			}
		}
		
		void ListView2KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode) {
				case Keys.F3:
					buttonAdd2.PerformClick();
					break;
				default:
					break;
			}
		}
		
		void ButtonModify2Click(object sender, EventArgs e)
		{
			modifyToolStripMenuItem1.PerformClick();
		}
		
		void ButtonDelete2Click(object sender, EventArgs e)
		{
			deleteToolStripMenuItem1.PerformClick();
		}
		
		void ListView2DoubleClick(object sender, EventArgs e)
		{
			if (listViewItems.SelectedItems.Count > 0) {
				VendorReturnedItem i = receipt.ReturnedItems[listViewItems.SelectedItems[0].Index];
				using (VendorReturnedItemForm f = new VendorReturnedItemForm(i)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						UpdateReceiptReturnedItems();
					}
				}
			}
		}
		
		void DeleteToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if (listViewReturnedItems.SelectedItems.Count > 0) {
				VendorReturnedItem i = receipt.ReturnedItems[listViewReturnedItems.SelectedItems[0].Index];
				receipt.ReturnedItems.Remove(i);
				UpdateReceiptReturnedItems();
			}
		}
	}
}
