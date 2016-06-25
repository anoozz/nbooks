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
	public partial class SSPremiumListForm : BaseForm
	{
		IList<SSPremium> premiums;
		
		public IList<SSPremium> SSPremiums {
			get { return premiums; }
			set { 
				premiums = value;
				listView1.Items.Clear();
				foreach (var p in premiums) {
					ListViewItem li = listView1.Items.Add(p.Code);
					li.SubItems.Add(p.RangeFrom.ToString("###,##0.00"));
					li.SubItems.Add(p.RangeTo.ToString("###,##0.00"));
					li.SubItems.Add(p.ER.ToString("###,##0.00"));
					li.SubItems.Add(p.EC.ToString("###,##0.00"));
					li.SubItems.Add(p.EE.ToString("###,##0.00"));
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public SSPremiumListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader1.Width = listView1.Width - 22 - (columnHeader2.Width + columnHeader3.Width + columnHeader4.Width + columnHeader5.Width + columnHeader6.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddSSPremium().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditSSPremium(premiums[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteSSPremium(premiums[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveSSPremium(premiums[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListSSPremiums != null) ListSSPremiums(this, e);
		}
		
		public event EventHandler ListSSPremiums;
		public event SSPremiumEventHandler DeleteSSPremium;
		public event SSPremiumEventHandler MakeInactiveSSPremium;
	}
}
