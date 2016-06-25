//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListAccounts : AbstractCommand
	{
		public override void Run()
		{
			AccountListForm form = new AccountListForm();
//			IAccountDao dao = new NHibernateAccountDao();
//			form.AccountsList += delegate { form.Accounts = dao.FindActive(); };
			form.AccountsList += delegate { form.Accounts = Account.FindAll(); };
			form.AccountAdd += delegate { new AddAccount().Run(); };
			form.AccountEdit += delegate(object sender, AccountEventArgs e) { 
				new EditAccount(e.Account).Run();
			};
			form.AccountDelete += delegate(object sender, AccountEventArgs e) { 
				e.Account.Delete();
//				dao.Delete(e.Account);
			};
			form.AccountMakeInactive += delegate(object sender, AccountEventArgs e) { 
				e.Account.MakeInactive();
//				dao.MakeInactive(e.Account);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddAccount : AbstractCommand
	{
		public override void Run()
		{
			AccountForm form = new AccountForm();
//			IAccountDao dao = new NHibernateAccountDao();
			form.AccountSaveAndClose += delegate(object sender, AccountEventArgs e) { 
				e.Account.SaveOrUpdate();
//				dao.SaveOrUpdate(e.Account);
				form.Close();
			};
			form.AccountSaveAndClear += delegate(object sender, AccountEventArgs e) { 
//				dao.SaveOrUpdate(e.Account);
				e.Account.SaveOrUpdate();
				form.Account = new Account();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditAccount : AbstractCommand
	{
		Account account;
		
		public EditAccount(Account account)
		{
			this.account = account;
		}
		
		public override void Run()
		{
			AccountForm form = new AccountForm();
//			IAccountDao dao = new NHibernateAccountDao();
			form.AccountSaveAndClose += delegate(object sender, AccountEventArgs e) { 
//				dao.SaveOrUpdate(e.Account);
				e.Account.SaveOrUpdate();
				form.Close();
			};
			form.AccountSaveAndClear += delegate(object sender, AccountEventArgs e) { 
//				dao.SaveOrUpdate(e.Account);
				e.Account.SaveOrUpdate();
				form.Account = new Account();
			};
			WorkbenchSingleton.AddChild(form, "Edit Account");
		}
	}
}
