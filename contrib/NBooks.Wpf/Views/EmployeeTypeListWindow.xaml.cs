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
	/// Interaction logic for EmployeeTypeListWindow.xaml
	/// </summary>
	public partial class EmployeeTypeListWindow : Window, IEmployeeTypeListView
	{
		IList<EmployeeType> types;
		
		public IList<EmployeeType> EmployeeTypes {
			get { return types; }
			set { types = value; }
		}
		
		public EmployeeTypeListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListEmployeeTypes != null) ListEmployeeTypes(this, null);
		}
		
		public event EventHandler ListEmployeeTypes;
		public event EmployeeTypeEventHandler DeleteEmployeeType;
		public event EmployeeTypeEventHandler MakeInactiveEmployeeType;
	}
}