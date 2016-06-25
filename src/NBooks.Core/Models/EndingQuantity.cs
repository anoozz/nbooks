//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class EndingQuantity : BaseModel<EndingQuantity>
	{
		IList<EndingQuantityItem> items = new List<EndingQuantityItem>();
		
		public EndingQuantity()
		{
		}
		
		public virtual string Date { get;set; }
		
		public virtual IList<EndingQuantityItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public virtual void AddItem(Item item)
		{
			AddItem(new EndingQuantityItem(item, item.OnHand));
		}
		
		public virtual void AddItem(EndingQuantityItem item)
		{
			item.Quantity = this;
			items.Add(item);
		}
	}
	
	public class EndingQuantityItem : BaseModel<EndingQuantityItem>
	{
		Item item;
		public virtual EndingQuantity Quantity { get; set; }
		public virtual double Qty { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { item = value; }
		}
		
		public EndingQuantityItem()
		{
		}
		
		public EndingQuantityItem(Item item, double qty)
		{
			this.Item = item;
			this.Qty = qty;
		}
	}
	
	public delegate void EndingQuantityEventHandler(EndingQuantity sender, EventArgs e);
}
