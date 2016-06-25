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
using NBooks.Core.Views;

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for EmployeeListWindow.xaml
	/// </summary>
	public partial class EmployeeListWindow : Window, IEmployeeListView
	{
		IList<Employee> employees;
		
		public IList<Employee> Employees {
			get { return employees; }
			set {
				employees = value;
			}
		}
		
		public EmployeeListWindow()
		{
			InitializeComponent();
		}
		
		public event EventHandler ListEmployees;
		public event EmployeeEventHandler DeleteEmployee;
		public event EmployeeEventHandler MakeInactiveEmployee;
	}
}