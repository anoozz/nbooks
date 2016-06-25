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
	public partial class ItemReceiptItemForm : BaseForm
	{
		Vendor vendor;
		ItemReceiptItem item;
		
		public ItemReceiptItem ReceiptItem {
			get { 
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				item.UnitPrice = ConvertUtility.ToDouble(textBoxPrice.Text);
	            item.Discount = ConvertUtility.ToDouble(textBoxDiscount.Text) * item.Quantity;
				return item; 
			}
			set { 
				item = value;
				textBoxQuantity.Text = item.Quantity.ToString();
				item.ItemChanged += new ItemEventHandler(ItemChanged);
				ItemChanged(item.Item != null ? item.Item : new Item(), null);
				textBoxItem.Select();
			}
		}
		
		public Vendor Vendor {
			get { return vendor; }
			set { vendor = value; }
		}
		
		public ItemReceiptItemForm() : this(new ItemReceiptItem())
		{
		}
		
		public ItemReceiptItemForm(ItemReceiptItem item)
		{
			InitializeComponent();
			this.ReceiptItem = item;
			
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
			textBoxDescription.Text = sender.PurchaseDescription;
			textBoxUnit.Text = sender.Unit != null ? sender.Unit.Name : "";
			textBoxPrice.Text = sender.SalesPrice.ToString("0.00");
			textBoxQuantity.Select();
		}
		
		public event StringEventHandler FindItem;
		
		public void FindCode(string code, double quantity)
		{
			textBoxItem.Text = code;
			ButtonFindItemClick(this, null);
			textBoxQuantity.Text = quantity.ToString();
		}
		
//		void ButtonOkClick(object sender, EventArgs e)
//		{
//            if (item.Item.IsEmpty()) {
//           		item.UCS = item.Item.UCS * item.Quantity;
//            }
//			DialogResult = DialogResult.OK;
//			Close();
//		}
		
		double GetItemDiscount(Item item)
		{
			double discount = 0;
			foreach (VendorDiscountedItem i in vendor.DiscountedItems) {
				if (i.Item.Id == item.Id) {
					return i.Discount;
				}
			}
			return discount;
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
//			IList<Item> items = Core.Models.Item.FindByName(textBoxCode.Text);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxDiscount.Text = GetItemDiscount(items[0]).ToString("0.00");
//				textBoxQuantity.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxDiscount.Text = GetItemDiscount(f.SelectedItem).ToString("0.00");
//						textBoxQuantity.Select();
//					} else {
//						textBoxCode.Select();
//					}
//				}
//			}
		}
	}
}
