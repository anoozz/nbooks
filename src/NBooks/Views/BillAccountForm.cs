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
	public partial class BillAccountForm : BaseForm
	{
		BillAccount account;
		IList<Account> accounts;
		IList<Customer> customers;
		IList<Class> classes;
		
		public IList<Class> Classes {
			get { return classes; }
			set { classes = value; SwfUtility.SetupComboBox(comboBoxClass, classes, "Id", "Name", account.Class); }
		}
		
		public IList<Customer> Customers {
			get { return customers; }
			set { customers = value; SwfUtility.SetupComboBox(comboBoxCustomer, customers, "Id", "Name", account.Customer); }
		}
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { accounts = value; SwfUtility.SetupComboBox(comboBoxAccount, accounts, "Id", "Name", account.Account); }
		}
		
		public BillAccount BillAccount {
			get { 
				account.Account = SwfUtility.GetComboBoxValue<Account>(comboBoxAccount);
				account.Amount = ConvertUtility.ToDouble(textBoxAmount.Text);
				account.Memo = textBoxMemo.Text;
				account.Customer = SwfUtility.GetComboBoxValue<Customer>(comboBoxCustomer);
				account.Billable = checkBoxBillable.Checked;
				account.Class = SwfUtility.GetComboBoxValue<Class>(comboBoxClass);
				return account; 
			}
			set { 
				account = value;
				textBoxAmount.Text = account.Amount.ToString("0.00");
				textBoxMemo.Text = account.Memo;
				checkBoxBillable.Checked = account.Billable;
			}
		}
		
		public BillAccountForm() : this(new BillAccount())
		{
		}
		
		public BillAccountForm(BillAccount account)
		{
			InitializeComponent();
			this.BillAccount = account;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (AccountsList != null) AccountsList(this, null);
		}
		
		public event EventHandler AccountsList;
	}
}
