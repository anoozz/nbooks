//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class InventoryPartItemPane : BaseUserControl
	{
		Item item;
		
		public Item Item {
			get { 
				return item;
			}
			set { 
				item = value;
			}
		}
		
		public InventoryPartItemPane() : this(new Item())
		{
		}
		
		public InventoryPartItemPane(Item item)
		{
			InitializeComponent();
			this.Item = item;
		}
	}
}
