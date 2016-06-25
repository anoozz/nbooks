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
	public partial class CustomerForm : BaseForm
	{
		Customer customer;
		IList<PaymentMethod> methods;
		IList<Terms> terms;
		IList<PriceLevel> levels;
		IList<SalesTaxCode> taxCodes;
		IList<JobType> jobTypes;
		IList<CustomerType> types;
		
		public IList<CustomerType> CustomerTypes {
			get { return types; }
			set { types = value; SwfUtility.SetupComboBox(comboBoxType, types, "Id", "Name", customer.Type); }
		}
		
		public IList<JobType> JobTypes {
			get { return jobTypes; }
			set { jobTypes = value; SwfUtility.SetupComboBox(comboBoxJobType, jobTypes, "Id", "Name", customer.JobType); }
		}
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return taxCodes; }
			set { taxCodes = value; SwfUtility.SetupComboBox(comboBoxTaxCode, taxCodes, "Id", "Code", customer.SalesTaxCode); }
		}
		
		public IList<PriceLevel> PriceLevels {
			get { return levels; }
			set { levels = value; SwfUtility.SetupComboBox(comboBoxPriceLevel, levels, "Id", "Name", customer.PriceLevel); }
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; SwfUtility.SetupComboBox(comboBoxTerms, terms, "Id", "Name", customer.Terms); }
		}
		
		public IList<PaymentMethod> PaymentMethods {
			get { return methods; }
			set { methods = value; SwfUtility.SetupComboBox(comboBoxPaymentMethod, methods, "Id", "Name", customer.PaymentMethod); }
		}
		
		public Customer Customer {
			get { 
				customer.Name = textBoxName.Text;
				customer.Balance = ConvertUtility.ToDouble(textBoxBalance.Text);
				customer.BalanceAsOf = dateTimePickerBalanceAsOf.Value;
				customer.CompanyName = textBoxCompanyName.Text;
				customer.LegalName = new Name(textBoxTitle.Text, textBoxLastName.Text, textBoxFirstName.Text, textBoxMI.Text);
				customer.Address = richTextBoxBillTo.Text;
				customer.ShipToAddress = richTextBoxShipTo.Text;
				customer.Contact = textBoxContact.Text;
				customer.Phone = textBoxPhone.Text;
				customer.Fax = textBoxFax.Text;
				customer.AltPhone = textBoxAltPhone.Text;
				customer.AltContact = textBoxAltContact.Text;
				customer.Email = textBoxEmail.Text;
				customer.CC = textBoxCC.Text;
				customer.CreditLimit = ConvertUtility.ToDouble(textBoxCreditLimit.Text);
				return customer;
			}
			set { 
				customer = value;
				textBoxName.Text = customer.Name;
				textBoxBalance.Text = customer.Balance.ToString("0.00");
				dateTimePickerBalanceAsOf.Value = DateUtility.GetValid(customer.BalanceAsOf);
				textBoxCompanyName.Text = customer.CompanyName;
				if (customer.LegalName != null) {
					textBoxTitle.Text = customer.LegalName.Title;
					textBoxLastName.Text = customer.LegalName.Last;
					textBoxFirstName.Text = customer.LegalName.First;
					textBoxMI.Text = customer.LegalName.Middle;
				}
				richTextBoxBillTo.Text = customer.Address;
				richTextBoxShipTo.Text = customer.ShipToAddress;
				textBoxContact.Text = customer.Contact;
				textBoxPhone.Text = customer.Phone;
				textBoxFax.Text = customer.Fax;
				textBoxAltPhone.Text = customer.AltPhone;
				textBoxAltContact.Text = customer.AltContact;
				textBoxEmail.Text = customer.Email;
				textBoxCC.Text = customer.CC;
				textBoxCreditLimit.Text = customer.CreditLimit.ToString("0.00");
				
				customer.DiscountedItemAdded += delegate { DiscountedItemsChanged(); };
				customer.DiscountedItemRemoved += delegate { DiscountedItemsChanged(); };
				DiscountedItemsChanged();
				if (customer.Id > 0) {
					labelBalance.Text = "Balance";
					textBoxBalance.Enabled = dateTimePickerBalanceAsOf.Enabled = false;
					buttonNotes.Visible = true;
				}
				buttonEdit.Enabled = UserSingleton.Instance.Name == "engelie" ? false : true;
				buttonNew.Enabled = UserSingleton.Instance.Name == "engelie" ? false : true;
				buttonDelete.Enabled = UserSingleton.Instance.Name == "engelie" ? false : true;
			}
		}
		
		public CustomerForm() : this(new Customer())
		{
		}
		
		public CustomerForm(Customer customer)
		{
			InitializeComponent();
			this.Customer = customer;
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListTerms != null) ListTerms(this, null);
			if (ListCustomerTypes != null) ListCustomerTypes(this, null);
			if (ListPriceLevels != null) ListPriceLevels(this, null);
			if (ListPaymentMethods != null) ListPaymentMethods(this, null);
			if (ListSalesTaxCodes != null) ListSalesTaxCodes(this, null);
			if (ListJobTypes != null) ListJobTypes(this, null);
		}
		
		public event EventHandler ListTerms;
		public event EventHandler ListCustomerTypes;
		public event EventHandler ListJobTypes;
		public event EventHandler ListPriceLevels;
		public event EventHandler ListPaymentMethods;
		public event EventHandler ListSalesTaxCodes;
		
		void DiscountedItemsChanged()
		{
			listView1.Items.Clear();
			foreach (var item in customer.DiscountedItems) {
				ListViewItem li = listView1.Items.Add(item.Item.Name);
				li.SubItems.Add(item.Item.SalesDescription);
				li.SubItems.Add(item.Item.SalesPrice.ToString("###,##0.00"));
				li.SubItems.Add(item.Discount.ToString("###,##0.00"));
				SwfUtility.AlternateBackColor(li);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnCustomerSave(new CustomerEventArgs(Customer));
		}
		
		public event EventHandler<CustomerEventArgs> CustomerSave;
		
		protected virtual void OnCustomerSave(CustomerEventArgs e)
		{
			if (CustomerSave != null) {
				CustomerSave(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonNewClick(object sender, EventArgs e)
		{
			using (CustomerDiscountedItemForm f = new CustomerDiscountedItemForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					customer.AddDiscountedItem(f.CustomerDiscountedItem);
				}
			}
		}
		
		void ButtonEditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				CustomerDiscountedItem item = customer.DiscountedItems[listView1.SelectedItems[0].Index];
				using (CustomerDiscountedItemForm f = new CustomerDiscountedItemForm(item)) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						DiscountedItemsChanged();
					}
				}
			}
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				CustomerDiscountedItem item = customer.DiscountedItems[listView1.SelectedItems[0].Index];
				customer.RemoveDiscountedItem(item);
			}
		}
		
		void ButtonNotesClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new NotepadForm(customer));
		}
		
		void ButtonBillToClick(object sender, EventArgs e)
		{
			using (var f = new AddressForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					richTextBoxBillTo.Text = f.Address.ToString();
				}
			}
		}
		
		void ButtonShipToClick(object sender, EventArgs e)
		{
			using (var f = new AddressForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					richTextBoxShipTo.Text = f.Address.ToString();
				}
			}
		}
	}
}
