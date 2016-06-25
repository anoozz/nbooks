/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 3:34 PM
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
	/// Interaction logic for ClassListWindow.xaml
	/// </summary>
	public partial class ClassListWindow : Window, IClassListView
	{
		IList<Class> classes;
		
		public IList<Class> Classes {
			get { return classes; }
			set { classes = value; }
		}
		
		public ClassListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListClasses != null) ListClasses(this, null);
		}
		
		public event EventHandler ListClasses;
		public event ClassEventHandler DeleteClass;
		public event ClassEventHandler MakeInactiveClass;
	}
}