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
	/// Description of VendorReturnedItemForm.
	/// </summary>
	public partial class VendorReturnedItemForm : BaseForm
	{
		VendorReturnedItem item;
		
		public VendorReturnedItem Item {
			get {
				return item;
			}
			set { 
				item = value;
				if (item.Item != null) {
					textBoxCode.Text = item.Item.Name;
					textBoxName.Text = item.Item.SalesDescription;
					textBoxUnit.Text = item.Item.Unit != null ? item.Item.Unit.Name : "";
					textBoxPrice.Text = item.Item.SalesPrice.ToString("0.00");
				}
				textBoxQuantity.Text = item.Quantity.ToString();
			}
		}
		
		public VendorReturnedItemForm() : this(new VendorReturnedItem())
		{
		}
		
		public VendorReturnedItemForm(VendorReturnedItem item)
		{
			InitializeComponent();
			this.Item = item;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
			item.UnitPrice = ConvertUtility.ToDouble(textBoxPrice.Text);
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
			string suggestedCode = ItemSuggestionUtility.Suggest(textBoxCode.Text);
//			IList<Item> items = Core.Models.Item.FindByName(suggestedCode);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxQuantity.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxQuantity.Select();
//					} else {
//						textBoxCode.Select();
//					}
//				}
//			} // TODO: Use delegate in finding item for vendor returned item.
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void TextBoxCodeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem.PerformClick();
			}
		}
		
		void TextBoxQuantityKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonOk.PerformClick();
			}
		}
	}
}
