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
	/// Interaction logic for WorkersCompWindow.xaml
	/// </summary>
	public partial class WorkersCompWindow : Window, IWorkersCompView
	{
		WorkersComp comp;
		
		public WorkersComp WorkersComp {
			get {
				return comp;
			}
			set {
				comp = value;
			}
		}
		
		public WorkersCompWindow() : this(new WorkersComp())
		{
		}
		
		public WorkersCompWindow(WorkersComp comp)
		{
			InitializeComponent();
			this.WorkersComp = comp;
		}
		
		public event WorkersCompEventHandler SaveWorkersComp;
		
		protected virtual void OnSaveWorkersComp(EventArgs e)
		{
			if (SaveWorkersComp != null) {
				SaveWorkersComp(WorkersComp, e);
			}
		}
	}
}