//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class UserForm : BaseForm
	{
		User user;
		IList<Module> modules = new List<Module>();
		
		public IList<Module> Modules {
			get { return modules; }
			set { modules = value; }
		}
		
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
				if (user.Id == 0) {
					foreach (Module m in modules) {
						user.AddModule(m);
					}
				}
				ComboBoxModuleSelectedIndexChanged(this, null);
			}
		}
		
		public UserForm() : this(new User())
		{
		}
		
		public UserForm(User user)
		{
			InitializeComponent();
			SwfUtility.SetupComboBox(comboBoxModule, modules, "Id", "Name");
			this.User = user;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
//			if (SaveUser != null) {
//				SaveUser(User, e);
//			}
			OnSaveUser(new UserEventArgs(User));
			Close();
		}
		
		public event EventHandler<UserEventArgs> SaveUser;
		
		protected virtual void OnSaveUser(UserEventArgs e)
		{
			if (SaveUser != null) {
				SaveUser(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ComboBoxModuleSelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxModule.SelectedIndex >= 0) {
				Module m = modules[comboBoxModule.SelectedIndex];
				listViewAvailablePriveleges.Items.Clear();
				foreach (ModuleCommand c in m.Commands) {
					ListViewItem li = listViewAvailablePriveleges.Items.Add(c.Name);
				}
				UserModule module = user.GetModule(m);
				listViewGrantedPriveleges.Items.Clear();
				foreach (UserModuleCommand command in module.Commands) {
					ListViewItem li = listViewGrantedPriveleges.Items.Add(command.Command.Name);
				}
			}
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			if (listViewAvailablePriveleges.SelectedItems.Count > 0) {
				Module m = modules[comboBoxModule.SelectedIndex];
				ModuleCommand c = m.Commands[listViewAvailablePriveleges.SelectedItems[0].Index];
				
				UserModule module = user.GetModule(m);
				module.AddCommand(c);
				
				ComboBoxModuleSelectedIndexChanged(sender, e);
			}
		}
		
		void ButtonRemoveClick(object sender, EventArgs e)
		{
			if (listViewGrantedPriveleges.SelectedItems.Count > 0) {
				Module m = modules[comboBoxModule.SelectedIndex];
				
				UserModule module = user.GetModule(m);
				
				UserModuleCommand c = module.Commands[listViewGrantedPriveleges.SelectedItems[0].Index];
				module.Commands.Remove(c);
				ComboBoxModuleSelectedIndexChanged(sender, e);
			}
		}
	}
}
