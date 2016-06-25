//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class BillEventArgs : EventArgs
	{
		public Bill Bill { get; set; }
		
		public BillEventArgs(Bill bill)
		{
			this.Bill = bill;
		}
	}
	
	public class BillAccountEventArgs : EventArgs
	{
		public BillAccount Account { get; set; }
		
		public BillAccountEventArgs(BillAccount account)
		{
			this.Account = account;
		}
	}
	
	public class BillItemEventArgs : EventArgs
	{
		public BillItem Item { get; set; }
		
		public BillItemEventArgs(BillItem item)
		{
			this.Item = item;
		}
	}
	
	public class Bill : Transaction<Bill>
	{
		public virtual Vendor Vendor { get; set; }
		IList<BillItem> items = new List<BillItem>();
		IList<BillAccount> accounts = new List<BillAccount>();
		public virtual DateTime DueDate { get; set; }
		public virtual Account Account { get; set; }
		public virtual Terms Terms { get; set; }
		public virtual string VendorAddress { get; set; }
		public virtual string RefNo { get; set; }
		public virtual double Amount { get; set; }
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (var i in items) amount += i.Amount;
				foreach (var a in accounts) amount += a.Amount;
				return amount;
			}
		}
		
		public virtual IList<BillAccount> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		
		public virtual IList<BillItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public Bill()
		{
		}
		
		public virtual void AddItem(BillItem item)
		{
			item.Bill = this;
			items.Insert(0, item);
			if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void AddAccount(BillAccount account)
		{
			account.Bill = this;
			accounts.Insert(0, account);
			if (AccountsChanged != null) AccountsChanged(this, null);
		}
		
		public virtual void RemoveItem(BillItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public virtual void RemoveAccount(BillAccount account)
		{
			if (accounts.Contains(account)) {
				accounts.Remove(account);
				if (AccountsChanged != null) AccountsChanged(this, null);
			}
		}
		
		public virtual event EventHandler ItemsChanged;
		
		public virtual event EventHandler AccountsChanged;
	}
	
	public class BillItem : BaseModel<BillItem>
	{
		Item item;
		
		public BillItem()
		{
		}
		
		public BillItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual Bill Bill { get; set; }
		
		public virtual double Quantity { get; set; }
		
		public virtual double Price { get; set; }
		
		public virtual Customer Customer { get; set; }
		
		public virtual Class Class { get; set; }
		
		public virtual bool Billable { get; set; }
		
		public virtual double Amount {
			get { return Quantity * Price; }
		}
		
		public Item Item {
			get { return item; }
			set {
				item = value;
				Price = item.Cost;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public class BillAccount : BaseModel<BillAccount>
	{
		Account account;
		
		public BillAccount()
		{
		}
		public virtual Bill Bill { get; set; }
		
		public virtual double Amount { get; set; }
		
		public virtual string Memo { get; set; }
		
		public virtual Customer Customer { get; set; }
		
		public virtual bool Billable { get; set; }
		
		public virtual Class Class { get; set; }
		
		public virtual Account Account {
			get { return account; }
			set { 
				account = value; 
				OnAccountChanged(new AccountEventArgs(account));
			}
		}
		
		public virtual event EventHandler<AccountEventArgs> AccountChanged;
		
		protected virtual void OnAccountChanged(AccountEventArgs e)
		{
			if (AccountChanged != null) {
				AccountChanged(this, e);
			}
		}
	}
}
