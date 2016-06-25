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
	public class TruckReturn : Transaction<TruckReturn>
	{
		IList<TruckReturnItem> items = new List<TruckReturnItem>();
		public virtual string ReleasedBy { get; set; }
		public virtual string RecordedBy { get; set; }
		public virtual string TruckNo { get; set; }
		public virtual Route Route { get; set; }
		public virtual SalesRep SalesRep { get; set; }
		public virtual string PreparedBy { get; set; }
		public virtual string ApprovedBy { get; set; }
		public virtual Customer Customer { get; set; }
		public virtual string Remarks { get; set; }
		
		public virtual double NetTotal {
			get { return TotalAmount - TotalDiscount; }
		}
		
		public virtual double TotalQuantity {
			get {
				double quantity = 0;
				foreach (TruckReturnItem i in items) quantity += i.Quantity;
				return quantity;
			}
		}
		
		public virtual double TotalDiscount {
			get {
				double discount = 0;
				foreach (TruckReturnItem i in items) discount += i.Discount;
				return discount;
			}
		}
		
		public virtual IList<TruckReturnItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (TruckReturnItem i in items) amount += i.Amount;
				return amount;
			}
		}
		
		public TruckReturn()
		{
		}
		
		public virtual void AddItem(TruckLoadItem item)
		{
			AddItem(new TruckReturnItem(item));
		}
		
		public virtual void AddItem(TruckReturnItem item)
		{
			item.Return = this;
            items.Insert(0, item);
            if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(TruckReturnItem item)
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
	/// Description of TruckReturnItem.
	/// </summary>
	public class TruckReturnItem : BaseModel<TruckReturnItem>
	{
		public virtual double Discount { get; set; }
		public virtual double UnitPrice { get; set; }
		public virtual double Quantity { get; set; }
		public virtual TruckReturn Return { get; set; }
		Item item;
		TruckLoadItem loadItem;
		
		public virtual double Amount {
			get { return Quantity * UnitPrice - Discount; }
		}
		
		public virtual TruckLoadItem LoadItem {
			get { return loadItem; }
			set { 
				loadItem = value;
				Item = loadItem.Item;
			}
		}
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				UnitPrice = item.SalesPrice;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public TruckReturnItem()
		{
		}
		
		public TruckReturnItem(Item item) : this(item, 1)
		{
		}
		
		public TruckReturnItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public TruckReturnItem(TruckLoadItem loadItem) : this(loadItem, 0)
		{
		}
		
		public TruckReturnItem(TruckLoadItem loadItem, double quantity)
		{
			this.LoadItem = loadItem;
			this.Quantity = quantity;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public delegate void TruckReturnEventHandler(TruckReturn sender, EventArgs e);
	public delegate void TruckReturnItemEventHandler(TruckReturnItem sender, EventArgs e);
}
