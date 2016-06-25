//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PayrollCodeForm : BaseForm
	{
		PayrollCode code;
		
		public PayrollCode PayrollCode {
			get { 
				code.Code = textBoxCode.Text;
				code.DateFrom = dateTimePickerFrom.Value;
				code.DateTo = dateTimePickerTo.Value;
				code.Inactive = checkBoxInactive.Checked;
				return code;
			}
			set {
				code = value;
				textBoxCode.Text = code.Code;
				dateTimePickerFrom.Value = DateUtility.GetValid(code.DateFrom);
				dateTimePickerTo.Value = DateUtility.GetValid(code.DateTo);
				checkBoxInactive.Checked = code.Inactive;
			}
		}
		
		public PayrollCodeForm() : this(new PayrollCode())
		{
		}
		
		public PayrollCodeForm(PayrollCode code)
		{
			InitializeComponent();
			this.PayrollCode = code;
		}
		
		public event PayrollCodeEventHandler SavePayrollCode;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePayrollCode != null) SavePayrollCode(PayrollCode, e);
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
