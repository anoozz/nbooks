//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>


using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ChangePasswordForm : BaseForm
	{
		User user;
		
		public string NewPassword {
			get { return textBoxNewPassword.Text; }
		}
		
		public string ConfirmPassword {
			get { return textBoxConfirmPassword.Text; }
		}
		
		public User User {
			get {
				user.Name = textBoxName.Text;
				user.ChallengeQuestion = comboBoxChallengeQuestion.SelectedIndex;
				user.Answer = textBoxAswer.Text;
				return user;
			}
			set { 
				user = value;
				textBoxName.Text = user.Name;
				comboBoxChallengeQuestion.SelectedIndex = user.ChallengeQuestion;
				textBoxAswer.Text = user.Answer;
			}
		}
		
		public ChangePasswordForm(User user)
		{
			InitializeComponent();
			SwfUtility.SetupComboBox(comboBoxChallengeQuestion, User.ChallengeQuestions);
			this.User = user;
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
//			if (SaveUser != null) SaveUser(User, e);
			OnSaveUser(new UserEventArgs(User));
		}
		
		public event EventHandler<UserEventArgs> SaveUser;
		
		protected virtual void OnSaveUser(UserEventArgs e)
		{
			if (SaveUser != null) {
				SaveUser(this, e);
			}
		}
	}
}
