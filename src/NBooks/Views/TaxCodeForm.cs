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
using System.Windows.Forms;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class TaxCodeForm : BaseForm
	{
		TaxCode code;
		
		public TaxCode TaxCode {
			get { 
				code.Code = textBoxCode.Text;
				code.Description = textBoxDescription.Text;
				code.PersonalExemption = ConvertUtility.ToDouble(textBoxPersonalExemption.Text);
				code.Inactive = checkBoxInactive.Checked;
				return code;
			}
			set {
				code = value;
				textBoxCode.Text = code.Code;
				textBoxDescription.Text = code.Description;
				textBoxPersonalExemption.Text = code.PersonalExemption.ToString("0.00");
				checkBoxInactive.Checked = code.Inactive;
				code.RangesChanged += delegate { TaxSalaryRangesChanged(); };
				TaxSalaryRangesChanged();
			}
		}
		
		public TaxCodeForm() : this(new TaxCode())
		{
		}
		
		public TaxCodeForm(TaxCode code)
		{
			InitializeComponent();
			this.TaxCode = code;
		}
		
		void TaxSalaryRangesChanged()
		{
			listView1.Items.Clear();
			foreach (var r in code.Ranges) {
				ListViewItem li = listView1.Items.Add("");
				li.SubItems.Add(r.MonthlyFrom.ToString("###,##0.00"));
				li.SubItems.Add(r.MonthlyTo.ToString("###,##0.00"));
				li.SubItems.Add(r.MonthlyTax.ToString("###,##0.00"));
				li.SubItems.Add(r.SemiMonthlyFrom.ToString("###,##0.00"));
				li.SubItems.Add(r.SemiMonthlyTo.ToString("###,##0.00"));
				li.SubItems.Add(r.SemiMonthlyTax.ToString("###,##0.00"));
				li.SubItems.Add(r.PercentageOver.ToString("###,##0.00"));
			}
		}
		
		public event TaxCodeEventHandler SaveTaxCode;
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveTaxCode != null) {
				SaveTaxCode(TaxCode, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
