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
	public partial class CheckForm : BaseForm
	{
		Check check;
		IList<Account> accounts;
		IList<Vendor> vendors;
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set {
				vendors = value;
				SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", check.Vendor);
			}
		}
		
		public IList<Account> Accounts {
			get { return accounts; }
			set {
				accounts = value; 
				SwfUtility.SetupComboBox(comboBoxAccount, accounts, "Id", "Name", check.Account);
			}
		}
		
		public Check Check {
			get { 
				check.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccount);
				check.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				check.Date = dateTimePickerDate.Value;
				check.Address = richTextBoxAddress.Text;
				check.Memo = textBoxMemo.Text;
				return check;
			}
			set { 
				check = value;
				dateTimePickerDate.Value = DateUtility.GetValid(check.Date);
				richTextBoxAddress.Text = check.Address;
				textBoxMemo.Text = check.Memo;
			}
		}
		
		public CheckForm() : this(new Check())
		{
		}
		
		public CheckForm(Check check)
		{
			InitializeComponent();
			this.Check = check;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListAccounts != null) ListAccounts(this, null);
			if (ListVendors != null) ListVendors(this, null);
		}
		
		public event EventHandler ListVendors;
		public event CheckEventHandler SaveCheck;
		public event CheckEventHandler SaveCheckAndClose;
		public event CheckEventHandler SaveCheckAndClear;
		public event EventHandler ListAccounts;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (SaveCheckAndClose != null) {
				SaveCheckAndClose(Check, e);
			}
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (SaveCheckAndClear != null) {
				SaveCheckAndClear(Check, e);
			}
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (SaveCheck != null) {
				SaveCheck(Check, e);
			}
		}
	}
}
