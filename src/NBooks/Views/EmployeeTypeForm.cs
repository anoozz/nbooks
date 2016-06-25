//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class EmployeeTypeForm : BaseForm
	{
		EmployeeType type;
		
		public EmployeeType EmployeeType {
			get { 
				type.Name = textBoxName.Text;
				type.Inactive = checkBoxInactive.Checked;
				return type;
			}
			set {
				type = value;
				textBoxName.Text = type.Name;
				checkBoxInactive.Checked = type.Inactive;
			}
		}
		
		public EmployeeTypeForm() : this(new EmployeeType())
		{
		}
		
		public EmployeeTypeForm(EmployeeType type)
		{
			InitializeComponent();
			this.EmployeeType = type;
		}
		
		public event EmployeeTypeEventHandler SaveEmployeeType;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveEmployeeType != null) {
				SaveEmployeeType(EmployeeType, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
