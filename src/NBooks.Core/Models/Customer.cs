//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Customer : Stakeholder<Customer>
	{
		IList<CustomerDiscountedItem> discountedItems = new List<CustomerDiscountedItem>();
		public virtual double Balance { get; set; }
		public virtual string TradeAssistance { get; set; }
		public virtual string Classification { get; set; }
		public virtual string TypeOfDeal { get; set; }
		public virtual PriceLevel PriceLevel { get; set; }
		public virtual string ShipToAddress { get; set; }
		public virtual CustomerType CustomerType { get; set; }
		public virtual Terms Terms { get; set; }
		public virtual PaymentMethod PaymentMethod { get; set; }
		public virtual DateTime BalanceAsOf { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		public virtual JobType JobType { get; set; }
		public virtual CustomerType Type { get; set; }
		public virtual double CreditLimit { get; set; }
		
		public virtual IList<CustomerDiscountedItem> DiscountedItems {
			get { return discountedItems; }
			set { discountedItems = value; }
		}
		
		public Customer()
		{
		}
		
		public Customer(string name)
		{
			this.Name = name;
		}
		
		public virtual void AddDiscountedItem(Item item, double discount)
		{
			AddDiscountedItem(new CustomerDiscountedItem(item, discount));
		}
		
		public virtual void AddDiscountedItem(CustomerDiscountedItem item)
		{
			item.Customer = this;
			discountedItems.Add(item);
			if (DiscountedItemAdded != null) DiscountedItemAdded(this, null);
		}
		
		public virtual void RemoveDiscountedItem(CustomerDiscountedItem item)
		{
			discountedItems.Remove(item);
			if (DiscountedItemRemoved != null) DiscountedItemRemoved(this, null);
		}
		
		public virtual event EventHandler DiscountedItemAdded;
		public virtual event EventHandler DiscountedItemRemoved;
	}
	
	public class CustomerDiscountedItem
	{
		Item item;
		public virtual Customer Customer { get; set; }
		public virtual int Id { get; set; }
		public virtual double Discount { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public CustomerDiscountedItem()
		{
		}
		
		public CustomerDiscountedItem(Item item, double discount)
		{
			this.Item = item;
			this.Discount = discount;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public class CustomerEventArgs : EventArgs
	{
		public Customer Customer { get; set; }
		
		public CustomerEventArgs(Customer customer)
		{
			this.Customer = customer;
		}
	}
	
	public delegate void CustomerEventHandler(Customer sender, EventArgs e);
}
