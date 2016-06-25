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
	public partial class SalesRepForm : BaseForm
	{
		SalesRep rep;
		
		public SalesRep SalesRep {
			get { 
				rep.Name = textBoxName.Text;
			    rep.Address = richTextBoxAddress.Text;
			    rep.Phone = textBoxPhone.Text;
				return rep;
			}
			set { 
				rep = value; 
				textBoxName.Text = rep.Name;
				richTextBoxAddress.Text = rep.Address;
				textBoxPhone.Text = rep.Phone;
			}
		}
		
		public SalesRepForm() : this(new SalesRep())
		{
		}
		
		public SalesRepForm(SalesRep rep)
		{
			InitializeComponent();
			this.SalesRep = rep;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveSalesRep != null) {
				SaveSalesRep(SalesRep, e);
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		public event SalesRepEventHandler SaveSalesRep;
		
		void ButtonNotesClick(object sender, EventArgs e)
		{
		}
	}
}
