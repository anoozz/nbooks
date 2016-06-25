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
	/// Interaction logic for ToDoWindow.xaml
	/// </summary>
	public partial class ToDoWindow : Window
	{
		ToDo todo;
		
		public ToDo ToDo {
			get { 
				return todo;
			}
			set {
				todo = value;
			}
		}
		
		public ToDoWindow() : this(new ToDo())
		{
		}
		
		public ToDoWindow(ToDo todo)
		{
			InitializeComponent();
			this.ToDo = todo;
		}
		
		public event ToDoEventHandler SaveToDo;
		
		protected virtual void OnSaveToDo(EventArgs e)
		{
			if (SaveToDo != null) {
				SaveToDo(ToDo, e);
			}
		}
	}
}