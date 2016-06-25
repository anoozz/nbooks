// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class SalesTaxCodeListForm : BaseForm
	{
		IList<SalesTaxCode> codes;
		
		public IList<SalesTaxCode> SalesTaxCodes {
			get { return codes; }
			set {
				codes = value;
				listView1.Items.Clear();
				foreach (SalesTaxCode c in codes) {
					ListViewItem li = listView1.Items.Add(c.Code);
					li.SubItems.Add(c.Description);
					li.SubItems.Add(c.Taxable ? "Yes" : "No");
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public SalesTaxCodeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeaderDescription.Width = listView1.Width - 22 - (columnHeaderCode.Width + columnHeaderTaxable.Width); };
			newToolStripMenuItem.Click += delegate { new AddSalesTaxCode().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditSalesTaxCode(SalesTaxCodes[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteSalesTaxCode(SalesTaxCodes[li.Index], null);
					}
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate {
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveSalesTaxCode(SalesTaxCodes[li.Index], null);
					}
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnLoadSalesTaxCodes(e);
		}
		
		protected virtual void OnLoadSalesTaxCodes(EventArgs e)
		{
			if (ListSalesTaxCodes != null) {
				ListSalesTaxCodes(this, e);
			}
		}
		
		public event EventHandler ListSalesTaxCodes;
		public event SalesTaxCodeEventHandler DeleteSalesTaxCode;
		public event SalesTaxCodeEventHandler MakeInactiveSalesTaxCode;
	}
}
