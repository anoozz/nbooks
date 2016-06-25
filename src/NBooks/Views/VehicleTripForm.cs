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
using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class VehicleTripForm : BaseForm
	{
		VehicleTrip trip;
		IList<Vehicle> vehicles;
		
		public IList<Vehicle> Vehicles {
			get { return vehicles; }
			set { 
				vehicles = value;
				SwfUtility.SetupComboBox(comboBoxVehicle, vehicles, "Id", "Name", trip.Vehicle);
			}
		}
		
		public VehicleTrip VehicleTrip {
			get { 
				trip.Vehicle = SwfUtility.GetComboBoxValue<Vehicle>(comboBoxVehicle);
				trip.StartDate = dateTimePickerStartDate.Value;
				trip.EndDate = dateTimePickerEndDate.Value;
				trip.Notes = richTextBoxNotes.Text;
				return trip;
			}
			set { 
				trip = value;
				dateTimePickerStartDate.Value = DateUtility.GetValid(trip.StartDate);
				dateTimePickerEndDate.Value = DateUtility.GetValid(trip.EndDate);
				richTextBoxNotes.Text = trip.Notes;
			}
		}
		
		public VehicleTripForm() : this(new VehicleTrip())
		{
		}
		
		public VehicleTripForm(VehicleTrip trip)
		{
			InitializeComponent();
			this.VehicleTrip = trip;
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (VehiclesList != null) VehiclesList(this, e);
		}
		
		public event EventHandler VehiclesList;
		public event EventHandler<VehicleTripEventArgs> VehicleTripSave;
		public event EventHandler<VehicleTripEventArgs> VehicleTripSaveAndClear;
		public event EventHandler<VehicleTripEventArgs> VehicleTripSaveAndClose;
		
		protected virtual void OnVehicleTripSave(VehicleTripEventArgs e)
		{
			if (VehicleTripSave != null) {
				VehicleTripSave(this, e);
			}
		}
		
		protected virtual void OnSaveVehicleTripAndClose(VehicleTripEventArgs e)
		{
			if (VehicleTripSaveAndClose != null) {
				VehicleTripSaveAndClose(this, e);
			}
		}
		
		protected virtual void OnVehicleTripSaveAndClear(VehicleTripEventArgs e)
		{
			if (VehicleTripSaveAndClear != null) {
				VehicleTripSaveAndClear(VehicleTrip, e);
			}
		}
		
		void ButtonSaveAndCloseClick(object sender, EventArgs e)
		{
			OnSaveVehicleTripAndClose(new VehicleTripEventArgs(VehicleTrip));
		}
		
		void ButtonSaveAndClearClick(object sender, EventArgs e)
		{
			OnVehicleTripSaveAndClear(new VehicleTripEventArgs(VehicleTrip));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ToolStripButtonVehicleListClick(object sender, EventArgs e)
		{
			new ListVehicles().Run();
		}
		
		void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
			OnVehicleTripSave(new VehicleTripEventArgs(VehicleTrip));
		}
	}
}
