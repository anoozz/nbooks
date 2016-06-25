//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of ListOfValueForm.
	/// </summary>
	public partial class ListOfValueForm<T> : BaseForm
	{
		IList<T> items;
		public T selectedItem;
		
		public T SelectedItem {
			get { return selectedItem; }
			set { selectedItem = value; }
		}
		
		public IList<T> SelectedItems {
			get {
				IList<T> selectedItems = new List<T>();
				foreach (ListViewItem li in listView1.SelectedItems) {
					selectedItems.Add(items[li.Index]);
				}
				return selectedItems;
			}
		}
		
		public IList<T> Items {
			get { return items; }
			set { 
				items = value;
				OnItemsChanged(null);
			}
		}
		
		public ListOfValueForm()
		{
			InitializeComponent();
			listView1.Click += new EventHandler(ListViewClick);
			listView1.DoubleClick += delegate { 
				ListViewClick(this, null);
				buttonOk.PerformClick();
			};
			buttonOk.Click += delegate { TextBoxItemKeyDown(this, new KeyEventArgs(Keys.Enter)); };
		}
		
		public event EventHandler ItemsChanged;
		public event StringEventHandler FindItem;
		
		protected virtual void OnItemsChanged(EventArgs e)
		{
			if (ItemsChanged != null) {
				ItemsChanged(this, e);
			}
		}
		
		void ListViewClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				selectedItem = items[listView1.SelectedItems[0].Index];
			}
		}
		
		void TextBoxItemKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				if (FindItem != null) FindItem(textBoxItem.Text, e);
			}
		}
	}
}
