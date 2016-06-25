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
	public partial class InvoiceItemForm : BaseForm
	{
		InvoiceItem item;
		
		public InvoiceItem InvoiceItem {
			get { 
				item.UnitPrice = ConvertUtility.ToDouble(textBoxPrice.Text);
				item.Quantity = ConvertUtility.ToDouble(textBoxQuantity.Text);
				return item; 
			}
			set {
				item = value;
				textBoxPrice.Text = item.UnitPrice.ToString("0.00");
				textBoxQuantity.Text = item.Quantity.ToString("0.00");
				item.ItemChanged += new EventHandler<ItemEventArgs>(ItemChanged);
				ItemChanged(this, new ItemEventArgs(item.Item != null ? item.Item : new Item()));
				textBoxName.Select();
			}
		}
		
		public InvoiceItemForm() : this(new InvoiceItem())
		{
		}
		
		public InvoiceItemForm(InvoiceItem item)
		{
			InitializeComponent();
			this.InvoiceItem = item;
			
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
			textBoxPrice.Text = e.Item.SalesPrice.ToString("0.00");
			textBoxQuantity.Select();
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
