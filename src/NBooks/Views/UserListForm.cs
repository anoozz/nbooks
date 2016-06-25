//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Commands;
using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class UserListForm : BaseForm
	{
		IList<User> users;
		
		public IList<User> Users {
			get { return users; }
			set { 
				users = value; 
				listBoxUsers.Items.Clear();
				foreach (User u in users) {
					listBoxUsers.Items.Add(u.Name);
				}
			}
		}
		
		public UserListForm()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnUsersList(e);
		}
		
		public event EventHandler UsersList;
		
		protected virtual void OnUsersList(EventArgs e)
		{
			if (UsersList != null) {
				UsersList(this, e);
			}
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			WorkbenchSingleton.AddDialog(new UserForm());
		}
		
		void ButtonCloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (listBoxUsers.SelectedIndex >= 0) {
//				DeleteUser(users[listBoxUsers.SelectedIndex], null);
				OnDeleteUser(new UserEventArgs(users[listBoxUsers.SelectedIndex]));
//				if (MessageService.ShowYesNo("Are you sure you want to delete?") == DialogResult.Yes) {
//					SessionFacade.DeleteUser(u);
					OnActivated(null);
//				}
			}
		}
		
		public event EventHandler<UserEventArgs> DeleteUser;
		
		protected virtual void OnDeleteUser(UserEventArgs e)
		{
			if (DeleteUser != null) {
				DeleteUser(this, e);
			}
		}
		
		void ButtonEditClick(object sender, EventArgs e)
		{
			if (listBoxUsers.SelectedIndex >= 0) {
				new EditUser(users[listBoxUsers.SelectedIndex]).Run();
//				Gui.MainForm.Instance.AddDialog(new UserForm(u));
			}
		}
		
		void ButtonClosingDateClick(object sender, EventArgs e)
		{
			// TODO: Closing date
		}
	}
}
