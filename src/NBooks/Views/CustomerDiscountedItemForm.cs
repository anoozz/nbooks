//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class CustomerDiscountedItemForm : BaseForm
	{
		CustomerDiscountedItem item;
		
		public CustomerDiscountedItem CustomerDiscountedItem {
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
		
		public CustomerDiscountedItemForm() : this(new CustomerDiscountedItem())
		{
		}
		
		public CustomerDiscountedItemForm(CustomerDiscountedItem item)
		{
			InitializeComponent();
			this.CustomerDiscountedItem = item;
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
//			IList<Item> items = Item.FindByName(textBoxCode.Text);
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
//			} // TODO:
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
