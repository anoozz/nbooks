//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

using NBooks.Core.Util;

namespace NBooks.Core.Models
{
	public class Module : BaseModel<Module>
	{
		IList<ModuleCommand> commands = new List<ModuleCommand>();
		public virtual bool Inactive { get; set; }
		public virtual string Name { get; set; }
		public virtual string FormName { get; set; }
		
		public virtual IList<ModuleCommand> Commands {
			get { return commands; }
			set { commands = value; }
		}
		
		public Module()
		{
		}
		
		public Module(string name)
		{
			this.Name = name;
		}
		
		public virtual void AddCommand(string name, string command)
		{
			AddCommand(new ModuleCommand(name, command));
		}
		
		public virtual void AddCommand(ModuleCommand command)
		{
			command.Module = this;
			commands.Add(command);
			if (CommandsChanged != null) CommandsChanged(this, null);
		}
		
		public virtual void RemoveCommand(ModuleCommand command)
		{
			if (commands.Contains(command)) {
				commands.Remove(command);
				if (CommandsChanged != null) CommandsChanged(this, null);
			}
		}
		
		public virtual event EventHandler CommandsChanged;
	}
	
	/// <summary>
	/// Description of ModuleCommand.
	/// </summary>
	public class ModuleCommand : BaseModel<ModuleCommand>
	{
		public virtual Module Module { get; set; }
		public virtual string Name { get; set; }
		public virtual string Command { get; set; }
		
		public ModuleCommand()
		{
		}
		
		public ModuleCommand(string name, string command)
		{
			this.Name = name;
			this.Command = command;
		}
	}
	
	public delegate void ModuleEventHandler(Module sender, EventArgs e);
}
