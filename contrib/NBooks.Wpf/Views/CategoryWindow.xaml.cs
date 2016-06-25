/*
 * Created by SharpDevelop.
 * User: ie185004
 * Date: 1/4/2011
 * Time: 3:35 PM
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
	/// Interaction logic for CategoryWindow.xaml
	/// </summary>
	public partial class CategoryWindow : Window, ICategoryView
	{
		Category category;
		
		public Category Category {
			get { 
				return category;
			}
			set { 
				category = value;
			}
		}
		
		public CategoryWindow() : this(new Category())
		{
		}
		
		public CategoryWindow(Category category)
		{
			InitializeComponent();
			this.Category = category;
		}
		
		public event CategoryEventHandler SaveCategory;
	}
}