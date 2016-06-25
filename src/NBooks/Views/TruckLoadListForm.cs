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
	public partial class TruckLoadListForm : BaseForm
	{
		IList<TruckLoad> loads;
		
		public IList<TruckLoad> TruckLoads {
			get { return loads; }
			set { 
				loads = value; 
				listView1.Items.Clear();
				foreach (TruckLoad t in loads) {
					ListViewItem li = listView1.Items.Add(t.Id.ToString("00000"));
					li.SubItems.Add(t.Date.ToShortDateString());
					li.SubItems.Add(t.TruckNo);
					li.SubItems.Add(t.Route != null ? t.Route.Code : "");
					li.SubItems.Add(t.SalesRep != null ? t.SalesRep.Name : "");
					li.SubItems.Add(t.Customer != null ? t.Customer.Name : "");
					li.SubItems.Add(t.TotalAmount.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public TruckLoadListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader3.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader2.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width + columnHeader7.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			enterTruckLoadsToolStripMenuItem.Click += delegate { new AddTruckLoad().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditTruckLoad(loads[listView1.SelectedItems[0].Index]).Run();
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListTruckLoads != null) ListTruckLoads(this, e);
		}
		
		public event EventHandler ListTruckLoads;
		public event TruckLoadEventHandler CloseTruckLoad;
		public event TruckLoadEventHandler DeleteTruckLoad;
		
		void ViewReportToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0) {
				TruckLoad t = loads[listView1.SelectedItems[0].Index];
				new ViewTruckLoadByRefNoReport(t.Id).Run();
			}
		}
		
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				using (AdminPasswordForm f = new AdminPasswordForm()) {
					if (WorkbenchSingleton.AddDialog(f) == DialogResult.OK) {
						foreach (ListViewItem li in listView1.SelectedItems) {
							TruckLoad t = loads[li.Index];
							CloseTruckLoad(t, null);
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
					TruckLoad t = loads[li.Index];
					DeleteTruckLoad(t, null);
				}
				OnActivated(null);
			}
		}
		
		void ViewSalesReportPerItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0) {
				TruckLoad t = loads[listView1.SelectedItems[0].Index];
				new ViewSalesReportPerItem(t).Run();
			}
		}
		
		void CreateSalesInvoiceToolStripMenuItemClick(object sender, EventArgs e)
		{
//			if (listView1.SelectedItems.Count > 0) {
//				TruckLoad t = loads[listView1.SelectedItems[0].Index];
//				Invoice s = t.CreateSalesInvoice();
//				s.Print();
//			}
		}
	}
}
