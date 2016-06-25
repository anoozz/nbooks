//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

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
	/// Description of ConvertItemForm.
	/// </summary>
	public partial class ConvertItemForm : BaseForm
	{
		Item itemFrom, itemTo;
		
		public ConvertItemForm()
		{
			InitializeComponent();
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
//			IList<Item> items = Item.FindByName(textBoxCode.Text);
//			if (items.Count == 1) {
//				UpdateFrom(items[0]);
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						UpdateFrom(f.SelectedItem);
//					}
//				}
//			} // TODO:
		}
		
		void UpdateFrom(Item i)
		{
			itemFrom = i;
			textBoxCode.Text = i.Name;
			textBoxName.Text = i.SalesDescription;
			textBoxUnit.Text = i.Unit != null ? i.Unit.Name : "";
			textBoxPrice.Text = i.SalesPrice.ToString("0.00");
			textBoxQuantity.Focus();
		}
		
		void UpdateTo(Item i)
		{
			itemTo = i;
			textBoxCode2.Text = i.Name;
			textBoxName2.Text = i.SalesDescription;
			textBoxUnit2.Text = i.Unit != null ? i.Unit.Name : "";
			textBoxPrice2.Text = i.SalesPrice.ToString("0.00");
			textBox1.Text = (i.ToLargePacking * ConvertUtility.ToDouble(textBoxQuantity.Text)).ToString("0.00");
			textBoxQuantity.Focus();
		}
		
		void ButtonFindItem2Click(object sender, EventArgs e)
		{
//			IList<Item> items = Item.FindByName(textBoxCode2.Text);
//			if (items.Count == 1) {
//				UpdateTo(items[0]);
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						UpdateTo(f.SelectedItem);
//					}
//				}
//			} // TODO:
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
//			ConvertedItem item = new ConvertedItem();
//			item.ItemFrom = itemFrom;
//			item.ItemTo = itemTo;
//			item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
//			item.SaveOrUpdate();
//			
//			itemFrom.Convert(itemTo, ConvertUtility.ToDouble(textBoxQuantity.Text));
//			item.Date = dateTimePickerDate.Value;
//			itemFrom.SaveOrUpdate();
//			itemTo.SaveOrUpdate();
//			Close(); // TODO:
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void TextBoxQuantityKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem2.PerformClick();
			}
		}
		
		void TextBoxQuantityLeave(object sender, EventArgs e)
		{
			if (itemTo != null) {
				textBox1.Text = (itemTo.ToLargePacking * ConvertUtility.ToDouble(textBoxQuantity.Text)).ToString("0.00");
			}
		}
		
		void TextBoxCodeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem.PerformClick();
			}
		}
		
		void TextBoxCode2KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem2.PerformClick();
			}
		}
	}
}
