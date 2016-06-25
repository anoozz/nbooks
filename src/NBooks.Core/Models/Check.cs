//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Check : Transaction<Check>
	{
		public virtual Account Account { get; set; }
		public virtual Vendor Vendor { get; set; }
		public virtual string AmountInWords { get; set; }
		public virtual string Address { get; set; }
		IList<CheckItem> items;
		IList<CheckAccount> accounts;
		
		public virtual IList<CheckAccount> Accounts {
			get { return accounts; }
			set { accounts = value; }
		}
		
		public virtual IList<CheckItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public Check()
		{
		}
		
		public virtual void AddItem(CheckItem item)
		{
			item.Check = this;
			items.Insert(0, item);
		}
		
		public virtual void AddAccount(CheckAccount account)
		{
			account.Check = this;
			accounts.Insert(0, account);
		}
	}
	
	public class CheckItem : BaseModel<CheckItem>
	{
		public virtual Check Check { get; set; }
		public virtual double Quantity { get; set; }
		Item item;
		
		public Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) {
					ItemChanged(item, null);
				}
			}
		}
		
		public CheckItem()
		{
		}
		
		public CheckItem(Item item) : this(item, 1)
		{
		}
		
		public CheckItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public event ItemEventHandler ItemChanged;
	}
	
	public class CheckAccount : BaseModel<CheckItem>
	{
		public virtual Check Check { get; set; }
		public virtual double Amount { get; set; }
		Account account;
		
		public Account Account {
			get { return account; }
			set { 
				account = value;
				OnAccountChanged(new AccountEventArgs(account));
			}
		}
		
		public CheckAccount()
		{
		}
		
		public CheckAccount(Account account, double amount)
		{
			this.Account = account;
			this.Amount = amount;
		}
		
		public event EventHandler<AccountEventArgs> AccountChanged;
		
		protected virtual void OnAccountChanged(AccountEventArgs e)
		{
			if (AccountChanged != null) {
				AccountChanged(this, e);
			}
		}
	}
	
	public delegate void CheckEventHandler(Check sender, EventArgs e);
}
