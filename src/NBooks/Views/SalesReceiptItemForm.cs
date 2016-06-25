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
	public partial class SalesReceiptItemForm : BaseForm
	{
		SalesReceiptItem item;
		
		public SalesReceiptItem ReceiptItem {
			get { 
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				item.Rate = ConvertUtility.ToDouble(textBoxRate.Text);
				return item;
			}
			set { 
				item = value;
				textBoxQuantity.Text = item.Quantity.ToString();
				item.ItemChanged += new EventHandler<ItemEventArgs>(ItemChanged);
				ItemChanged(this, new ItemEventArgs(item.Item != null ? item.Item : new Item()));
				textBoxName.Select();
			}
		}
		
		public SalesReceiptItemForm() : this(new SalesReceiptItem())
		{
		}
		
		public SalesReceiptItemForm(SalesReceiptItem item)
		{
			InitializeComponent();
			this.ReceiptItem = item;
			buttonFindItem.Click += delegate { 
				OnItemFind(new ItemEventArgs(new Item(textBoxName.Text)));
			};
			textBoxName.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) {
					buttonFindItem.PerformClick();
				}
			};
			textBoxQuantity.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) {
					buttonOk.PerformClick();
				}
			};
		}

		void ItemChanged(object sender, ItemEventArgs e)
		{
			textBoxName.Text = e.Item.Name;
			textBoxDescription.Text = e.Item.SalesDescription;
			textBoxUnit.Text = e.Item.Unit != null ? e.Item.Unit.Name : "";
			textBoxRate.Text =  e.Item.SalesPrice.ToString("0.00");
			textBoxQuantity.Focus();
		}
		
		public event EventHandler<ItemEventArgs> ItemFind;
		
		protected virtual void OnItemFind(ItemEventArgs e)
		{
			if (ItemFind != null) {
				ItemFind(this, e);
			}
		}
	}
}
