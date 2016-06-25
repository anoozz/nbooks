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
	/// Interaction logic for ToDoListWindow.xaml
	/// </summary>
	public partial class ToDoListWindow : Window
	{
		IList<ToDo> todos;
		
		public IList<ToDo> ToDos {
			get { return todos; }
			set { 
				todos = value;
			}
		}
		
		public ToDoListWindow()
		{
			InitializeComponent();
		}
		
		public event EventHandler ListToDos;
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListToDos != null) ListToDos(this, null);
		}
	}
}