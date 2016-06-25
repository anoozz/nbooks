/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using PatientArchiver.Model;

namespace PatientArchiver.Gui
{
	/// <summary>
	/// Description of UserForm.
	/// </summary>
	public partial class UserForm : Form
	{
		User user;
		
		public User User {
			get {
				user.Name = textBoxName.Text;
				user.Password = textBoxPassword.Text;
				return user;
			}
			set {
				user = value;
				textBoxName.Text = user.Name;
				textBoxPassword.Text = user.Password;
			}
		}
		
		public UserForm() : this(new User())
		{
		}
		
		public UserForm(User user)
		{
			InitializeComponent();
			this.User = user;
		}
		
		public event EventHandler<UserEventArgs> UserSave;
		
		protected virtual void OnUserSave(UserEventArgs e)
		{
			if (UserSave != null) {
				UserSave(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnUserSave(new UserEventArgs(User));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
