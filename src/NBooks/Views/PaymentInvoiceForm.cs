//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of PaymentInvoiceForm.
	/// </summary>
	public partial class PaymentInvoiceForm : BaseForm
	{
		PaymentInvoice invoice;
		
		public PaymentInvoice PaymentInvoice {
			get {
				return invoice;
			}
			set {
				invoice = value;
			textBoxCustomer.Text = invoice.Invoice.Customer.Name;
			textBoxDate.Text = invoice.Invoice.Date.ToShortDateString();
			textBoxAmountDue.Text = invoice.Invoice.AmountDue.ToString("###,##0.00");
			}
		}
		
		public PaymentInvoiceForm() : this(new PaymentInvoice())
		{
		}
		
		public PaymentInvoiceForm(PaymentInvoice invoice)
		{
			InitializeComponent();
			this.PaymentInvoice = invoice;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			invoice.AmountPaid = ConvertUtility.ToDouble(textBoxAmountPaid.Text);
		}
	}
}
