// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class VendorForm : BaseForm
	{
		Vendor vendor;
		IList<Terms> terms;
		IList<VendorType> types;
		IList<Account> accountPreFill1;
		IList<Account> accountPreFill2;
		IList<Account> accountPreFill3;
		
		public IList<Account> AccountPreFill3 {
			get { return accountPreFill3; }
			set { accountPreFill3 = value; SwfUtility.SetupComboBox(comboBoxAccountPrefill3, accountPreFill3, "Id", "Name", vendor.AccountPreFill3); }
		}
		
		public IList<Account> AccountPreFill2 {
			get { return accountPreFill2; }
			set { accountPreFill2 = value; SwfUtility.SetupComboBox(comboBoxAccountPrefill2, accountPreFill2, "Id", "Name", vendor.AccountPreFill2); }
		}
		
		public IList<Account> AccountPreFill1 {
			get { return accountPreFill1; }
			set { accountPreFill1 = value; SwfUtility.SetupComboBox(comboBoxAccountPrefill1, accountPreFill1, "Id", "Name", vendor.AccountPreFill1); }
		}
		
		public IList<VendorType> VendorTypes {
			get { return types; }
			set { types = value; SwfUtility.SetupComboBox(comboBoxType, types, "Id", "Name", vendor.Type); }
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { terms = value; SwfUtility.SetupComboBox(comboBoxTerms, terms, "Id", "Name", vendor.Terms); }
		}
		
		public Vendor Vendor {
			get { 
				vendor.Name = textBoxName.Text;
				vendor.Balance = ConvertUtility.ToDouble(textBoxBalance.Text);
				vendor.BalanceAsOf = dateTimePickerBalanceAsOf.Value;
				vendor.CompanyName = textBoxCompanyName.Text;
				vendor.LegalName = new Name(textBoxTitle.Text, textBoxLastName.Text, textBoxFirstName.Text, textBoxMI.Text);
				vendor.Address = richTextBoxAddress.Text;
				vendor.Contact = textBoxContact.Text;
				vendor.Phone = textBoxPhone.Text;
				vendor.Fax = textBoxFax.Text;
				vendor.AltPhone = textBoxAltPhone.Text;
				vendor.AltContact = textBoxAltContact.Text;
				vendor.Email = textBoxEmail.Text;
				vendor.CC = textBoxCC.Text;
				vendor.PrintOnCheckAs = textBoxPrintOnCheckAs.Text;
				vendor.AccountNo = textBoxAccountNo.Text;
				vendor.Terms = SwfUtility.GetComboBoxValue<Terms>(comboBoxTerms);
				vendor.CreditLimit = ConvertUtility.ToDouble(textBoxCreditLimit.Text);
				vendor.TaxId = textBoxTaxId.Text;
				vendor.Inactive = checkBoxInactive.Checked;
				return vendor;
			}
			set { 
				vendor = value;
				textBoxName.Text = vendor.Name;
				textBoxBalance.Text = vendor.Balance.ToString("0.00");
				dateTimePickerBalanceAsOf.Value = DateUtility.GetValid(vendor.BalanceAsOf);
				textBoxCompanyName.Text = vendor.CompanyName;
				if (vendor.LegalName != null) {
					textBoxTitle.Text = vendor.LegalName.Title;
					textBoxLastName.Text = vendor.LegalName.Last;
					textBoxFirstName.Text = vendor.LegalName.First;
					textBoxMI.Text = vendor.LegalName.Middle;
				}
				richTextBoxAddress.Text = vendor.Address;
				textBoxContact.Text = vendor.Contact;
				textBoxPhone.Text = vendor.Phone;
				textBoxFax.Text = vendor.Fax;
				textBoxAltPhone.Text = vendor.AltPhone;
				textBoxAltContact.Text = vendor.AltContact;
				textBoxEmail.Text = vendor.Email;
				textBoxCC.Text = vendor.CC;
				textBoxPrintOnCheckAs.Text = vendor.PrintOnCheckAs;
				textBoxAccountNo.Text = vendor.AccountNo;
				textBoxCreditLimit.Text = vendor.CreditLimit.ToString("0.00");
				textBoxTaxId.Text = vendor.TaxId;
				if (vendor.Id > 0) {
					buttonNotes.Visible = true;
					textBoxBalance.Enabled = dateTimePickerBalanceAsOf.Enabled = false;
				}
			}
		}
		
		public VendorForm() : this(new Vendor())
		{
		}
		
		public VendorForm(Vendor vendor)
		{
			InitializeComponent();
			this.Vendor = vendor;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListTerms != null) ListTerms(this, null);
			if (ListVendorTypes != null) ListVendorTypes(this, null);
			if (ListAccountPreFill1 != null) ListAccountPreFill1(this, null);
			if (ListAccountPreFill2 != null) ListAccountPreFill2(this, null);
			if (ListAccountPreFill3 != null) ListAccountPreFill3(this, null);
		}
		
		public event EventHandler ListTerms;
		public event EventHandler ListVendorTypes;
		public event EventHandler ListAccountPreFill1;
		public event EventHandler ListAccountPreFill2;
		public event EventHandler ListAccountPreFill3;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnVendorSave(new VendorEventArgs(Vendor));
		}
		
		public event EventHandler<VendorEventArgs> VendorSave;
		
		protected virtual void OnVendorSave(VendorEventArgs e)
		{
			if (VendorSave != null) {
				VendorSave(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonNotesClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new NotepadForm(vendor));
		}
		
		void ButtonAddressDetailsClick(object sender, EventArgs e)
		{
			using (var f = new AddressForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					richTextBoxAddress.Text = f.Address.ToString();
				}
			}
		}
	}
}
