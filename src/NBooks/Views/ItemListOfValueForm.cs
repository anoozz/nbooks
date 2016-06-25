//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NBooks.Core.Models;

namespace NBooks.Views.ListOfValues
{
	public partial class ItemListOfValueForm : ListOfValueForm<Item>
	{
		public ItemListOfValueForm()
		{
			InitializeComponent();
		}
		
		protected override void OnItemsChanged(EventArgs e)
		{
			base.OnItemsChanged(e);
			listView1.Items.Clear();
			foreach (var item in Items) {
				ListViewItem li = listView1.Items.Add(item.Name);
				li.SubItems.Add(item.SalesDescription);
				li.SubItems.Add(item.Unit != null ? item.Unit.Name : "");
				li.SubItems.Add(item.SalesPrice.ToString("0.00"));
			}
		}
	}
}
