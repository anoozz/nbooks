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
	public partial class UnitListForm : BaseForm
	{
		IList<Unit> units;
		
		public Unit SelectedUnit {
			get {
				if (listViewUnits.SelectedItems.Count > 0) {
					return units[listViewUnits.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Unit> SelectedUnits {
			get {
				IList<Unit> selectedUnits = new List<Unit>();
				foreach (ListViewItem li in listViewUnits.SelectedItems) {
					selectedUnits.Add(units[li.Index]);
				}
				return selectedUnits;
			}
		}
		
		public IList<Unit> Units {
			get { return units; }
			set { 
				units = value; 
				listViewUnits.Items.Clear();
				foreach (Unit u in units) {
					ListViewItem li = listViewUnits.Items.Add(u.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public UnitListForm()
		{
			InitializeComponent();
			listViewUnits.Resize += delegate { columnHeader1.Width = listViewUnits.Width - 22; };
			newToolStripMenuItem.Click += delegate { OnUnitAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedUnit != null) {
					OnUnitEdit(new UnitEventArgs(SelectedUnit));
				}
			};
			listViewUnits.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var unit in SelectedUnits) {
					OnUnitDelete(new UnitEventArgs(unit));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var unit in SelectedUnits) {
					OnUnitMakeInactive(new UnitEventArgs(unit));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnUnitsList(e);
		}
		
		public event EventHandler UnitsList;
		
		protected virtual void OnUnitsList(EventArgs e)
		{
			if (UnitsList != null) {
				UnitsList(this, e);
			}
		}
		public event EventHandler UnitAdd;
		
		protected virtual void OnUnitAdd(EventArgs e)
		{
			if (UnitAdd != null) {
				UnitAdd(this, e);
			}
		}
		public event EventHandler<UnitEventArgs> UnitEdit;
		
		protected virtual void OnUnitEdit(UnitEventArgs e)
		{
			if (UnitEdit != null) {
				UnitEdit(this, e);
			}
		}
		public event EventHandler<UnitEventArgs> UnitDelete;
		
		protected virtual void OnUnitDelete(UnitEventArgs e)
		{
			if (UnitDelete != null) {
				UnitDelete(this, e);
			}
		}
		public event EventHandler<UnitEventArgs> UnitMakeInactive;
		
		protected virtual void OnUnitMakeInactive(UnitEventArgs e)
		{
			if (UnitMakeInactive != null) {
				UnitMakeInactive(this, e);
			}
		}
	}
}
