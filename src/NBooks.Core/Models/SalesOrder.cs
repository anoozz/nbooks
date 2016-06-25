//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class SalesOrder : Transaction<SalesOrder>
	{
		IList<SalesOrderItem> items = new List<SalesOrderItem>();
		public virtual Customer Customer { get; set; }
		
		public virtual IList<SalesOrderItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public SalesOrder()
		{
		}
		
		public virtual void AddItem(SalesOrderItem item)
		{
			item.Order = this;
			items.Add(item);
			if (ItemsChanged != null) ItemsChanged(this, null);
		}
		
		public virtual void RemoveItem(SalesOrderItem item)
		{
			if (items.Contains(item)) {
				items.Remove(item);
				if (ItemsChanged != null) ItemsChanged(this, null);
			}
		}
		
		public virtual event EventHandler ItemsChanged;
	}
	
	public class SalesOrderItem : BaseModel<SalesOrderItem>
	{
		Item item;
		public virtual double Quantity { get; set; }
		public virtual SalesOrder Order { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public SalesOrderItem()
		{
		}
		
		public SalesOrderItem(Item item) : this(item, 1)
		{
		}
		
		public SalesOrderItem(Item item, double quantity)
		{
			this.Item = item;
			this.Quantity = quantity;
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public delegate void SalesOrderEventHandler(SalesOrder sender, EventArgs e);
}
