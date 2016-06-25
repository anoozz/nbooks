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
	public class ListUsers : AbstractCommand
	{
		public override void Run()
		{
			UserListForm form = new UserListForm();
			IUserRepository dao = new NHibernateUserRepository();
			form.UsersList += delegate { form.Users = dao.FindActive(); };
			WorkbenchSingleton.AddDialog(form);
		}
	}
	
	public class Login2 : AbstractCommand
	{
		Company company;
		
		public Login2(Company company)
		{
			this.company = company;
		}
		
		public override void Run()
		{
//			using (var loginView = new LoginForm(company)) {
//				WorkbenchSingleton.MainForm.Visible = true;
//				WorkbenchSingleton.MainForm.IsMdiContainer = true;
//				loginView.CheckUser += delegate(User sender, EventArgs e) { 
//					User dummy = User.ReadByNameAndPassword(sender.Name, sender.Password);
//					if (dummy == null) {
//						MessageService.ShowWarning(ResourceUtility.GetString("user.invalidPassword"));
//						loginView.ClearPassword();
//					} else {
//						UserSingleton.Instance = dummy;
//						WorkbenchSingleton.UnFreezeControlForLogin();
//						loginView.DialogResult = DialogResult.OK;
//						loginView.Close();
//						new ShowHomePage().Run();
//					}
//				};
//				WorkbenchSingleton.FreezeControlForLogin();
//				if (WorkbenchSingleton.AddDialog(loginView) == DialogResult.Cancel) {
//					WorkbenchSingleton.MainForm.Close();
//				}
//			}
		}
	}
	
	[Obsolete()]
	public class Login : AbstractCommand
	{
		Company company;
		
		public Login(Company company)
		{
			this.company = company;
		}
		
		public override void Run()
		{
//			var mainView = WorkbenchSingleton.MainForm;
//			mainView.Load += delegate { 
//				mainView.Visible = true;
//				
//				var loginView = new LoginForm(company);
//				loginView.CheckUser += delegate(User sender, EventArgs e) { 
//					User dummy = User.ReadByNameAndPassword(sender.Name, sender.Password);
//					if (dummy == null) {
//						MessageService.ShowWarning(ResourceUtility.GetString("user.invalidPassword"));
//						loginView.ClearPassword();
//					} else {
//						UserSingleton.Instance = dummy;
//						WorkbenchSingleton.UnFreezeControlForLogin();
//						loginView.DialogResult = DialogResult.OK;
//						loginView.Close();
//						new ShowHomePage().Run();
//					}
//				};
//				WorkbenchSingleton.FreezeControlForLogin();
//				if (WorkbenchSingleton.AddDialog(loginView) == DialogResult.Cancel) {
//					WorkbenchSingleton.MainForm.Close();
//				}
//			};
		}
	}
	
	public class ChangePassword : AbstractCommand
	{
		public override void Run()
		{
//			var view = new ChangePasswordForm(UserSingleton.Instance);
//			view.SaveUser += delegate(User sender, EventArgs e) { 
//				if (view.NewPassword != string.Empty) {
//					if (view.NewPassword == view.ConfirmPassword) {
//						sender.SaveOrUpdate();
//						view.Close();
//					} else {
//						MessageService.ShowWarning("Passwords do not match!");
//					}
//				} else {
//					sender.SaveOrUpdate();
//					view.Close();
//				}
//			};
//			WorkbenchSingleton.AddDialog(view);
			ChangePasswordForm form = new ChangePasswordForm(UserSingleton.Instance);
			WorkbenchSingleton.AddDialog(form);
		}
	}
	
	public class AddUser : AbstractCommand
	{
		public override void Run()
		{
			UserForm form = new UserForm();
			IUserRepository dao = new NHibernateUserRepository();
			WorkbenchSingleton.AddDialog(form);
		}
	}
	
	public class EditUser : AbstractCommand
	{
		User user;
		
		public EditUser(User user)
		{
			this.user = user;
		}
		
		public override void Run()
		{
			UserForm form = new UserForm(user);
			IUserRepository dao = new NHibernateUserRepository();
			WorkbenchSingleton.AddDialog(form, "Edit User");
		}
	}
}
