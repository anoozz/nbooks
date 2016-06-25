//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class EstimateForm : BaseForm
	{
		Estimate estimate;
		IList<Customer> customers;
		IList<Class> classes;
		IList<CustomerMessage> messages;
		IList<SalesTaxCode> codes;
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return codes; }
			set { codes = value; SwfUtility.SetupComboBox(comboBoxSalesTaxCode, codes, "Id", "Code", estimate.SalesTaxCode); }
		}
		
		public IList<CustomerMessage> CustomerMessages {
			get { return messages; }
			set { messages = value; SwfUtility.SetupComboBox(comboBoxCustomerMessage, messages, "Id", "Message", estimate.CustomerMessage); }
		}
		
		public IList<Class> Classes {
			get { return classes; }
			set { classes = value; SwfUtility.SetupComboBox(comboBoxClass, classes, "Id", "Name", estimate.Class); }
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", estimate.Customer); }
		}
		
		public Estimate Estimate {
			get { 
				estimate.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				estimate.Inactive = checkBoxInactive.Checked;
				estimate.Class = SwfUtility.GetComboBoxValue<Class>(comboBoxClass);
				estimate.Date = dateTimePickerDate.Value;
				estimate.Memo = textBoxMemo.Text;
				return estimate;
			}
			set {
				estimate = value;
				checkBoxInactive.Checked = estimate.Inactive;
				dateTimePickerDate.Value = DateUtility.GetValid(estimate.Date);
				textBoxMemo.Text = estimate.Memo;
			}
		}
		
		public EstimateForm() : this(new Estimate())
		{
		}
		
		public EstimateForm(Estimate estimate)
		{
			InitializeComponent();
			this.Estimate = estimate;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCustomers != null) ListCustomers(this, null);
			if (ListClasses != null) ListClasses(this, null);
			if (ListCustomerMessages != null) ListCustomerMessages(this, null);
			if (ListSalesTaxCodes != null) ListSalesTaxCodes(this, null);
		}
		
		protected virtual void OnSaveEstimate(EventArgs e)
		{
			if (SaveEstimate != null) {
				SaveEstimate(Estimate, e);
			}
		}
		
		public event EstimateEventHandler SaveEstimate;
		public event EventHandler ListCustomerMessages;
		public event EventHandler ListSalesTaxCodes;
		public event EventHandler ListCustomers;
		public event EventHandler ListClasses;
	}
}
