//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class PaymentMethodForm : BaseForm
	{
		PaymentMethod method;
		public static string[] PaymentTypes {
			get {
				return new string[] {
					"Cash",
					"Check",
					"American Express",
					"Discover",
					"Master Card",
					"Visa",
					"Other credit card",
					"Other",
					"Debit Card",
					"Gift Card",
					"E-Check",
				};
			}
		}
		
		public PaymentMethod PaymentMethod {
			get { 
				method.Name = textBoxName.Text;
				method.Type = comboBoxType.SelectedIndex;
				method.Inactive = checkBoxInactive.Checked;
				return method;
			}
			set { 
				method = value;
				textBoxName.Text = method.Name;
				comboBoxType.SelectedIndex = method.Type;
				checkBoxInactive.Checked = method.Inactive;
			}
		}
		
		public PaymentMethodForm() : this(new PaymentMethod())
		{
		}
		
		public PaymentMethodForm(PaymentMethod method)
		{
			InitializeComponent();
			SwfUtility.SetupComboBox(comboBoxType, PaymentTypes, "", "");
			this.PaymentMethod = method;
		}
		
		public event PaymentMethodEventHandler SavePaymentMethod;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePaymentMethod != null) {
				SavePaymentMethod(PaymentMethod, null);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
