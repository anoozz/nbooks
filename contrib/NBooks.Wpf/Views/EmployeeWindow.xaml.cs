/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 11:20
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
	/// Interaction logic for EmployeeWindow.xaml
	/// </summary>
	public partial class EmployeeWindow : Window
	{
		Employee employee;
		
		public Employee Employee {
			get { 
				return employee;
			}
			set { 
				employee = value;
			}
		}
		
		public EmployeeWindow() : this(new Employee())
		{
		}
		
		public EmployeeWindow(Employee employee)
		{
			InitializeComponent();
			this.Employee = employee;
		}
		
		public event EmployeeEventHandler SaveEmployee;
		
		protected virtual void OnSaveEmployee(EventArgs e)
		{
			if (SaveEmployee != null) {
				SaveEmployee(Employee, e);
			}
		}
	}
}