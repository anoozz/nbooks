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
	public partial class BillItemForm : BaseForm
	{
		BillItem item;
		
		public BillItem BillItem {
			get {
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				item.Price = ConvertUtility.ToDouble(textBoxRate.Text);
				return item;
			}
			set {
				item = value;
				ItemChanged(item.Item != null ? item.Item : new Item(), null);
				textBoxQuantity.Text = item.Quantity.ToString();
				item.ItemChanged += new ItemEventHandler(ItemChanged);
				textBoxItem.Select();
			}
		}

		public BillItemForm()
		{
			InitializeComponent();
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
			textBoxRate.Text =  sender.Cost.ToString("0.00");
			textBoxQuantity.Focus();
		}
		
		public event StringEventHandler FindItem;
	}
}
