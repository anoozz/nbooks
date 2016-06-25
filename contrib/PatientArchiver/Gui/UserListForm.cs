/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using PatientArchiver.Model;

namespace PatientArchiver.Gui
{
	/// <summary>
	/// Description of UserListForm.
	/// </summary>
	public partial class UserListForm : Form
	{
		IList<User> users;
		
		public IList<User> Users {
			get { return users; }
			set { 
				users = value;
				listBox1.Items.Clear();
				foreach (var u in users) {
					listBox1.Items.Add(u.Name);
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
		
		void ButtonCloseClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
