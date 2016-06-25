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
	/// Description of PhysicalCountItemForm.
	/// </summary>
	public partial class PhysicalCountItemForm : BaseForm
	{
		PhysicalCountItem item;
		
		public PhysicalCountItem Item {
			get { 
				return item; 
			}
			set { 
				item = value;
				if (item.Item != null) {
					textBoxCode.Text = item.Item.Name;
					textBoxName.Text = item.Item.SalesDescription;
					textBoxQuantity.Text = item.Item.OnHand.ToString("0.00");
				}
				textBoxAdjustedQuantity.Text = item.AdjustedQty.ToString();
				item.ItemChanged += delegate(Item sender, EventArgs e) { 
					textBoxCode.Text = sender.Name;
					textBoxName.Text = sender.SalesDescription;
					textBoxQuantity.Text = sender.OnHand.ToString("0.00");
				};
			}
		}
		
		public PhysicalCountItemForm() : this(new PhysicalCountItem())
		{
		}
		
		public PhysicalCountItemForm(PhysicalCountItem item)
		{
			InitializeComponent();
			this.Item = item;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			item.OriginalQty = ConvertUtility.ToDouble(textBoxQuantity.Text);
			item.AdjustedQty = ConvertUtility.ToDouble(textBoxAdjustedQuantity.Text);
			DialogResult = DialogResult.OK;
			Close();
		}
		
		public void FindCode(string code, double quantity)
		{
			textBoxCode.Text = code;
			ButtonFindItemClick(this, null);
			textBoxAdjustedQuantity.Text = quantity.ToString();
			textBoxAdjustedQuantity.Select();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void ButtonFindItemClick(object sender, EventArgs e)
		{
//			IList<Item> items = Core.Models.Item.FindByName(textBoxCode.Text);
//			if (items.Count == 1) {
//				item.Item = items[0];
//				textBoxAdjustedQuantity.Select();
//			} else {
//				using (FindItemForm f = new FindItemForm(items)) {
//					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
//						item.Item = f.SelectedItem;
//						textBoxAdjustedQuantity.Select();
//					} else {
//						textBoxCode.Select();
//					}
//				}
//			} // TODO: Use delegates on finding item for physical count
		}
		
		void TextBoxCodeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonFindItem.PerformClick();
			}
		}
		
		void TextBoxAdjustedQuantityKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				buttonOk.PerformClick();
			}
		}
	}
}
