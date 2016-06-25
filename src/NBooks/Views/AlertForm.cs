//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Drawing;
using System.Windows.Forms;

using NBooks.Core.Gui;
using NBooks.Core.Models;

namespace NBooks.Views
{
	/// <summary>
	/// Description of AlertForm.
	/// </summary>
	public partial class AlertForm : BaseForm
	{
		ToDo todo;
		
		public ToDo ToDo {
			get { return todo; }
			set { 
				todo = value;
				linkLabel1.Text = todo.Note;
			}
		}
		
		public AlertForm() : this(new ToDo())
		{
		}
		
		public AlertForm(ToDo todo)
		{
			InitializeComponent();
			this.ToDo = todo;
		}
		
		void ButtonRemindMeAgainClick(object sender, EventArgs e)
		{
			todo.RemindOn = dateTimePickerDate.Value;
//			todo.SaveOrUpdate(); // TODO:
			Close();
		}
		
		void ButtonMarkAsDoneClick(object sender, EventArgs e)
		{
			todo.Done = true;
//			todo.SaveOrUpdate(); // TODO:
			Close();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Commands.EditToDo(todo).Run();
		}
	}
}
