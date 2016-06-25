//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class BillPaymentForm : BaseForm
	{
		BillPayment payment;
		IList<Bill> bills;
		IList<PaymentMethod> methods;
		IList<Account> accounts;
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { accounts = value; SwfUtility.SetupComboBox(comboBoxAccount, accounts, "Id", "Name", payment.Account); }
		}
		
		public IList<PaymentMethod> PaymentMethods {
			get { return methods; }
			set { methods = value; SwfUtility.SetupComboBox(comboBoxPaymentMethod, methods, "Id", "Name", payment.PaymentMethod); }
		}
		
		public IList<Bill> Bills {
			get { return bills; }
			set { 
				bills = value; 
				listView1.Items.Clear();
				foreach (var b in bills) {
					ListViewItem li = listView1.Items.Add(b.DueDate.ToShortDateString());
					li.SubItems.Add(b.Vendor != null ? b.Vendor.Name : "");
					li.SubItems.Add(b.RefNo);
					li.SubItems.Add("");
					li.SubItems.Add(b.Amount.ToString("0.00"));
				}
			}
		}
		
		public BillPayment BillPayment {
			get { 
				payment.Date = dateTimePickerDate.Value;
				payment.PaymentMethod = SwfUtility.GetComboBoxValue<PaymentMethod>(comboBoxPaymentMethod);
				payment.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccount);
				return payment;
			}
			set { 
				payment = value;
			}
		}
		
		public BillPaymentForm() : this(new BillPayment())
		{
		}
		
		public BillPaymentForm(BillPayment payment)
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width + columnHeader8.Width); };
			this.BillPayment = payment;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListBills != null) ListBills(this, null);
			if (ListAccounts != null) ListAccounts(this, null);
			if (ListPaymentMethods != null) ListPaymentMethods(this, null);
		}
		
		public event BillPaymentEventHandler SaveBillPayment;
		public event EventHandler ListBills;
		public event EventHandler ListAccounts;
		public event EventHandler ListPaymentMethods;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonPaySelectedBillsClick(object sender, EventArgs e)
		{
			if (SaveBillPayment != null) {
				SaveBillPayment(BillPayment, e);
			}
		}
	}
}
