/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 3:33 PM
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
	/// Interaction logic for ClassWindow.xaml
	/// </summary>
	public partial class ClassWindow : Window, IClassView
	{
		Class _class;
		
		public Class Class {
			get { return _class; }
			set { _class = value; }
		}
		
		public ClassWindow() : this(new Class())
		{
		}
		
		public ClassWindow(Class _class)
		{
			InitializeComponent();
			this.Class = _class;
		}
		
		public event ClassEventHandler SaveClass;
	}
}