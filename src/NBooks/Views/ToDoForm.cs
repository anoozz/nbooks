// one line to give the library's name and an idea of what it does.
// Copyright (C) 2010 Ian Escarro <ian.escarro@gmail.com>
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class ToDoForm : BaseForm
	{
		ToDo todo;
		
		public ToDo ToDo {
			get { 
				todo.Note = richTextBoxNote.Text;
				todo.RemindOn = dateTimePickerRemindOn.Value;
				todo.Done = checkBoxDone.Checked;
				todo.Inactive = checkBoxInactive.Checked;
				return todo;
			}
			set { 
				todo = value; 
				richTextBoxNote.Text = todo.Note;
				dateTimePickerRemindOn.Value = DateUtility.GetValid(todo.RemindOn);
				checkBoxDone.Checked = todo.Done;
				checkBoxInactive.Checked = todo.Inactive;
			}
		}
		
		public ToDoForm() : this(new ToDo())
		{
		}
		
		public ToDoForm(ToDo todo)
		{
			InitializeComponent();
			this.ToDo = todo;
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			if (SaveToDo != null) {
				SaveToDo(ToDo, e);
			}
		}
		
		public event ToDoEventHandler SaveToDo;
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
