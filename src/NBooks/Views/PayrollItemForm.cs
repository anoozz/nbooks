//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of PayrollItemForm.
	/// </summary>
	public partial class PayrollItemForm : BaseForm
	{
		PayrollItem item;
		
		public PayrollItem PayrollItem {
			get { 
				item.Name = textBoxName.Text;
				item.Inactive = checkBoxInactive.Checked;
				return item;
			}
			set { 
				item = value;
				textBoxName.Text = item.Name;
				checkBoxInactive.Checked = item.Inactive;
			}
		}
		
		public PayrollItemForm() : this(new PayrollItem())
		{
		}
		
		public PayrollItemForm(PayrollItem item)
		{
			InitializeComponent();
			this.PayrollItem = item;
		}
		
		public event PayrollItemEventHandler SavePayrollItem;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePayrollItem != null) {
				SavePayrollItem(PayrollItem, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
