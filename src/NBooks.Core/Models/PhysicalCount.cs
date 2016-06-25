//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class PhysicalCount : BaseModel<PhysicalCount>
	{
		IList<PhysicalCountItem> items = new List<PhysicalCountItem>();
		public virtual string Remarks { get; set; }
		public virtual string PreparedBy { get; set; }
		public virtual string ApprovedBy { get; set; }
		public virtual DateTime Date { get; set; }
		
		public virtual IList<PhysicalCountItem> Items {
			get { return items; }
			set { items = value; }
		}

		public PhysicalCount()
		{
		}
		
		public virtual void AddItem(PhysicalCountItem item)
		{
			item.Count = this;
            items.Insert(0, item);
			OnItemAdded(null);
		}
		
		public override void Validate()
		{
			base.Validate();
			if (PreparedBy == "") Errors.Add("Prepared by is required!");
			if (ApprovedBy == "") Errors.Add("Approved by is required!");
			if (items.Count <= 0) Errors.Add("There should be greater than 1 physical count item!");
		}
		
		protected virtual void OnItemAdded(EventArgs e)
		{
			if (ItemAdded != null) {
				ItemAdded(this, e);
			}
		}
		
		public virtual event EventHandler ItemAdded;
	}
	
	public class PhysicalCountItem
	{
		Item item;
		public virtual int Id { get; set; }
		public virtual PhysicalCount Count { get; set; }
		public virtual double OriginalQty { get; set; }
		public virtual double AdjustedQty { get; set; }
		
		public virtual Item Item {
			get { return item; }
			set { 
				item = value;
				if (ItemChanged != null) ItemChanged(item, null);
			}
		}
		
		public PhysicalCountItem()
		{
		}
		
		public virtual event ItemEventHandler ItemChanged;
	}
	
	public delegate void PhysicalCountEventHandler(PhysicalCount sender, EventArgs e);
}
