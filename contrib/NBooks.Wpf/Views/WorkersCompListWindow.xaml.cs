/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 11:12 AM
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
	/// Interaction logic for WorkersCompListWindow.xaml
	/// </summary>
	public partial class WorkersCompListWindow : Window, IWorkersCompListView
	{
		IList<WorkersComp> comps;
		
		public IList<WorkersComp> WorkersComps {
			get { return comps; }
			set { comps = value; }
		}
		
		public WorkersCompListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListWorkersComps != null) ListWorkersComps(this, null);
		}
		
		public event EventHandler ListWorkersComps;
		public event WorkersCompEventHandler DeleteWorkersComp;
		public event WorkersCompEventHandler MakeInactiveWorkersComp;
	}
}