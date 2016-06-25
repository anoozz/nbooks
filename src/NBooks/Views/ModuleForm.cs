//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class ModuleForm : BaseForm
	{
		Module module;
		
		public Module Module {
			get { 
				module.Name = textBoxName.Text;
				module.Inactive = checkBoxInactive.Checked;
				return module; 
			}
			set { 
				module = value;
				textBoxName.Text = module.Name;
				checkBoxInactive.Checked = module.Inactive;
				module.CommandsChanged += new EventHandler(ModuleCommandsChanged);
				ModuleCommandsChanged(this, null);
			}
		}
		
		public ModuleForm() : this(new Module())
		{
		}
		
		public ModuleForm(Module module)
		{
			InitializeComponent();
			this.Module = module;
		}
		
		void ModuleCommandsChanged(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			foreach (ModuleCommand command in module.Commands) {
				ListViewItem li = listView1.Items.Add(command.Name);
				li.SubItems.Add(command.Command);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveModule != null) SaveModule(Module, null);
		}
		
		public event ModuleEventHandler SaveModule;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonNewClick(object sender, EventArgs e)
		{
			using (ModuleCommandForm f = new ModuleCommandForm()) {
				if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
					module.AddCommand(f.Command);
				}
			}
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				foreach (ListViewItem li in listView1.SelectedItems) {
					module.RemoveCommand(module.Commands[li.Index]);
				}
			}
		}
		
		void ButtonEditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				ModuleCommand command = module.Commands[listView1.SelectedItems[0].Index];
				using (ModuleCommandForm f = new ModuleCommandForm(command)) {
					f.Text = "Edit Module Command";
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						ModuleCommandsChanged(this, null);
					}
				}
			}
		}
	}
}
