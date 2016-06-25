//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class RequestPasswordForm : BaseForm
	{
		User user;
		
		public string Answer {
			get { return textBoxAnswer.Text; }
		}
		
		public User User {
			get { return user; }
			set { 
				user = value;
				textBoxQuestion.Text = User.ChallengeQuestions[user.ChallengeQuestion];
			}
		}
		
		public RequestPasswordForm(User user)
		{
			InitializeComponent();
			this.User = user;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
//			if (user.Answer != textBoxAnswer.Text) {
//				
//			}
//			else {
//				user.ResetPassword();
//				user.SaveOrUpdate();
//				Close();
//			} // TODO: Use delegate.
//			if (RequestPassword != null) {
//				RequestPassword(User, e);
//			}
			OnRequestPassword(new UserEventArgs(User));
		}
		
		public event EventHandler<UserEventArgs> RequestPassword;
		
		protected virtual void OnRequestPassword(UserEventArgs e)
		{
			if (RequestPassword != null) {
				RequestPassword(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
