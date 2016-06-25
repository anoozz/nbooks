//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Reflection;

using NBooks.Core.Util;

namespace NBooks.Core.Models
{
	public class User : BaseModel<User>
	{
		IList<UserModule> modules = new List<UserModule>();
		
		public User()
		{
		}
		
		public User(string name, string password)
		{
			this.Name = name;
			this.Password = password;
		}
		
		public virtual int ChallengeQuestion { get; set; }
		
		public virtual string Answer { get; set; }
		
		public virtual string Name { get; set; }
		
		public virtual string Password { get; set; }
		
		public virtual bool Inactive { get; set; }
		
		public static string[] ChallengeQuestions {
			get {
				return new string[] {
					"Name of oldest nephew",
					"Name of oldest niece",
					"City where you went to high school",
					"Name of your high school",
					"Best man's name at your wedding",
					"Maid of honor's name at your wedding",
					"Best friend's last or first name",
					"Name of the first company you worked for",
					"City where your vacation home is located",
					"First boyfriend or girlfriend's name",
					"Name of your first manager",
					"Name of your first pet",
					"Your high school mascot",
					"Favorite restaurant in college",
					"Where you met your spouse",
					"City where your father/mother grew up",
					"City where your father/mother went to high school",
					"Grandfather's nickname",
					"Favorite teacher's name",
				};
			}
		}
		
		public virtual IList<UserModule> Modules {
			get { return modules; }
			set { modules = value; }
		}
		
		public virtual void ResetPassword()
		{
			this.Password = "root";
		}
		
		public virtual UserModule GetModule(Module m)
		{
			foreach (UserModule t in modules) {
				if (t.Module.Id == m.Id) {
					return t;
				}
			}
			return null;
		}
		
		public virtual void AddModule(Module m)
		{
			AddModule(m, false, false, false);
		}
		
		public virtual void AddModule(Module m, bool canAdd, bool canModify, bool canDelete)
		{
			AddModule(new UserModule(m, canAdd, canModify, canDelete));
		}
		
		public virtual void AddModule(UserModule m)
		{
			m.User = this;
			modules.Add(m);
		}
		
		public virtual bool HasAccess(ICommand command)
		{
			throw new NotImplementedException();
		}
	}
	
	public class UserModule : BaseModel<UserModule>
	{
		IList<UserModuleCommand> commands = new List<UserModuleCommand>();
		
		public UserModule()
		{
		}
		
		public UserModule(Module module, bool canAdd, bool canModify, bool canDelete)
		{
			this.Module = module;
			this.CanAdd = canAdd;
			this.CanModify = canModify;
			this.CanDelete = canDelete;
		}
		
		public virtual event EventHandler CommandAdded;
		
		public virtual User User { get; set; }
		
		public virtual Module Module { get; set; }
		
		public virtual bool CanAdd { get; set; }
		
		public virtual bool CanModify { get; set; }
		
		public virtual bool CanDelete { get; set; }
		
		public virtual IList<UserModuleCommand> Commands {
			get { return commands; }
			set { commands = value; }
		}
		
		public virtual void AddCommand(ModuleCommand command)
		{
			AddCommand(new UserModuleCommand(command));
		}
		
		public virtual void AddCommand(UserModuleCommand command)
		{
			command.Module = this;
			commands.Add(command);
			OnCommandAdded(null);
		}
		
		protected virtual void OnCommandAdded(EventArgs e)
		{
			if (CommandAdded != null) {
				CommandAdded(this, e);
			}
		}
	}
	
	public class UserModuleCommand : BaseModel<UserModuleCommand>
	{
		public UserModuleCommand()
		{
		}
		
		public UserModuleCommand(ModuleCommand command)
		{
			this.Command = command;
		}
		
		public virtual UserModule Module { get; set; }
		
		public virtual ModuleCommand Command { get; set; }
		
		public virtual ICommand CreateCommandInstance()
		{
			if (Command.Command != "") {
				Assembly a = Assembly.GetCallingAssembly();
				return (ICommand)a.CreateInstance(Command.Command);
			} else {
				return null;
			}
		}
	}
	
	public class UserSingleton
	{
		static User instance = new User();
		
		UserSingleton()
		{
		}
		
		public static User Instance {
			get { return instance; }
			set { instance = value; }
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
