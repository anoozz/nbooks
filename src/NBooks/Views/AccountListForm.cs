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
	public partial class AccountListForm : BaseForm
	{
		IList<Account> accounts;
		
		public Account SelectedAccount {
			get {
				if (listViewAccounts.SelectedItems.Count > 0) {
					return accounts[listViewAccounts.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Account> SelectedAccounts {
			get {
				IList<Account> selectedAccounts = new List<Account>();
				foreach (ListViewItem li in listViewAccounts.SelectedItems) {
					selectedAccounts.Add(accounts[li.Index]);
				}
				return selectedAccounts;
			}
		}
		
		public IList<Account> Accounts {
			get { return accounts; }
			set { 
				accounts = value;
				listViewAccounts.Items.Clear();
				foreach (Account a in accounts) {
					ListViewItem li = listViewAccounts.Items.Add(a.Name);
					li.SubItems.Add(AccountForm.AccountTypes[a.Type].Name);
					li.SubItems.Add(a.Balance.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
				toolStripDropDownButtonAccount.Text = string.Format("{0} Accounts", accounts.Count);
			}
		}
		
		public AccountListForm()
		{
			InitializeComponent();
			listViewAccounts.Resize += delegate { columnHeader1.Width = listViewAccounts.Width - 22 - (columnHeader2.Width + columnHeader3.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnAccountAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedAccount != null) {
					OnAccountEdit(new AccountEventArgs(SelectedAccount));
				}
			};
			listViewAccounts.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var account in SelectedAccounts) {
					OnAccountDelete(new AccountEventArgs(account));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var account in SelectedAccounts) {
					OnAccountMakeInactive(new AccountEventArgs(account));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnAccountsList(e);
		}
		
		public event EventHandler AccountsList;
		
		protected virtual void OnAccountsList(EventArgs e)
		{
			if (AccountsList != null) {
				AccountsList(this, e);
			}
		}
		public event EventHandler AccountAdd;
		
		protected virtual void OnAccountAdd(EventArgs e)
		{
			if (AccountAdd != null) {
				AccountAdd(this, e);
			}
		}
		public event EventHandler<AccountEventArgs> AccountEdit;
		
		protected virtual void OnAccountEdit(AccountEventArgs e)
		{
			if (AccountEdit != null) {
				AccountEdit(this, e);
			}
		}
		public event EventHandler<AccountEventArgs> AccountDelete;
		
		protected virtual void OnAccountDelete(AccountEventArgs e)
		{
			if (AccountDelete != null) {
				AccountDelete(this, e);
			}
		}
		public event EventHandler<AccountEventArgs> AccountMakeInactive;
		
		protected virtual void OnAccountMakeInactive(AccountEventArgs e)
		{
			if (AccountMakeInactive != null) {
				AccountMakeInactive(this, e);
			}
		}
	}
}
