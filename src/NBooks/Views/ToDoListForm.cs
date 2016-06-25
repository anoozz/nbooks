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
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class ToDoListForm : BaseForm
	{
		IList<ToDo> todos;
		
		public IList<ToDo> ToDos {
			get { return todos; }
			set { 
				todos = value;
				listView1.Items.Clear();
				foreach (var t in todos) {
					ListViewItem li = listView1.Items.Add(t.Done ? "Yes" : "No");
					li.SubItems.Add(t.RemindOn.ToShortDateString());
					li.SubItems.Add(t.Note);
				}
			}
		}
		
		public ToDoListForm()
		{
			InitializeComponent();
			listView1.Resize += delegate { columnHeaderDescription.Width = listView1.Width - 22 - (columnHeaderDone.Width + columnHeaderDate.Width); };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { new AddToDo().Run(); };
			editToolStripMenuItem.Click += delegate {
				if(listView1.SelectedItems.Count >0) {
					new EditToDo(todos[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0){
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteToDo(todos[li.Index], null);
					}
					OnActivated(null);
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0){
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveToDo(todos[li.Index], null);
					}
					OnActivated(null);
				}
			};
			markAsDoneToolStripMenuItem.Click += delegate { 
				if(listView1.SelectedItems.Count > 0){
					foreach (ListViewItem li in listView1.SelectedItems) {
						MarkAsDoneToDo(todos[li.Index], null);
					}
					OnActivated(null);
				}
			};
		}
		
		public event EventHandler ListToDos;
		public event ToDoEventHandler DeleteToDo;
		public event ToDoEventHandler MakeInactiveToDo;
		public event ToDoEventHandler MarkAsDoneToDo;
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			if (ListToDos != null) ListToDos(this, e);
		}
	}
}
