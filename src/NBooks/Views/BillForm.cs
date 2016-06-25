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
	public partial class BillForm : BaseForm
	{
		IList<Vendor> vendors;
		Bill bill;
		IList<Terms> terms;
		IList<Account> accounts;
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { 
				accounts = value; 
				SwfUtility.SetupComboBox(comboBoxAccounts, accounts, "Id", "Name", bill.Account);
				labelAPAccounts.Visible = comboBoxAccounts.Visible = accounts.Count > 1;
			}
		}
		
		public IList<Terms> Terms {
			get { return terms; }
			set { 
				terms = value;
				SwfUtility.SetupComboBox(comboBoxTerms, terms, "Id", "Name", bill.Terms);
			}
		}
		
		public Bill Bill {
			get { 
				bill.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccounts);
				bill.Vendor = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
				bill.VendorAddress = richTextBoxAddress.Text;
				bill.Terms = SwfUtility.GetComboBoxValue<Terms>(comboBoxTerms);
				bill.Memo = textBoxMemo.Text;
				bill.Date = dateTimePickerDate.Value;
				bill.RefNo = textBoxRefNo.Text;
				bill.Amount = ConvertUtility.ToDouble(textBoxAmount.Text);
				bill.DueDate = dateTimePickerDueDate.Value;
				return bill;
			}
			set {
				bill = value;
				textBoxMemo.Text = bill.Memo;
				dateTimePickerDate.Value = DateUtility.GetValid(bill.Date);
				textBoxRefNo.Text = bill.RefNo;
				textBoxAmount.Text = bill.Amount.ToString("0.00");
				dateTimePickerDueDate.Value = bill.Id == 0 ? dateTimePickerDate.Value.AddDays(10) : bill.DueDate;
				bill.ItemsChanged += new EventHandler(BillItemsChanged);
				bill.AccountsChanged += new EventHandler(BillAccountsChanged);
			}
		}
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { 
				vendors = value; 
				SwfUtility.SetupComboBox(comboBoxVendor, vendors, "Id", "Name", bill.Vendor);
			}
		}
		
		public BillForm() : this(new Bill())
		{
		}
		
		public BillForm(Bill bill)
		{
			InitializeComponent();
			this.Bill = bill;

			listViewItems.Resize += delegate { columnHeader2.Width = listViewItems.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width + columnHeader8.Width + columnHeader9.Width); };
			listViewAccounts.Resize += delegate { columnHeader10.Width = listViewAccounts.Width - 22 - (columnHeader11.Width + columnHeader12.Width + columnHeader13.Width + columnHeader14.Width + columnHeader15.Width); };
			newItemToolStripMenuItem.Click += delegate { 
				if (ItemAdding != null) ItemAdding(new BillItem(), null);
			};
			editItemToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					if (ItemChanging != null) ItemChanging(bill.Items[listViewItems.SelectedItems[0].Index], null);
				}
			};
			deleteItemToolStripMenuItem.Click += delegate { 
				if (listViewItems.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listViewItems.SelectedItems) {
						bill.RemoveItem(bill.Items[li.Index]);
					}
				}
			};
			
			newAccountToolStripMenuItem.Click += delegate { 
				if (AccountAdding != null) AccountAdding(new BillAccount(), null);
			};
			editAccountToolStripMenuItem.Click += delegate { 
				if (listViewAccounts.SelectedItems.Count > 0) {
					if (AccountChanging != null) AccountChanging(bill.Accounts[listViewAccounts.SelectedItems[0].Index], null);
				}
			};
			deleteAccountToolStripMenuItem.Click += delegate { 
				if (listViewAccounts.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listViewAccounts.SelectedItems) {
						bill.RemoveAccount(bill.Accounts[li.Index]);
					}
				}
			};
		}
		
		void BillItemsChanged(object sender, EventArgs e)
		{
			listViewItems.Items.Clear();
			foreach (var i in bill.Items) {
				ListViewItem li = listViewItems.Items.Add(i.Item.Name);
				li.SubItems.Add(i.Item.PurchaseDescription);
				li.SubItems.Add(i.Quantity.ToString("0.0"));
				li.SubItems.Add(i.Item.Unit != null ? i.Item.Unit.Name : "");
				li.SubItems.Add(i.Price.ToString("###,##0.00"));
				li.SubItems.Add(i.Amount.ToString("###,##0.00"));
				li.SubItems.Add(i.Customer != null ? i.Customer.Name : "");
				li.SubItems.Add(i.Billable ? "Yes" : "No");
				li.SubItems.Add(i.Class != null ? i.Class.Name : "");
			}
		}
		
		void BillAccountsChanged(object sender, EventArgs e)
		{
			listViewAccounts.Items.Clear();
			foreach (var a in bill.Accounts) {
				ListViewItem li = listViewAccounts.Items.Add(a.Account != null ? a.Account.Name : "");
				li.SubItems.Add(a.Amount.ToString("###,##0.00"));
				li.SubItems.Add(a.Memo);
				li.SubItems.Add(a.Customer != null ? a.Customer.Name : "");
				li.SubItems.Add(a.Billable ? "Yes" : "No");
				li.SubItems.Add(a.Class != null ? a.Class.Name : "");
			}
			textBoxAmount.Text = bill.TotalAmount.ToString("###,##0.00");
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (VendorsList != null) VendorsList(this, null);
			if (AccountsList != null) AccountsList(this, null);
			if (TermsList != null) TermsList(this, null);
		}
		
		public event EventHandler VendorsList;
		
		public event EventHandler AccountsList;
		
		public event EventHandler TermsList;
		
		public event EventHandler<BillEventArgs> BillSave;
		
		public event EventHandler<BillEventArgs> BillSaveAndClose;
		
		public event EventHandler<BillEventArgs> BillSaveAndClear;
		
		public event EventHandler<BillAccountEventArgs> AccountAdding;
		
		public event EventHandler<BillItemEventArgs> ItemAdding;
		
		public event EventHandler<BillAccountEventArgs> AccountChanging;
		
		public event EventHandler<BillItemEventArgs> ItemChanging;
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			if (BillSaveAndClose != null) BillSaveAndClose(Bill, null);
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			if (BillSaveAndClear != null) BillSaveAndClear(Bill, null);
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			if (BillSave != null) BillSave(Bill, null);
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ComboBoxVendorSelectedIndexChanged(object sender, EventArgs e)
		{
			Vendor v = SwfUtility.GetComboBoxValue<Vendor>(comboBoxVendor);
			if (v != null) {
				richTextBoxAddress.Text = v.Address;
			}
		}
		
		void ButtonSelectPOClick(object sender, EventArgs e)
		{
			
		}
	}
}
