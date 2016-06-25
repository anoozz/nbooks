//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class ItemReceipt : Transaction<ItemReceipt>
	{
		IList<ItemReceiptItem> items = new List<ItemReceiptItem>();
		IList<VendorReturnedItem> returnedItems = new List<VendorReturnedItem>();
		public virtual string PreparedBy { get; set; }
		public virtual string ApprovedBy { get; set; }
		public virtual string ReferenceNo { get; set; }
		Vendor vendor;
		IList<ItemReceiptAccount> accounts = new List<ItemReceiptAccount>();
		
		public virtual IList<ItemReceiptAccount> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		
		public virtual Vendor Vendor {
			get { return vendor; }
			set {
				vendor = value;
				if (VendorChanged != null) VendorChanged(vendor, null);
			}
		}
		
		public virtual IList<VendorReturnedItem> ReturnedItems {
			get { return returnedItems; }
			set { returnedItems = value; }
		}
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (ItemReceiptItem i in items) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual double TotalQuantity {
			get {
				double quantity = 0;
				foreach (ItemReceiptItem i in items) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public virtual double TotalReturnedAmount {
			get {
				double amount = 0;
				foreach (VendorReturnedItem i in returnedItems) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual double TotalReturnedQuantity {
			get {
				double quantity = 0;
				foreach (VendorReturnedItem i in returnedItems) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public virtual IList<ItemReceiptItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public ItemReceipt()
		{
		}
		
		public virtual void AddItem(ItemReceiptItem item)
		{
			item.Receipt = this;
			items.Insert(0, item);
			OnItemsChanged(null);
		}
		
		public virtual void RemoveItem(ItemReceiptItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				OnItemsChanged(null);
			}
		}
		
		public virtual void AddAccount(ItemReceiptAccount account)
		{
			account.Receipt = this;
			accounts.Insert(0, account);
			OnAccountsChanged(null);
		}
		
		public virtual void RemoveAccount(ItemReceiptAccount account)
		{
			if (accounts.Contains(account)) {
				accounts.Remove(account);
				OnAccountsChanged(null);
			}
		}
		
		public virtual void AddReturnedItem(VendorReturnedItem item)
		{
			item.Receipt = this;
			returnedItems.Insert(0, item);
		}
		
		public override void Validate()
		{
			base.Validate();
			if (Vendor == null) Errors.Add("Vendor is required!");
			if (PreparedBy == "") Errors.Add("Prepared by is required!");
			if (ApprovedBy == "") Errors.Add("Approved by is required!");
			if (items.Count <= 0) Errors.Add("There should be at least 1 item receipt item!");
		}
		
		protected virtual void OnItemsChanged(EventArgs e)
		{
			if (ItemsChanged != null) {
				ItemsChanged(this, null);
			}
		}
		
		protected virtual void OnAccountsChanged(EventArgs e)
		{
			if (AccountsChanged != null) {
				AccountsChanged(this, e);
			}
		}
		
		public virtual event EventHandler ItemsChanged;
		
		public virtual event EventHandler AccountsChanged;
		
		public virtual event EventHandler<VendorEventArgs> VendorChanged;
	}
	
	public class ItemReceiptItem : BaseModel<ItemReceiptItem>
	{
		Item item;
		public virtual double UCS { get; set; }
		public virtual double Discount { get; set; }
		public virtual double UnitPrice { get; set; }
		public virtual ItemReceipt Receipt { get; set; }
		public virtual double Quantity { get; set; }
		public virtual Unit Unit { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual bool Billable { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public virtual double Amount {
			get { return Quantity * UnitPrice - Discount; }
		}
		
		public ItemReceiptItem()
		{
		}
		
		public ItemReceiptItem(Item item) : this(item, 1)
		{
		}
		
		public ItemReceiptItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public class ItemReceiptAccount : BaseModel<ItemReceiptAccount>
	{
		public virtual Account Account { get; set; }
		public virtual ItemReceipt Receipt { get; set; }
		public virtual double Amount { get; set; }
		
		public ItemReceiptAccount()
		{
		}
	}
	
	public class VendorReturnedItem : BaseModel<VendorReturnedItem>
	{
		Item item;
		public virtual double UnitPrice { get; set; }
		public virtual ItemReceipt Receipt { get; set; }
		public virtual double Quantity { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public virtual double Amount {
			get { return Quantity * UnitPrice; }
		}
		
		public VendorReturnedItem()
		{
		}
		
		public VendorReturnedItem(Item item) : this(item, 1)
		{
		}
		
		public VendorReturnedItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public class ItemReceiptEventArgs : EventArgs
	{
		public ItemReceipt ItemReceipt { get; set; }
		
		public ItemReceiptEventArgs(ItemReceipt receipt)
		{
			this.ItemReceipt = receipt;
		}
	}
	
	public delegate void ItemReceiptEventHandler(ItemReceipt sender, EventArgs e);
	public delegate void ItemReceiptItemEventHandler(ItemReceiptItem sender, EventArgs e);
	public delegate void ItemReceiptAccountEventHandler(ItemReceiptAccount sender, EventArgs e);
}
