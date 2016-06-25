//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class ItemForm2 : BaseForm
	{
		Item item;
		
		public Item Item {
			get { return item; }
			set {
				item = value;
			}
		}
		
		public ItemForm2() : this(new Item())
		{
		}
		
		public ItemForm2(Item item)
		{
			InitializeComponent();
			this.Item = item;
		}
	}
}
