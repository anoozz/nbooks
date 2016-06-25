//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class LoginForm : BaseForm
	{
		User user;
		
		public User User {
			get { 
				user.Name = textBoxName.Text;
				user.Password = textBoxPassword.Text;
				return user; 
			}
			set { user = value; }
		}
		
		public LoginForm(Company company) : this(new User(), company)
		{
		}
		
		public LoginForm(User user, Company company)
		{
			InitializeComponent();
			labelCompanyName.Text = company.Name;
			this.User = user;
		}
		
		public void ClearPassword()
		{
			textBoxPassword.Clear();
			textBoxPassword.Focus();
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
//			if (CheckUser != null) {
//				CheckUser(User, e);
//			}
			OnCheckUser(new UserEventArgs(User));
		}
		
		public event EventHandler<UserEventArgs> CheckUser;
		
		protected virtual void OnCheckUser(UserEventArgs e)
		{
			if (CheckUser != null) {
				CheckUser(this, e);
			}
		}
	}
}
