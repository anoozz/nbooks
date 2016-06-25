/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 11:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using NBooks.Core.Models;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for VehicleListWindow.xaml
	/// </summary>
	public partial class VehicleListWindow : Window
	{
		IList<Vehicle> vehicles;
		
		public IList<Vehicle> Vehicles {
			get { return vehicles; }
			set { 
				vehicles = value;
			}
		}
		
		public VehicleListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListVehicles != null) ListVehicles(this, null);
		}
		
		public event EventHandler ListVehicles;
	}
}