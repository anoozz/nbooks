// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class SSPremiumForm : BaseForm
	{
		SSPremium premium;
		
		public SSPremium SSPremium {
			get { 
				premium.Code = textBoxCode.Text;
				premium.RangeFrom = ConvertUtility.ToDouble(textBoxRangeFrom.Text);
				premium.RangeTo = ConvertUtility.ToDouble(textBoxRangeTo.Text);
				premium.ER = ConvertUtility.ToDouble(textBoxER.Text);
				premium.EC = ConvertUtility.ToDouble(textBoxEC.Text);
				premium.EE = ConvertUtility.ToDouble(textBoxEE.Text);
				premium.Contribution = ConvertUtility.ToDouble(textBoxContribution.Text);
				premium.Inactive = checkBoxInactive.Checked;
				return premium; 
			}
			set { 
				premium = value;
				textBoxCode.Text = premium.Code;
				textBoxRangeFrom.Text = premium.RangeFrom.ToString("0.00");
				textBoxRangeTo.Text = premium.RangeFrom.ToString("0.00");
				textBoxER.Text = premium.ER.ToString("0.00");
				textBoxEC.Text = premium.EC.ToString("0.00");
				textBoxEE.Text = premium.EE.ToString("0.00");
				textBoxContribution.Text = premium.Contribution.ToString("0.00");
				checkBoxInactive.Checked = premium.Inactive;
			}
		}
		
		public SSPremiumForm() : this(new SSPremium())
		{
		}
		
		public SSPremiumForm(SSPremium premium)
		{
			InitializeComponent();
			this.SSPremium = premium;
		}
		
		public event SSPremiumEventHandler SaveSSPremium;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveSSPremium != null) {
				SaveSSPremium(SSPremium, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
