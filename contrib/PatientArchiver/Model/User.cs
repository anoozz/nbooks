/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/21/2011
 * Time: 2:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace PatientArchiver.Model
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		public virtual string Name { get; set; }
		public virtual string Password { get; set; }
		
		public User()
		{
		}
	}
	
	public class UserEventArgs : EventArgs
	{
		public User User { get; set; }
		
		public UserEventArgs(User user)
		{
			this.User = user;
		}
	}
}
