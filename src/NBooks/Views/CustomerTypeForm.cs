//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class CustomerTypeForm : BaseForm
	{
		CustomerType type;
		
		public CustomerType CustomerType {
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
		
		public CustomerTypeForm() : this(new CustomerType())
		{
		}
		
		public CustomerTypeForm(CustomerType type)
		{
			InitializeComponent();
			this.CustomerType = type;
		}
		
		public event CustomerTypeEventHandler SaveCustomerType;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveCustomerType != null) {
				SaveCustomerType(CustomerType, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
