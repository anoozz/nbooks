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
	public partial class TermsForm : BaseForm
	{
		Terms terms;
		
		public Terms Terms {
			get { 
				terms.Name = textBoxName.Text;
				terms.Inactive = checkBoxInactive.Checked;
				return terms; 
			}
			set { 
				terms = value; 
				textBoxName.Text = terms.Name;
				checkBoxInactive.Checked = terms.Inactive;
			}
		}
		
		public TermsForm() : this(new Terms())
		{
		}
		
		public TermsForm(Terms terms)
		{
			InitializeComponent();
			this.Terms = terms;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnTermsSave(new TermsEventArgs(Terms));
		}
		
		public event EventHandler<TermsEventArgs> TermsSave;
		
		protected virtual void OnTermsSave(TermsEventArgs e)
		{
			if (TermsSave != null) {
				TermsSave(this, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
