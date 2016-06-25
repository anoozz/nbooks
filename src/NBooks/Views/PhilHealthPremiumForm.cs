//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class PhilHealthPremiumForm : BaseForm
	{
		PhilHealthPremium premium;
		
		public PhilHealthPremium PhilHealthPremium {
			get {
				premium.Code = textBoxCode.Text;
				return premium;
			}
			set {
				premium = value;
				textBoxCode.Text = premium.Code;
			}
		}
		
		public PhilHealthPremiumForm() : this(new PhilHealthPremium())
		{
		}
		
		public PhilHealthPremiumForm(PhilHealthPremium premium)
		{
			InitializeComponent();
			this.PhilHealthPremium = premium;
		}
		
		public event PhilHealthPremiumEventHandler SavePhilHealthPremium;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePhilHealthPremium != null) {
				SavePhilHealthPremium(PhilHealthPremium, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
