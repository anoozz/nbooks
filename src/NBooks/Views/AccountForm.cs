//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Views.Accounts;

namespace NBooks.Views
{
	public partial class AccountForm : BaseForm
	{
		Account account;
		
		public static AccountType[] AccountTypes {
			get {
				return new AccountType[] {
					new BankAccountType(),
					new AccountsReceivableAccountType(),
					new OtherCurrentAssetAccountType(),
					new FixedAssetAccountType(),
					new OtherAssetAccountType(),
					new AccountsPayableAccountType(),
					new CreditCardAccountType(),
					new OtherCurrentLiabilityAccountType(),
					new LongTermLiabilityAccountType(),
					new EquityAccountType(),
					new IncomeAccountType(),
					new CostOfGoodsSoldAccountType(),
					new ExpenseAccountType(),
					new OtherIncomeAccountType(),
					new OtherExpenseAccountType(),
				};
			}
		}
		
		public Account Account {
			get { 
				account.Type = comboBoxType.SelectedIndex;
				account.Name = textBoxName.Text;
				account.Description = richTextBoxDescription.Text;
				return account; 
			}
			set { 
				account = value;
				comboBoxType.SelectedIndex = account.Type;
				textBoxName.Text = account.Name;
				richTextBoxDescription.Text = account.Description;
			}
		}
		
		public AccountForm() : this(new Account())
		{
		}
		
		public AccountForm(Account account)
		{
			InitializeComponent();
			SwfUtility.SetupComboBox(comboBoxType, AccountTypes, "Id", "Name");
			this.Account = account;
		}
		
		public event EventHandler<AccountEventArgs> AccountSaveAndClose;
		public event EventHandler<AccountEventArgs> AccountSaveAndClear;
		
		protected virtual void OnAccountSaveAndClear(AccountEventArgs e)
		{
			if (AccountSaveAndClear != null) {
				AccountSaveAndClear(this, e);
			}
		}
		
		protected virtual void OnAccountSaveAndClose(AccountEventArgs e)
		{
			if (AccountSaveAndClose != null) {
				AccountSaveAndClose(this, e);
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnAccountSaveAndClose(new AccountEventArgs(Account));
		}
		
		void ButtonSaveAndNewClick(object sender, EventArgs e)
		{
			OnAccountSaveAndClear(new AccountEventArgs(Account));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
