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

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class VendorListForm : BaseForm
	{
		IList<Vendor> vendors;
		
		public Vendor SelectedVendor {
			get {
				if (listViewVendors.SelectedItems.Count > 0) {
					return vendors[listViewVendors.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Vendor> SelectedVendors {
			get {
				IList<Vendor> selectedVendors = new List<Vendor>();
				foreach (ListViewItem li in listViewVendors.SelectedItems) {
					selectedVendors.Add(vendors[li.Index]);
				}
				return selectedVendors;
			}
		}
		
		public IList<Vendor> Vendors {
			get { return vendors; }
			set { 
				vendors = value;
				listViewVendors.Items.Clear();
				foreach (var v in vendors) {
					ListViewItem li = listViewVendors.Items.Add(v.Name);
					li.SubItems.Add(v.Balance.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
				toolStripDropDownButtonVendor.Text = string.Format("{0} Vendors", vendors.Count);
			}
		}
		
		public VendorListForm()
		{
			InitializeComponent();
			listViewVendors.Resize += delegate { columnHeader1.Width = listViewVendors.Width - 22 - (columnHeader2.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnVendorAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedVendor != null) {
					OnVendorEdit(new VendorEventArgs(SelectedVendor));
				}
			};
			listViewVendors.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var vendor in SelectedVendors) {
					OnVendorDelete(new VendorEventArgs(vendor));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var vendor in SelectedVendors) {
					OnVendorMakeInactive(new VendorEventArgs(vendor));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnVendorsList(e);
		}
		
		public event EventHandler VendorsList;
		
		protected virtual void OnVendorsList(EventArgs e)
		{
			if (VendorsList != null) {
				VendorsList(this, e);
			}
		}
		public event EventHandler<VendorEventArgs> VendorDelete;
		
		protected virtual void OnVendorDelete(VendorEventArgs e)
		{
			if (VendorDelete != null) {
				VendorDelete(this, e);
			}
		}
		public event EventHandler<VendorEventArgs> VendorMakeInactive;
		
		protected virtual void OnVendorMakeInactive(VendorEventArgs e)
		{
			if (VendorMakeInactive != null) {
				VendorMakeInactive(this, e);
			}
		}
		public event EventHandler<VendorEventArgs> VendorEdit;
		
		protected virtual void OnVendorEdit(VendorEventArgs e)
		{
			if (VendorEdit != null) {
				VendorEdit(this, e);
			}
		}
		public event EventHandler VendorAdd;
		
		protected virtual void OnVendorAdd(EventArgs e)
		{
			if (VendorAdd != null) {
				VendorAdd(this, e);
			}
		}
	}
}
