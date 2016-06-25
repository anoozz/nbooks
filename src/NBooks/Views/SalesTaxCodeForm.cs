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

namespace NBooks.Views
{
	public partial class SalesTaxCodeForm : BaseForm
	{
		SalesTaxCode code;
		
		public SalesTaxCode SalesTaxCode {
			get {
				code.Code = textBoxCode.Text;
				code.Description = textBoxDescription.Text;
				code.Taxable = radioButtonTaxable.Checked;
				code.Inactive = checkBoxInactive.Checked;
				return code;
			}
			set {
				code = value;
				textBoxCode.Text = code.Code;
				textBoxDescription.Text = code.Description;
				radioButtonTaxable.Checked = code.Taxable;
				checkBoxInactive.Checked = code.Inactive;
			}
		}
		
		public SalesTaxCodeForm() : this(new SalesTaxCode())
		{
		}
		
		public SalesTaxCodeForm(SalesTaxCode code)
		{
			InitializeComponent();
			this.SalesTaxCode = code;
		}
		
		public event SalesTaxCodeEventHandler SaveSalesTaxCode;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveSalesTaxCode != null) {
				SaveSalesTaxCode(SalesTaxCode, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
