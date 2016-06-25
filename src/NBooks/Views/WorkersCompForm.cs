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
	public partial class WorkersCompForm : BaseForm
	{
		WorkersComp comp;
		
		public WorkersComp WorkersComp {
			get { 
				comp.Code = textBoxCode.Text;
				comp.Description = textBoxDescription.Text;
				comp.Rate = ConvertUtility.ToDouble(textBoxRate.Text);
				comp.EffectivityDate = dateTimePickerEffectivityDate.Value;
				comp.Inactive = checkBoxInactive.Checked;
				return comp;
			}
			set {
				comp = value;
				textBoxCode.Text = comp.Code;
				textBoxDescription.Text = comp.Description;
				textBoxRate.Text = comp.Rate.ToString("0.00");
				dateTimePickerEffectivityDate.Value = DateUtility.GetValid(comp.EffectivityDate);
				checkBoxInactive.Checked = comp.Inactive;
			}
		}
		
		public WorkersCompForm() : this(new WorkersComp())
		{
		}
		
		public WorkersCompForm(WorkersComp comp)
		{
			InitializeComponent();
			this.WorkersComp = comp;
		}
		
		public event EventHandler<WorkersCompEventArgs> SaveWorkersComp;
		
		protected virtual void OnSaveWorkersComp(WorkersCompEventArgs e)
		{
			if (SaveWorkersComp != null) {
				SaveWorkersComp(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnSaveWorkersComp(new WorkersCompEventArgs(WorkersComp));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
