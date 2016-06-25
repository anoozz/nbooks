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
	public partial class VehicleListForm : BaseForm
	{
		IList<Vehicle> vehicles;
		
		public Vehicle SelectedVehicle {
			get {
				if (listViewVehicles.SelectedItems.Count > 0) {
					return vehicles[listViewVehicles.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Vehicle> SelectedVehicles {
			get {
				IList<Vehicle> selectedVehicles = new List<Vehicle>();
				foreach (ListViewItem li in listViewVehicles.SelectedItems) {
					selectedVehicles.Add(vehicles[li.Index]);
				}
				return selectedVehicles;
			}
		}
		
		public IList<Vehicle> Vehicles {
			get { return vehicles; }
			set { 
				vehicles = value;
				listViewVehicles.Items.Clear();
				foreach (var v in vehicles) {
					ListViewItem li = listViewVehicles.Items.Add(v.Name);
					li.SubItems.Add(v.Description);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public VehicleListForm()
		{
			InitializeComponent();
			listViewVehicles.Resize += delegate { columnHeader2.Width = listViewVehicles.Width - 22 - (columnHeader1.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnVehicleAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedVehicle != null) {
					OnVehicleEdit(new VehicleEventArgs(SelectedVehicle));
				}
			};
			listViewVehicles.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var vehicle in SelectedVehicles) {
					OnVehicleDelete(new VehicleEventArgs(vehicle));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var vehicle in SelectedVehicles) {
					OnVehicleMakeInactive(new VehicleEventArgs(vehicle));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnVehiclesList(e);
		}
		
		public event EventHandler VehiclesList;
		public event EventHandler VehicleAdd;
		
		protected virtual void OnVehicleAdd(EventArgs e)
		{
			if (VehicleAdd != null) {
				VehicleAdd(this, e);
			}
		}
		
		protected virtual void OnVehiclesList(EventArgs e)
		{
			if (VehiclesList != null) {
				VehiclesList(this, e);
			}
		}
		public event EventHandler<VehicleEventArgs> VehicleDelete;
		
		protected virtual void OnVehicleDelete(VehicleEventArgs e)
		{
			if (VehicleDelete != null) {
				VehicleDelete(this, e);
			}
		}
		public event EventHandler<VehicleEventArgs> VehicleMakeInactive;
		
		protected virtual void OnVehicleMakeInactive(VehicleEventArgs e)
		{
			if (VehicleMakeInactive != null) {
				VehicleMakeInactive(this, e);
			}
		}
		public event EventHandler<VehicleEventArgs> VehicleEdit;
		
		protected virtual void OnVehicleEdit(VehicleEventArgs e)
		{
			if (VehicleEdit != null) {
				VehicleEdit(this, e);
			}
		}
	}
}
