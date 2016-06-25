//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;


namespace NBooks.Core.Models
{
	public class Invoice : Transaction<Invoice>
	{
		IList<InvoiceItem> items = new List<InvoiceItem>();
		public virtual string RefNo { get; set; }
		public virtual string PONo { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Terms Terms { get; set; }
		public virtual CustomerMessage CustomerMessage { get; set; }
		public virtual ShippingMethod ShippingMethod { get; set; }
		public virtual Account Account { get; set; }
		public virtual string BillToAddress { get; set; }
		public virtual string ShipToAddress { get; set; }
		public virtual bool ToBeEmailed { get; set; }
		public virtual bool ToBePrinted { get; set; }
		public virtual double AmountPaid { get; set; }
		public virtual VehicleTrip VehicleTrip { get; set; }
		public virtual double AmountDue { get; set; }
		
		public virtual IList<InvoiceItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (InvoiceItem i in items) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual double TotalQuantity {
			get {
				double quantity = 0;
				foreach (InvoiceItem i in items) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public Invoice()
		{
		}
		
		public virtual void AddItem(InvoiceItem item)
		{
			item.Invoice = this;
            items.Insert(0, item);
            if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(InvoiceItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	public class InvoiceItem : BaseModel<InvoiceItem>
	{
		public virtual double UnitPrice { get; set; }
		public virtual double Quantity { get; set; }
		public virtual Invoice Invoice { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		Item item;
		
		public virtual double Amount {
			get { return Quantity * UnitPrice; }
		}
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value; 
				OnItemChanged(new ItemEventArgs(item));
			}
		}
		
		public InvoiceItem()
		{
		}
		
		public InvoiceItem(TruckLoadItem i)
		{
			this.Item = i.Item;
			this.Quantity = i.Quantity;
			this.UnitPrice = i.Price;
		}
		
		public InvoiceItem(Item item) : this(item, 1)
		{
		}
		
		public InvoiceItem(Item item, double quantity)
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
	
	public class InvoiceEventArgs : EventArgs
	{
		public Invoice Invoice { get; set; }
		
		public InvoiceEventArgs(Invoice invoice)
		{
			this.Invoice = invoice;
		}
	}
	
	public class InvoiceItemEventArgs : EventArgs
	{
		public InvoiceItem InvoiceItem { get; set; }
		
		public InvoiceItemEventArgs(InvoiceItem item)
		{
			this.InvoiceItem = item;
		}
	}
	
	public delegate void InvoiceEventHandler(Invoice sender, EventArgs e);
	public delegate void InvoiceItemEventHandler(InvoiceItem sender, EventArgs e);
}
