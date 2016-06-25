/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 01/04/2011
 * Time: 12:29
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
	/// Interaction logic for JobTypeListWindow.xaml
	/// </summary>
	public partial class JobTypeListWindow : Window, IJobTypeListView
	{
		IList<JobType> jobTypes;
		
		public IList<JobType> JobTypes {
			get { return jobTypes; }
			set { jobTypes = value; }
		}
		
		public JobTypeListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListJobTypes != null) ListJobTypes(this, null);
		}
		
		public event EventHandler ListJobTypes;
		public event JobTypeEventHandler DeleteJobType;
		public event JobTypeEventHandler MakeInactiveJobType;
	}
}