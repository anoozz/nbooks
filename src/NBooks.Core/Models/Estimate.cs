//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Estimate : Transaction<Estimate>
	{
		public virtual Customer Customer { get; set; }
		public virtual bool Inactive { get; set; }
		public virtual Class Class { get; set; }
		public virtual string CustomerAddress { get; set; }
		public virtual string ShipToAddress { get; set; }
		public virtual string RefNo { get; set; }
		public virtual CustomerMessage CustomerMessage { get; set; }
		public virtual Item TaxItem { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		IList<EstimateItem> items = new List<EstimateItem>();
		
		public virtual IList<EstimateItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public Estimate()
		{
		}
		
		public virtual void AddItem(EstimateItem item)
		{
			item.Estimate = this;
			items.Insert(0, item);
			if (ItemsChanged != null) {
				ItemsChanged(this, null);
			}
		}
		
		public virtual void RemoveItem(EstimateItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) {
					ItemsChanged(this, null);
				}
			}
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	public class EstimateItem : BaseModel<EstimateItem>
	{
		public virtual Estimate Estimate { get; set; }
		Item item;
		public virtual double Quantity { get; set; }
		public virtual Unit Unit { get; set; }
		public virtual double Cost { get; set; }
		public virtual double Markup { get; set; }
		public virtual SalesTaxCode SalesTaxCode { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public EstimateItem()
		{
		}
		
		public event ItemEventHandler ItemChanged;
	}
	
	public delegate void EstimateEventHandler(Estimate sender, EventArgs e);
	public delegate void EstimateItemEventHandler(EstimateItem sender, EventArgs e);
}
