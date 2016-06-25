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
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class TruckReturnListForm : BaseForm
	{
		IList<TruckReturn> returns;
		
		public IList<TruckReturn> TruckReturns {
			get { return returns; }
			set {
				returns = value;
				listView1.Items.Clear();
				foreach (var t in returns) {
					ListViewItem li = listView1.Items.Add(t.Date.ToShortDateString());
					li.SubItems.Add(t.TruckNo);
					li.SubItems.Add(t.Route != null ? t.Route.Code : "");
					li.SubItems.Add(t.SalesRep != null ? t.SalesRep.Name : "");
					li.SubItems.Add(t.Customer != null ? t.Customer.Name : "");
					li.SubItems.Add(t.TotalAmount.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public TruckReturnListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			enterTruckReturnsToolStripMenuItem.Click += delegate { WorkbenchSingleton.AddChild(new TruckReturnForm()); };
			editTransactionToolStripMenuItem.DoubleClick += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditTruckReturn(returns[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editTransactionToolStripMenuItem.PerformClick(); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListTruckReturns != null) ListTruckReturns(this, null);
		}
		
		public event EventHandler ListTruckReturns;
		public event TruckReturnEventHandler DeleteTruckReturn;
		public event TruckReturnEventHandler CloseTruckReturn;
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				using (AdminPasswordForm f = new AdminPasswordForm()) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						foreach (ListViewItem li in listView1.SelectedItems) {
							TruckReturn t = returns[li.Index];
							CloseTruckReturn(t, null);
						}
						OnActivated(null);
					}
				}
			}
		}
		
		void UndoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				foreach (ListViewItem li in listView1.SelectedItems) {
					TruckReturn t = returns[li.Index];
					DeleteTruckReturn(t, null);
				}
				OnActivated(null);
			}
		}
	}
}
