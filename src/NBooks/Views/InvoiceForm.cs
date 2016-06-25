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
	public partial class InvoiceForm : BaseForm
	{
		Invoice invoice;
		IList<Customer> customers;
		IList<Terms> terms;
		IList<Account> accounts;
		IList<CustomerMessage> messages;
		IList<VehicleTrip> trips;
		
		public IList<VehicleTrip> VehicleTrips {
			get { return trips; }
			set { 
				trips = value;
				SwfUtility.SetupComboBox(comboBoxVehicleTrip, trips, "Id", "Notes", invoice.VehicleTrip);
				labelVehicleTrip.Visible = comboBoxVehicleTrip.Visible = trips.Count > 1;
			}
		}
		
		public bool ToBePrinted {
			get { return checkBoxToBePrinted.Checked; }
		}
		
		public bool ToBeEmailed {
			get { return checkBoxToBeEmailed.Checked; }
		}
		
		public IList<CustomerMessage> CustomerMessages {
			get { return messages; }
			set { 
				messages = value; 
				SwfUtility.SetupComboBox(comboBoxCustomerMessage, messages, "Id", "Message", invoice.CustomerMessage); 
			}
		}
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { 
				accounts = value; 
				SwfUtility.SetupComboBox(comboBoxAccount, accounts, "Id", "Name", invoice.Account);
				labelAccount.Visible = comboBoxAccount.Visible = accounts.Count > 1;
			}
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { 
				terms = value;
				SwfUtility.SetupComboBox(comboBoxTerms, terms, "Id", "Name", invoice.Terms); 
			}
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { 
				customers = value;
				SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", invoice.Customer);
			}
		}
		
		public Invoice Invoice {
			get { 
				invoice.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccount);
				invoice.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				invoice.BillToAddress = richTextBoxBillToAddress.Text;
				invoice.Date = dateTimePickerDate.Value;
				invoice.RefNo = textBoxRefNo.Text;
				invoice.PONo = textBoxPONo.Text;
				invoice.Terms = SwfUtility.GetComboBoxValue<Terms>(comboBoxTerms);
				invoice.CustomerMessage = SwfUtility.GetComboBoxValue<CustomerMessage>(comboBoxCustomerMessage);
				invoice.Memo = textBoxMemo.Text;
				return invoice; 
			}
			set { 
				invoice = value;
				dateTimePickerDate.Value = DateUtility.GetValid(invoice.Date);
				textBoxRefNo.Text = invoice.RefNo;
				textBoxPONo.Text = invoice.PONo;
				textBoxMemo.Text = invoice.Memo;
				invoice.ItemsChanged += new EventHandler(InvoiceItemsChanged);
				InvoiceItemsChanged(this, null);
			}
		}
		
		public InvoiceForm() : this(new Invoice())
		{
		}
		
		public InvoiceForm(Invoice invoice)
		{
			InitializeComponent();
			this.Invoice = invoice;
			
			listViewItems.Resize += delegate { columnHeader3.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader2.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width); };
			newToolStripMenuItem.Click += delegate { 
				OnItemAdding(new InvoiceItemEventArgs(new InvoiceItem()));
			};
			editToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					if (ItemChanging != null) {
						ItemChanging(invoice.Items[listViewItems.SelectedItems[0].Index], null);
					}
				}
			};
			listViewItems.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					invoice.RemoveItem(invoice.Items[listViewItems.SelectedItems[0].Index]);
				}
			};
		}
		
		void InvoiceItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in invoice.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Item.Name);
				li.SubItems.Add(i.Item.SalesDescription);
				li.SubItems.Add(i.UnitPrice.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				li.SubItems.Add(i.SalesTaxCode != null ? i.SalesTaxCode.Code : "");
			}
			labelTotalAmount.Text = invoice.TotalAmount.ToString("###,##0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (CustomersList != null) CustomersList(this, e);
			if (ListTerms != null) ListTerms(this, e);
			if (AccountsList != null) AccountsList(this, e);
			if (ListCustomerMessages != null) ListCustomerMessages(this, e);
			if (VehicleTripsList != null) VehicleTripsList(this, e);
		}
		
		public event EventHandler CustomersList;
		public event EventHandler VehicleTripsList;
		public event EventHandler AccountsList;
		public event EventHandler ListTerms;
		public event EventHandler ListCustomerMessages;
		public event InvoiceItemEventHandler ItemChanging;
		public event EventHandler<InvoiceItemEventArgs> ItemAdding;
		
		protected virtual void OnItemAdding(InvoiceItemEventArgs e)
		{
			if (ItemAdding != null) {
				ItemAdding(this, e);
			}
		}
		public event InvoiceEventHandler SaveInvoice;
		public event InvoiceEventHandler SaveInvoiceAndClear;
		public event EventHandler<InvoiceEventArgs> InvoiceSaveAndClose;
		
		protected virtual void OnInvoiceSaveAndClose(InvoiceEventArgs e)
		{
			if (InvoiceSaveAndClose != null) {
				InvoiceSaveAndClose(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnInvoiceSaveAndClose(new InvoiceEventArgs(Invoice));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveInvoiceAndClear != null) {
				SaveInvoiceAndClear(Invoice, null);
			}
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SaveInvoice != null) {
				SaveInvoice(Invoice, null);
			}
		}
	}
}
