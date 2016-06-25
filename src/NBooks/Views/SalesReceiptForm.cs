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
	public partial class SalesReceiptForm : BaseForm
	{
		SalesReceipt receipt;
		IList<Customer> customers;
		IList<SalesTaxCode> codes;
		IList<PaymentMethod> methods;
		IList<CustomerMessage> messages;
		IList<Item> taxItems;
		IList<VehicleTrip> trips;
		IList<Account> accounts;
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { 
				accounts = value;
				SwfUtility.SetupComboBox(comboBoxAccount, accounts, "Id", "Name", receipt.Account);
				labelAccount.Visible = comboBoxAccount.Visible = accounts.Count > 1;
			}
		}
		
		public IList<VehicleTrip> VehicleTrips {
			get { return trips; }
			set { 
				trips = value;
				SwfUtility.SetupComboBox(comboBoxVehicleTrip, trips, "Id", "Notes", receipt.VehicleTrip);
				labelVehicleTrip.Visible = comboBoxVehicleTrip.Visible = trips.Count > 1;
			}
		}
		
		public IList<Item> TaxItems {
			get { return taxItems; }
			set { 
				taxItems = value;
				SwfUtility.SetupComboBox(comboBoxTaxItem, taxItems, "Id", "Name", receipt.TaxItem);
			}
		}
		
		public IList<CustomerMessage> CustomerMessages {
			get { return messages; }
			set { 
				messages = value;
				SwfUtility.SetupComboBox(comboBoxCustomerMessage, messages, "Id", "Message", receipt.CustomerMessage);
			}
		}
		
		public IList<PaymentMethod> PaymentMethods {
			get { return methods; }
			set { 
				methods = value;
				SwfUtility.SetupComboBox(comboBoxPaymentMethod, methods, "Id", "Name", receipt.PaymentMethod);
			}
		}
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return codes; }
			set { 
				codes = value;
				SwfUtility.SetupComboBox(comboBoxSalesTaxCode, codes, "Id", "Code", receipt.SalesTaxCode);
			}
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set {
				customers = value;
				SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", receipt.Customer);
			}
		}
		
		public SalesReceipt SalesReceipt {
			get { 
				receipt.VehicleTrip = SwfUtility.GetComboBoxValue<VehicleTrip>(comboBoxVehicleTrip);
				receipt.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccount);
				receipt.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				receipt.CustomerMessage = SwfUtility.GetComboBoxValue<CustomerMessage>(comboBoxCustomerMessage);
				receipt.PaymentMethod = SwfUtility.GetComboBoxValue<PaymentMethod>(comboBoxPaymentMethod);
				receipt.SalesTaxCode = SwfUtility.GetComboBoxValue<SalesTaxCode>(comboBoxSalesTaxCode);
				receipt.TaxItem = SwfUtility.GetComboBoxValue<Item>(comboBoxTaxItem);
				receipt.Date = dateTimePickerDate.Value;
				receipt.Memo = textBoxMemo.Text;
				return receipt;
			}
			set { 
				receipt = value;
				dateTimePickerDate.Value = DateUtility.GetValid(receipt.Date);
				textBoxMemo.Text = receipt.Memo;
				receipt.ItemsChanged += new EventHandler(ReceiptItemsChanged);
			}
		}
		
		public SalesReceiptForm() : this(new SalesReceipt())
		{
		}
		
		public SalesReceiptForm(SalesReceipt receipt)
		{
			InitializeComponent();
			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			this.SalesReceipt = receipt;
			
			newToolStripMenuItem.Click += delegate { 
				OnItemAdding(new SalesReceiptItemEventArgs(new SalesReceiptItem()));
			};
		}
		
		void ReceiptItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in receipt.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Item.Unit != null ? i.Item.Unit.Name : "");
				li.SubItems.Add(i.Rate.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				li.SubItems.Add(i.TaxCode != null ? i.TaxCode.Code : "");
			}
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (CustomersList != null) CustomersList(this, null);
			if (ListCustomerMessages != null) ListCustomerMessages(this, null);
			if (PaymentMethodsList != null) PaymentMethodsList(this, null);
			if (ListTaxItems != null) ListTaxItems(this, null);
			if (ListSalesTaxCodes != null) ListSalesTaxCodes(this, null);
			if (ListTaxItems != null) ListTaxItems(this, null);
			if (VehicleTripsList != null) VehicleTripsList(this, null);
			if (ListAccounts != null) ListAccounts(this, null);
		}
		
		public event EventHandler VehicleTripsList;
		public event EventHandler ListAccounts;
		public event EventHandler CustomersList;
		public event EventHandler<SalesReceiptItemEventArgs> ItemAdding;
		public event EventHandler ListTaxItems;
		public event EventHandler ListCustomerMessages;
		public event EventHandler PaymentMethodsList;
		public event EventHandler ListSalesTaxCodes;
		public event SalesReceiptEventHandler SaveSalesReceipt;
		public event SalesReceiptEventHandler SaveSalesReceiptAndClear;
		public event EventHandler<SalesReceiptEventArgs> SalesReceiptSaveAndClose;
		
		protected virtual void OnItemAdding(SalesReceiptItemEventArgs e)
		{
			if (ItemAdding != null) {
				ItemAdding(this, e);
			}
		}
		
		protected virtual void OnSalesReceiptSaveAndClose(SalesReceiptEventArgs e)
		{
			if (SalesReceiptSaveAndClose != null) {
				SalesReceiptSaveAndClose(this, e);
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnSalesReceiptSaveAndClose(new SalesReceiptEventArgs(SalesReceipt));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveSalesReceiptAndClear != null) {
				SaveSalesReceiptAndClear(SalesReceipt, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SaveSalesReceipt != null) {
				SaveSalesReceipt(SalesReceipt, e);
			}
		}
	}
}
