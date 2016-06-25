//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	/// TODO: Convert this one to Payment class.
	public class SalesInfo : Transaction<SalesInfo>
	{
		IList<SalesInfoDetail> details = new List<SalesInfoDetail>();
		public virtual Customer Customer { get; set; }
		public virtual string PreparedBy { get; set; }
		public virtual string ReceivedBy { get; set; }
		public virtual Route Route { get; set; }
		public virtual SalesRep SalesRep { get; set; }
		
		public virtual double TotalAmount {
			get {
				double amount = 0;
				foreach (SalesInfoDetail i in details) amount += i.Amount;
				return amount;
			}
		}
		
		public virtual IList<SalesInfoDetail> Details {
			get { return details; }
			set { details = value; }
		}
		
		public SalesInfo()
		{
		}
		
		public virtual void AddDetail(SalesInfoDetail detail)
		{
			detail.Info = this;
			details.Add(detail);
			if (DetailsChanged != null) DetailsChanged(this, null);
		}
		
		public virtual void RemoveDetail(SalesInfoDetail detail)
		{
			if (details.Contains(detail)) {
				details.Remove(detail);
				if (DetailsChanged != null) DetailsChanged(this, null);
			}
		}
		
		public override void Validate()
		{
			base.Validate();
			if (PreparedBy == "") Errors.Add("Prepared by is required!");
			if (ReceivedBy == "") Errors.Add("Received by is required!");
			if (details.Count <= 0) Errors.Add("There should be at least 1 sales information detail!");
		}
		
		public virtual event EventHandler DetailsChanged;
	}
	
	public class SalesInfoDetail : BaseModel<SalesInfoDetail>
	{
		public virtual string Type { get; set; }
		public virtual SalesInfo Info { get; set; }
		public virtual string CheckNo { get; set; }
		public virtual string Description { get; set; }
		public virtual double Amount { get; set; }
		
		public SalesInfoDetail()
		{
		}
		
		public SalesInfoDetail(string checkNo, string description, double amount)
		{
			this.CheckNo = checkNo;
			this.Description = description;
			this.Amount = amount;
		}
	}
	
	public delegate void SalesInfoEventHandler(SalesInfo sender, EventArgs e);
}
