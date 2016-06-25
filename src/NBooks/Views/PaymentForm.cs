//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PaymentForm : BaseForm
	{
		Payment payment;
		IList<Customer> customers;
		IList<PaymentMethod> methods;
		
		public IList<PaymentMethod> PaymentMethods {
			get { return methods; }
			set { 
				methods = value;
				SwfUtility.SetupComboBox(comboBoxPaymentMethod, methods, "Id", "Name", payment.PaymentMethod);
			}
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { 
				customers = value; 
				SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name");
			}
		}
		
		public Payment Payment {
			get { 
				payment.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				payment.Date = dateTimePickerDate.Value;
				payment.PaymentMethod = SwfUtility.GetComboBoxValue<PaymentMethod>(comboBoxPaymentMethod);
				payment.Memo = textBoxMemo.Text;
				payment.CardNo = textBoxCardNo.Text;
				payment.RefNo = textBoxRefNo.Text;
				return payment;
			}
			set { 
				payment = value;
				dateTimePickerDate.Value = DateUtility.GetValid(payment.Date);
				textBoxMemo.Text = payment.Memo;
				textBoxCardNo.Text = payment.CardNo;
				textBoxRefNo.Text = payment.RefNo;
				payment.InvoicesChanged += new EventHandler(PaymentInvoicesChanged);
				PaymentInvoicesChanged(this, null);
			}
		}
		
		public PaymentForm() : this(new Payment())
		{
		}
		
		public PaymentForm(Payment payment)
		{
			InitializeComponent();
			this.Payment = payment;
			
			deleteToolStripMenuItem.Click += delegate { 
				if (listViewInvoices.SelectedItems.Count > 0) {
					payment.RemoveInvoice(payment.Invoices[listViewInvoices.SelectedItems[0].Index]);
				}
			};
		}
		
		void PaymentInvoicesChanged(object sender, EventArgs e)
		{
			listViewInvoices.Items.Clear();
			foreach (var i in payment.Invoices) {
				ListViewItem li = listViewInvoices.Items.Add(i.Invoice.Date.ToShortDateString());
				li.SubItems.Add(i.Invoice.Id.ToString());
				li.SubItems.Add(i.Invoice.TotalAmount.ToString("##,##0.00"));
				li.SubItems.Add(i.Invoice.AmountPaid.ToString("###,##0.00"));
				li.SubItems.Add(i.AmountPaid.ToString("###,##0.00"));
			}
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (CustomersList != null) CustomersList(this, e);
			if (PaymentMethodsList != null) PaymentMethodsList(this, e);
		}
		
		public event PaymentEventHandler SavePayment;
		public event EventHandler<PaymentEventArgs> PaymentSaveAndClose;
		
		protected virtual void OnPaymentSaveAndClose(PaymentEventArgs e)
		{
			if (PaymentSaveAndClose != null) {
				PaymentSaveAndClose(this, e);
			}
		}
		public event PaymentEventHandler SavePaymentAndClear;
		public event EventHandler CustomersList;
		public event EventHandler PaymentMethodsList;
		public event CustomerEventHandler FindInvoices;
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnPaymentSaveAndClose(new PaymentEventArgs(Payment));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SavePaymentAndClear != null) {
				SavePaymentAndClear(Payment, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonFindCustomerInvoiceClick(object sender, EventArgs e)
		{
			if (FindInvoices != null) FindInvoices(Payment.Customer, e);
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SavePayment != null) {
				SavePayment(Payment, e);
			}
		}
		
		void PayToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listViewInvoices.SelectedItems.Count > 0) {
				using (var f = new AmountForm()) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						
					}
				}
			}
		}
		
		void EnterPaymentToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listViewInvoices.SelectedItems.Count > 0) {
				PaymentInvoice invoice = payment.Invoices[listViewInvoices.SelectedItems[0].Index];
				using (var f = new PaymentInvoiceForm(invoice)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						
					}
				}
			}
		}
	}
}
