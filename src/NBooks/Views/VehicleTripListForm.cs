/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 2/22/2011
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	/// <summary>
	/// Description of VehicleTripListForm.
	/// </summary>
	public partial class VehicleTripListForm : BaseForm
	{
		IList<VehicleTrip> trips;
		
		public IList<VehicleTrip> VehicleTrips {
			get { return trips; }
			set {
				trips = value;
				listViewTrips.Items.Clear();
				foreach (var trip in trips) {
					ListViewItem li = listViewTrips.Items.Add(trip.Vehicle.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public VehicleTripListForm()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnVehicleTripsList(e);
		}
		
		public event EventHandler VehicleTripsList;
		
		protected virtual void OnVehicleTripsList(EventArgs e)
		{
			if (VehicleTripsList != null) {
				VehicleTripsList(this, e);
			}
		}
	}
}
