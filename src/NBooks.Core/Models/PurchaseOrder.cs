//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PurchaseOrder : Transaction<PurchaseOrder>
	{
		IList<PurchaseOrderItem> items = new List<PurchaseOrderItem>();
		public virtual string PreparedBy { get; set; }
		public virtual string ApprovedBy { get; set; }
		public virtual Vendor Vendor { get; set; }
		public virtual DateTime DeliveryDate { get; set; }
		public virtual string RefNo { get; set; }
		public virtual Class Class { get; set; }
		public virtual string VendorMessage { get; set; }
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (PurchaseOrderItem i in items) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual double TotalQuantity {
			get {
				double quantity = 0;
				foreach (PurchaseOrderItem i in items) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public virtual IList<PurchaseOrderItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public PurchaseOrder()
		{
		}
		
		public virtual void AddItem(PurchaseOrderItem item)
		{
			item.Order = this;
			items.Insert(0, item);
			if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(PurchaseOrderItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public override void Validate()
		{
			base.Validate();
			if (Vendor == null) Errors.Add("Vendor is required!");
			if (PreparedBy == "") Errors.Add("Prepared by is required!");
			if (ApprovedBy == "") Errors.Add("Approved by is required!");
			if (items.Count <= 0) Errors.Add("There should be at least 1 purchase order item!");
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	public class PurchaseOrderItem : BaseModel<PurchaseOrderItem>
	{
		Item item;
		public virtual double Rate { get; set; }
		public virtual double Quantity { get; set; }
		public virtual PurchaseOrder Order { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual Unit Unit { get; set; }
		
		public virtual double Amount {
			get { return Rate * Quantity; }
		}
		
		public virtual Item Item {
			get { return item; }
			set {
				item = value;
				Rate = item.Cost;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public PurchaseOrderItem()
		{
		}
		
		public PurchaseOrderItem(Item item) : this(item, 1)
		{
		}
		
		public PurchaseOrderItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public class PurchaseOrderEventArgs : EventArgs
	{
		public PurchaseOrder PurchaseOrder { get; set; }
		
		public PurchaseOrderEventArgs(PurchaseOrder order)
		{
			this.PurchaseOrder = order;
		}
	}
	
	public delegate void PurchaseOrderEventHandler(PurchaseOrder sender, EventArgs e);
	public delegate void PurchaseOrderItemEventHandler(PurchaseOrderItem sender, EventArgs e);
}
