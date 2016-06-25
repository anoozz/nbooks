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
	public partial class TruckLoadItemForm : BaseForm
	{
		Customer customer;
		TruckLoadItem item;
		
		public TruckLoadItem LoadItem {
			get {
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				item.Price = ConvertUtility.ToDouble(textBoxPrice.Text);
				item.Discount = item.Quantity * ConvertUtility.ToDouble(textBoxDiscount.Text);
				return item; 
			}
			set {
				item = value;
				ItemChanged(item.Item != null ? item.Item : new Item(), null);
				textBoxDiscount.Text = item.Discount.ToString("0.00");
				textBoxQuantity.Text = item.Quantity.ToString();
				item.ItemChanged += new ItemEventHandler(ItemChanged);
				textBoxItem.Enabled = buttonFindItem.Enabled = item.Item == null;
				if (item.Item != null) {
					textBoxQuantity.Select();
				} else {
					textBoxItem.Select();
				}
			}
		}
		
		public Customer Customer {
			set { customer = value; }
		}
		
		public TruckLoadItemForm() : this(new TruckLoadItem())
		{
		}
		
		public TruckLoadItemForm(TruckLoadItem item)
		{
			InitializeComponent();
			this.LoadItem = item;
			
			textBoxItem.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) buttonFindItem.PerformClick();
			};
			textBoxQuantity.KeyDown += delegate(object sender, KeyEventArgs e) { 
				if (e.KeyCode == Keys.Enter) buttonOk.PerformClick();
			};
			buttonFindItem.Click += delegate { 
				if (FindItem != null) FindItem(textBoxItem.Text, null);
			};
		}
		
		void ItemChanged(Item sender, EventArgs e)
		{
			textBoxItem.Text = sender.Name;
			textBoxDescription.Text = sender.SalesDescription;
			textBoxUnit.Text = sender.Unit != null ? sender.Unit.Name : "";
			textBoxPrice.Text = sender.SalesPrice.ToString("0.00");
			textBoxQuantity.Focus();
		}
		
		public void FindCode(string code, double quantity)
		{
			textBoxItem.Text = code;
//			ButtonFindItemClick(this, null);
			textBoxQuantity.Text = quantity.ToString();
		}
		
		double GetCustomerDiscount(Item item)
		{
			double discount = 0;
			if (customer != null) {
				foreach (CustomerDiscountedItem i in customer.DiscountedItems) {
					if (item.Id == i.Item.Id) {
						return i.Discount;
					}
				}
			}
			return discount;
		}
		
		public event StringEventHandler FindItem;
		
//		void ButtonFindItemClick(object sender, EventArgs e)
//		{
//			IList<Item> items = Core.Models.Item.FindByName(textBoxItem.Text);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxDiscount.Text = GetCustomerDiscount(items[0]).ToString("0.00");
//				textBoxQuantity.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxDiscount.Text = GetCustomerDiscount(f.SelectedItem).ToString("0.00");
//						textBoxQuantity.Select();
//					} else {
//						textBoxItem.Select();
//					}
//				}
//			}
//		}
	}
}
