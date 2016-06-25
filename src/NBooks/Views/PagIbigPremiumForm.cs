//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class PagIbigPremiumForm : BaseForm
	{
		PagIbigPremium premium;
		
		public PagIbigPremium PagIbigPremium {
			get {
				premium.Code = textBoxCode.Text;
				premium.Inactive = checkBoxInactive.Checked;
				return premium;
			}
			set {
				premium = value;
				textBoxCode.Text = premium.Code;
				checkBoxInactive.Checked = premium.Inactive;
			}
		}
		
		public PagIbigPremiumForm() : this(new PagIbigPremium())
		{
		}
		
		public PagIbigPremiumForm(PagIbigPremium premium)
		{
			InitializeComponent();
			this.PagIbigPremium = premium;
		}
		
		public event PagIbigPremiumEventHandler SavePagIbigPremium;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SavePagIbigPremium != null) {
				SavePagIbigPremium(PagIbigPremium, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
