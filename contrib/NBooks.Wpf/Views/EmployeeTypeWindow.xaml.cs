/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 12:31
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
	/// Interaction logic for EmployeeTypeWindow.xaml
	/// </summary>
	public partial class EmployeeTypeWindow : Window, IEmployeeTypeView
	{
		EmployeeType type;
		
		public EmployeeType EmployeeType {
			get { return type; }
			set { type = value; }
		}
		
		public EmployeeTypeWindow() : this(new EmployeeType())
		{
		}
		
		public EmployeeTypeWindow(EmployeeType type)
		{
			InitializeComponent();
			this.EmployeeType = type;
		}
		
		public event EmployeeTypeEventHandler SaveEmployeeType;
	}
}