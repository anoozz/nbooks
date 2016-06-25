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
	public partial class WorkersCompListForm : BaseForm
	{
		IList<WorkersComp> codes;
		
		public IList<WorkersComp> WorkersComps {
			get { return codes; }
			set { 
				codes = value;
				listView1.Items.Clear();
				foreach (var c in codes) {
					ListViewItem li = listView1.Items.Add(c.Code);
					li.SubItems.Add(c.Description);
					li.SubItems.Add(c.Rate.ToString("0.00"));
					li.SubItems.Add(c.EffectivityDate.ToShortDateString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public WorkersCompListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeader2.Width = listView1.Width - 22 - (columnHeader1.Width + columnHeader3.Width + columnHeader4.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddWorkersComp().Run(); };
			editToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					new EditWorkersComp(codes[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
//						DeleteWorkersComp(codes[li.Index], null);
						OnDeleteWorkersComp(new WorkersCompEventArgs(codes[li.Index]));
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
//						MakeInactiveWorkersComp(codes[li.Index], null);
						OnMakeInactiveWorkersComp(new WorkersCompEventArgs(codes[li.Index]));
					}
					OnActivated(null);
				}
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListWorkersComps != null) {
				ListWorkersComps(this, e);
			}
		}
		
		public event EventHandler ListWorkersComps;
		
		public event EventHandler<WorkersCompEventArgs> MakeInactiveWorkersComp;
		
		protected virtual void OnMakeInactiveWorkersComp(WorkersCompEventArgs e)
		{
			if (MakeInactiveWorkersComp != null) {
				MakeInactiveWorkersComp(this, e);
			}
		}
		
		public event EventHandler<WorkersCompEventArgs> DeleteWorkersComp;
		
		protected virtual void OnDeleteWorkersComp(WorkersCompEventArgs e)
		{
			if (DeleteWorkersComp != null) {
				DeleteWorkersComp(this, e);
			}
		}
	}
}
