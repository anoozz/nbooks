//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of ModuleCommandForm.
	/// </summary>
	public partial class ModuleCommandForm : BaseForm
	{
		ModuleCommand command;
		
		public ModuleCommand Command {
			get { 
				command.Name = textBoxName.Text;
				command.Command = textBoxCommand.Text;
				return command; 
			}
			set { 
				command = value; 
				textBoxName.Text = command.Name;
				textBoxCommand.Text = command.Command;
			}
		}
		
		public ModuleCommandForm() : this(new ModuleCommand())
		{
		}
		
		public ModuleCommandForm(ModuleCommand command)
		{
			InitializeComponent();
			this.Command = command;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
