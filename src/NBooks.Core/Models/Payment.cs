//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;

namespace NBooks.Core.Models
{
	public class Payment : Transaction<Payment>
	{
		public virtual Customer Customer { get; set; }
		IList<PaymentInvoice> invoices = new List<PaymentInvoice>();
		public virtual PaymentMethod PaymentMethod { get; set; }
		public virtual string CardNo { get; set; }
		public virtual string RefNo { get; set; }
		
		public virtual IList<PaymentInvoice> Invoices {
			get { return invoices; }
			set { invoices = value; }
		}
		
		public Payment()
		{
		}
		
		public virtual void AddInvoices(IList<Invoice> invoices)
		{
			foreach (var invoice in invoices) {
				AddInvoice(new PaymentInvoice(invoice));
			}
		}
		
		public virtual void AddInvoice(PaymentInvoice invoice)
		{
			invoice.Payment = this;
			invoices.Insert(0, invoice);
			if (InvoicesChanged != null) InvoicesChanged(invoice, null);
		}
		
		public virtual void RemoveInvoice(PaymentInvoice invoice)
		{
			if (invoices.Contains(invoice)) {
				invoices.Remove(invoice);
				if (InvoicesChanged != null) InvoicesChanged(invoice, null);
			}
		}
		
		public virtual event EventHandler InvoicesChanged;
	}
	
	public class PaymentInvoice : BaseModel<PaymentInvoice>
	{
		public virtual Payment Payment { get; set; }
		public virtual Invoice Invoice { get; set; }
		public virtual double AmountPaid { get; set; }
		
		public PaymentInvoice()
		{
		}
		
		public PaymentInvoice(Invoice invoice)
		{
			this.Invoice = invoice;
		}
	}
	
	public class PaymentEventArgs : EventArgs
	{
		public Payment Payment { get; set; }
		
		public PaymentEventArgs(Payment payment)
		{
			this.Payment = payment;
		}
	}
	
	public delegate void PaymentEventHandler(Payment sender, EventArgs e);
	public delegate void PaymentInvoiceEventHandler(PaymentInvoice sender, EventArgs e);
}
