//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class BillPayment : Transaction<BillPayment>
	{
		IList<BillPaymentBill> bills = new List<BillPaymentBill>();
		public virtual PaymentMethod PaymentMethod { get; set; }
		public virtual Account Account { get; set; }
		
		public virtual IList<BillPaymentBill> Bills {
			get { return bills; }
			set { bills = value; }
		}
		
		public BillPayment()
		{
		}
		
		public virtual void AddBill(BillPaymentBill bill)
		{
			bill.Payment = this;
			bills.Add(bill);
			if (BillsChanged != null) BillsChanged(this, null);
		}
		
		public virtual void RemoveBill(BillPaymentBill bill)
		{
			if (bills.Contains(bill)) {
				bills.Remove(bill);
				if (BillsChanged != null) BillsChanged(this, null);
			}
		}
		
		public virtual event EventHandler BillsChanged;
	}
	
	public class BillPaymentBill : BaseModel<BillPaymentBill>
	{
		public virtual BillPayment Payment { get; set; }
		public virtual Bill Bill { get; set; }
		public virtual double AmountPaid { get; set; }
		
		public BillPaymentBill()
		{
		}
	}
	
	public delegate void BillPaymentEventHandler(BillPayment sender, EventArgs e);
}
