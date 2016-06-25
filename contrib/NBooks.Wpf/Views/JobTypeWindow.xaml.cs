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

namespace NBooks.Wpf.Views
{
	/// <summary>
	/// Interaction logic for JobTypeWindow.xaml
	/// </summary>
	public partial class JobTypeWindow : Window
	{
		JobType type;
		
		public JobType JobType {
			get { 
				return type; 
			}
			set { 
				type = value;
			}
		}
		
		public JobTypeWindow() : this(new JobType())
		{
		}
		
		public JobTypeWindow(JobType type)
		{
			InitializeComponent();
			this.JobType = type;
		}
		
		public event JobTypeEventHandler SaveJobType;
		
		protected virtual void OnSaveJobType(EventArgs e)
		{
			if (SaveJobType != null) {
				SaveJobType(JobType, e);
			}
		}
	}
}