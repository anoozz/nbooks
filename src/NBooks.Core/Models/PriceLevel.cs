//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PriceLevel : BaseModel<PriceLevel>
	{
		public virtual string Name { get; set; }
		public virtual bool Inactive { get; set; }
		IList<PriceLevelItem> items = new List<PriceLevelItem>();
		
		public virtual IList<PriceLevelItem> Items {
			get { return items; }
			set { items = value; }
		}
		
		public PriceLevel()
		{
		}
		
		public virtual void AddItem(PriceLevelItem item)
		{
			item.Level = this;
			items.Add(item);
			if (ItemsChanged != null) {
				ItemsChanged(this, null);
			}
		}
		
		public virtual void RemoveItem(PriceLevelItem item)
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
	
	public class PriceLevelItem : BaseModel<PriceLevelItem>
	{
		public virtual PriceLevel Level { get; set; }
		public virtual double CustomPrice { get; set; }
		Item item;
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value; 
				if (ItemChanged != null) {
					ItemChanged(item, null);
				}
			}
		}
		
		public PriceLevelItem()
		{
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public delegate void PriceLevelEventHandler(PriceLevel sender, EventArgs e);
}
