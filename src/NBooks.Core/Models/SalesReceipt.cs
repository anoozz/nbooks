//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SalesReceipt : Transaction<SalesReceipt>
	{
		public virtual Customer Customer { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		public virtual PaymentMethod PaymentMethod { get; set; }
		public virtual Item TaxItem { get; set; }
		public virtual CustomerMessage CustomerMessage { get; set; }
		public virtual VehicleTrip VehicleTrip { get; set; }
		public virtual Account Account { get; set; }
		IList<SalesReceiptItem> items = new List<SalesReceiptItem>();
		
		public virtual IList<SalesReceiptItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public SalesReceipt()
		{
		}
		
		public virtual void AddItem(Item item)
		{
			AddItem(item, 1);
		}
		
		public virtual void AddItem(Item item, double quantity)
		{
			AddItem(new SalesReceiptItem(item, quantity));
		}
		
		public virtual void AddItem(SalesReceiptItem item)
		{
			item.Receipt = this;
			items.Insert(0, item);
			if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(SalesReceiptItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	public class SalesReceiptItem : BaseModel<SalesReceiptItem>
	{
		public virtual SalesReceipt Receipt { get; set; }
		public virtual double Quantity { get; set; }
		public virtual double Rate { get; set; }
		public virtual SalesTaxCode TaxCode { get; set; }
		Item item;
		
		public virtual double Amount {
			get { return Quantity * Rate; }
		}
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				Rate = item.SalesPrice;
				OnItemChanged(new ItemEventArgs(item));
			}
		}
		
		public SalesReceiptItem()
		{
		}
		
		public SalesReceiptItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual event EventHandler<ItemEventArgs> ItemChanged;
		
		protected virtual void OnItemChanged(ItemEventArgs e)
		{
			if (ItemChanged != null) {
				ItemChanged(this, e);
			}
		}
	}
	
	public class SalesReceiptEventArgs : EventArgs
	{
		public SalesReceipt SalesReceipt { get; set; }
		
		public SalesReceiptEventArgs(SalesReceipt receipt)
		{
			this.SalesReceipt = receipt;
		}
	}
	
	public class SalesReceiptItemEventArgs : EventArgs
	{
		public SalesReceiptItem ReceiptItem { get; set; }
		
		public SalesReceiptItemEventArgs(SalesReceiptItem item)
		{
			this.ReceiptItem = item;
		}
	}
	
	public delegate void SalesReceiptEventHandler(SalesReceipt sender, EventArgs e);
	public delegate void SalesReceiptItemEventHandler(SalesReceiptItem sender, EventArgs e);
}
