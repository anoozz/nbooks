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
using NBooks.Core.Views;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for VehicleWindow.xaml
	/// </summary>
	public partial class VehicleWindow : Window, IVehicleView
	{
		Vehicle vehicle;
		
		public Vehicle Vehicle {
			get {
				vehicle.Name = textBoxName.Text;
				vehicle.Description = textBoxDescription.Text;
				vehicle.Inactive = (bool)checkBoxInactive.IsChecked;
				return vehicle;
			}
			set {
				vehicle = value;
				textBoxName.Text = vehicle.Name;
				textBoxDescription.Text = vehicle.Description;
				checkBoxInactive.IsChecked = vehicle.Inactive;
			}
		}
		
		public VehicleWindow() : this(new Vehicle())
		{
		}
		
		public VehicleWindow(Vehicle vehicle)
		{
			InitializeComponent();
			this.Vehicle = vehicle;
		}
		
		public event VehicleEventHandler SaveVehicle;
		
		void buttonOk_Click(object sender, RoutedEventArgs e)
		{
			if (SaveVehicle != null) {
				SaveVehicle(Vehicle, e);
			}
		}
		
		void buttonCancel_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}