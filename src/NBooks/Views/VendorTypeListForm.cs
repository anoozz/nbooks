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
	public partial class VendorTypeListForm : BaseForm
	{
		IList<VendorType> types;
		
		public IList<VendorType> VendorTypes {
			get { return types; }
			set {
				types = value;
				listView1.Items.Clear();
				foreach (var d in types) {
					ListViewItem li = listView1.Items.Add(d.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public VendorTypeListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddVendorType().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditVendorType(types[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
//						DeleteVendorType(types[li.Index], null);
						OnDeleteVendorType(new VendorTypeEventArgs(types[li.Index]));
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
//						MakeInactiveVendorType(types[li.Index], null);
						OnMakeInactiveVendorType(new VendorTypeEventArgs(types[li.Index]));
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVendorTypes != null) ListVendorTypes(this, e);
		}
		
		public event EventHandler ListVendorTypes;
		
		public event EventHandler<VendorTypeEventArgs> DeleteVendorType;
		
		protected virtual void OnDeleteVendorType(VendorTypeEventArgs e)
		{
			if (DeleteVendorType != null) {
				DeleteVendorType(this, e);
			}
		}
		
		public event EventHandler<VendorTypeEventArgs> MakeInactiveVendorType;
		
		protected virtual void OnMakeInactiveVendorType(VendorTypeEventArgs e)
		{
			if (MakeInactiveVendorType != null) {
				MakeInactiveVendorType(this, e);
			}
		}
	}
}
