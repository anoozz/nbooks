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
	/// Interaction logic for CategoryListWindow.xaml
	/// </summary>
	public partial class CategoryListWindow : Window, ICategoryListView
	{
		IList<Category> categories;
		
		public IList<Category> Categories {
			get { return categories; }
			set {
				categories = value;
			}
		}
		
		public CategoryListWindow()
		{
			InitializeComponent();
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListCategories != null) ListCategories(this, null);
		}
		
		public event EventHandler ListCategories;
		public event CategoryEventHandler DeleteCategory;
		public event CategoryEventHandler MakeInactiveCategory;
	}
}