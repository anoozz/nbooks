//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListToDosForReminder : AbstractCommand
	{
		public override void Run()
		{
//			IList<ToDo> todos = ToDo.FindForReminder();
//			foreach (ToDo t in todos) {
//				WorkbenchSingleton.AddDialog(new AlertForm(t), FormStartPosition.WindowsDefaultLocation);
//			}
		}
	}
	
	public class ListToDos : AbstractCommand
	{
		public override void Run()
		{
//			var view = new ToDoListForm();
//			view.ListToDos += delegate { view.ToDos = ToDo.FindActive(); };
//			view.DeleteToDo += delegate(ToDo sender, EventArgs e) { sender.Delete(); };
//			view.MakeInactiveToDo += delegate(ToDo sender, EventArgs e) { sender.MakeInactive(); };
//			view.MarkAsDoneToDo += delegate(ToDo sender, EventArgs e) { sender.MarkAsDone(); };
//			WorkbenchSingleton.AddChild(view);
			var form = new ToDoListForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditToDo : AbstractCommand
	{
		ToDo todo;
		
		public EditToDo(ToDo todo)
		{
			this.todo = todo;
		}
		
		public override void Run()
		{
			var form = new ToDoForm(todo);
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddToDo : AbstractCommand
	{
		public override void Run()
		{
			var form = new ToDoForm();
			WorkbenchSingleton.AddChild(form);
		}
	}
}
