//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class LoanTypeForm : BaseForm
	{
		LoanType type;
		
		public LoanType LoanType {
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
		
		public LoanTypeForm() : this(new LoanType())
		{
		}
		
		public LoanTypeForm(LoanType type)
		{
			InitializeComponent();
			this.LoanType = type;
		}
		
		public event LoanTypeEventHandler SaveLoanType;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveLoanType != null) {
				SaveLoanType(LoanType, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
