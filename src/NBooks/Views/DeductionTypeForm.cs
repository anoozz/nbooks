//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class DeductionTypeForm : BaseForm
	{
		DeductionType type;
		
		public DeductionType DeductionType {
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
		
		public DeductionTypeForm() : this(new DeductionType())
		{
		}
		
		public DeductionTypeForm(DeductionType type)
		{
			InitializeComponent();
			this.DeductionType = type;
		}
		
		public event DeductionTypeEventHandler SaveDeductionType;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveDeductionType != null) {
				SaveDeductionType(DeductionType, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
