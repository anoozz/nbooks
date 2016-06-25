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
	public partial class TruckReturnItemForm : BaseForm
	{
		Customer customer;
		TruckReturnItem item;
		
		public TruckReturnItem ReturnItem {
			get { 
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				item.UnitPrice = ConvertUtility.ToDouble(textBoxPrice.Text);
				item.Discount = ConvertUtility.ToDouble(textBoxDiscount.Text) * item.Quantity;
				return item;
			}
			set { 
				item = value;
				textBoxDiscount.Text = item.Discount.ToString("0.00");
				textBoxQuantity.Text = item.Quantity.ToString();
				item.ItemChanged += new ItemEventHandler(ItemChanged);
				ItemChanged(item.Item != null ? item.Item : new Item(), null);
				textBoxItem.Select();
			}
		}
		
		public Customer Customer {
			get { return customer; }
			set { customer = value; }
		}
		
		public TruckReturnItemForm() : this(new TruckReturnItem())
		{
		}
		
		public TruckReturnItemForm(TruckReturnItem item)
		{
			InitializeComponent();
			this.ReturnItem = item;
			
			buttonFindItem.Click += delegate { 
				if (FindItem != null) FindItem(textBoxItem.Text, null);
			};
			textBoxItem.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) buttonFindItem.PerformClick();
			};
			textBoxQuantity.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) buttonOk.PerformClick();
			};
		}
		
		void ItemChanged(Item sender, EventArgs e)
		{
			textBoxItem.Text = sender.Name;
			textBoxDescription.Text = sender.SalesDescription;
			textBoxUnit.Text = sender.Unit != null ? sender.Unit.Name : "";
			textBoxPrice.Text = sender.SalesPrice.ToString("0.00");
			textBoxQuantity.Select();
		}
		
		public event StringEventHandler FindItem;
		
		public void FindCode(string code, double quantity)
		{
			textBoxItem.Text = code;
//			ButtonFindItemClick(this, null);
			textBoxQuantity.Text = quantity.ToString();
		}
		
		double GetDiscount(Item item)
		{
			double discount = 0;
			foreach (CustomerDiscountedItem i in customer.DiscountedItems) {
				if (i.Item.Id == item.Id) {
					return i.Discount;
				}
			}
			return discount;
		}
		
//		void ButtonFindItemClick(object sender, EventArgs e)
//		{
//			IList<Item> items = Core.Models.Item.FindByName(textBoxCode.Text);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxDiscount.Text = GetDiscount(items[0]).ToString("0.00");
//				textBoxQuantity.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxDiscount.Text = GetDiscount(f.SelectedItem).ToString("0.00");
//						textBoxQuantity.Select();
//					} else {
//						textBoxCode.Select();
//					}
//				}
//			}
//		}
	}
}
