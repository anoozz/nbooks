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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of VendorDiscountedItemForm.
	/// </summary>
	public partial class VendorDiscountedItemForm : BaseForm
	{
		VendorDiscountedItem item;
		
		public VendorDiscountedItem Item {
			get { return item; }
			set { 
				item = value; 
				if (item.Item != null) {
					textBoxCode.Text = item.Item.Name;
					textBoxName.Text = item.Item.SalesDescription;
					textBoxUnit.Text = item.Item.Unit != null ? item.Item.Unit.Name : "";
					textBoxPrice.Text = item.Item.SalesPrice.ToString("0.00");
				}
				textBoxDiscount.Text = item.Discount.ToString();
				item.ItemChanged += delegate(Item sender, EventArgs e) { 
					textBoxCode.Text = sender.Name;
					textBoxName.Text = sender.SalesDescription;
					textBoxUnit.Text = sender.Unit != null ? sender.Unit.Name : "";
					textBoxPrice.Text = sender.SalesPrice.ToString("0.00");
				};
			}
		}
		
		public VendorDiscountedItemForm() : this(new VendorDiscountedItem())
		{
		}
		
		public VendorDiscountedItemForm(VendorDiscountedItem item)
		{
			InitializeComponent();
			this.Item = item;
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
//			IList<Item> items = Core.Models.Item.FindByName(textBoxCode.Text);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxDiscount.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxDiscount.Select();
//					} else {
//						textBoxCode.Select();
//					}
//				}
//			} // TODO: Use delegate in finding item for vendor discounted item.
		}
		
		void TextBoxCodeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem.PerformClick();
			}
		}
		
		void TextBoxDiscountKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonOk.PerformClick();
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			item.Discount = ConvertUtility.ToDouble(textBoxDiscount.Text);
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
