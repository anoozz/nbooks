//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

using NBooks.Core.Utils;

namespace NBooks.Core.Models
{
	public class TruckLoad : Transaction<TruckLoad>
	{
		IList<TruckLoadItem> items = new List<TruckLoadItem>();
		public virtual string PreparedBy { get; set; }
		public virtual string ApprovedBy { get; set; }
		public virtual string ReleasedBy { get; set; }
		public virtual string RecordedBy { get; set; }
		public virtual string TruckNo { get; set; }
		public virtual Route Route { get; set; }
		public virtual SalesRep SalesRep { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual string Remarks { get; set; }
		
		public virtual IList<TruckLoadItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (var i in items) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual double NetTotal {
			get { return TotalAmount - TotalDiscount; }
		}
		
		public virtual double TotalDiscount {
			get {
				double discount = 0;
				foreach (TruckLoadItem i in items) discount += i.Discount;
				return discount;
			}
		}
		
		public virtual double TotalQuantity {
			get {
				double quantity = 0;
				foreach (TruckLoadItem i in items) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public TruckLoad()
		{
		}
		
		public virtual void AddItem(TruckLoadItem item)
		{
			item.Load = this;
            items.Insert(0, item);
            if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(TruckLoadItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
	            if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public override void Validate()
		{
			base.Validate();
			if (Customer == null) Errors.Add("Customer is required!");
			if (TruckNo == "") Errors.Add("Truck number is required!");
			if (PreparedBy == "") Errors.Add("Prepared by is required!");
			if (ApprovedBy == "") Errors.Add("Approved by is required!");
			if (ReleasedBy == "") Errors.Add("Released by is required!");
			if (RecordedBy == "") Errors.Add("Recorded by is required!");
			if (items.Count <= 0) Errors.Add("There's should be at least 1 truck load item!");
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	/// <summary>
	/// Description of TruckLoadItem.
	/// </summary>
	public class TruckLoadItem : BaseModel<TruckLoadItem>
	{
		public virtual double Discount { get; set; }
		public virtual double Price { get; set; }
		public virtual double Quantity { get; set; }
		public virtual TruckLoad Load { get; set; }
		public virtual Unit Unit { get; set; }
		Item item;
		
		public virtual double Amount {
			get { return Quantity * Price - Discount; }
		}
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				Price = item.SalesPrice;
				Unit = item.Unit;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public TruckLoadItem()
		{
		}
		
		public TruckLoadItem(Item item) : this(item, 1)
		{
		}
		
		public TruckLoadItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual InvoiceItem CreateSalesInvoiceItem()
		{
			return new InvoiceItem(this);
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public delegate void TruckLoadEventHandler(TruckLoad sender, EventArgs e);
	public delegate void TruckLoadItemEventHandler(TruckLoadItem sender, EventArgs e);
}
