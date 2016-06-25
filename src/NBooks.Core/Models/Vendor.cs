//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Vendor : Stakeholder<Vendor>
	{
		IList<VendorDiscountedItem> discountedItems = new List<VendorDiscountedItem>();
		
		public Vendor()
		{
		}
		
		public virtual event EventHandler DiscountedItemAdded;
		
		public virtual event EventHandler DiscountedItemRemoved;
		
		public virtual double Balance { get; set; }
		
		public virtual DateTime BalanceAsOf { get; set; }
		
		public virtual Terms Terms { get; set; }
		
		public virtual double CreditLimit { get; set; }
		
		public virtual string TaxId { get; set; }
		
		public virtual VendorType Type { get; set; }
		
		public virtual Account AccountPreFill1 { get; set; }
		
		public virtual Account AccountPreFill2 { get; set; }
		
		public virtual Account AccountPreFill3 { get; set; }
		
		public virtual IList<VendorDiscountedItem> DiscountedItems {
			get { return discountedItems; }
			set { discountedItems = value; }
		}
		
		public virtual void AddDiscountedItem(Item item, double discount)
		{
			AddDiscountedItem(new VendorDiscountedItem(item, discount));
		}
		
		public virtual void AddDiscountedItem(VendorDiscountedItem item)
		{
			item.Vendor = this;
			discountedItems.Add(item);
			if (DiscountedItemAdded != null) DiscountedItemAdded(this, null);
		}
		
		public virtual void RemoveDiscountedItem(VendorDiscountedItem item)
		{
			discountedItems.Remove(item);
			if (DiscountedItemRemoved != null) DiscountedItemRemoved(this, null);
		}
	}
	
	public class VendorDiscountedItem
	{
		Item item;
		
		public VendorDiscountedItem()
		{
		}
		
		public VendorDiscountedItem(Item item, double discount)
		{
			this.Item = item;
			this.Discount = discount;
		}
		
		public virtual event ItemEventHandler ItemChanged;
		
		public virtual Vendor Vendor { get; set; }
		
		public virtual int Id { get; set; }
		
		public virtual double Discount { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set {
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
	}
	
	public class VendorEventArgs : EventArgs
	{
		public Vendor Vendor { get; set; }
		
		public VendorEventArgs(Vendor vendor)
		{
			this.Vendor = vendor;
		}
	}
}
