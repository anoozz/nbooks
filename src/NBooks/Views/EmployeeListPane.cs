//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Commands;
using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class EmployeeListPane : BaseUserControl
	{
		IList<Employee> employees;
		
		public IList<Employee> Employees {
			get { return employees; }
			set { 
				employees = value;
				listView1.Items.Clear();
				foreach (var e in employees) {
					ListViewItem li = listView1.Items.Add(e.LegalName.ToString());
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public EmployeeListPane()
		{
			InitializeComponent();
			refreshToolStripMenuItem.Click += delegate { OnListEmployees(null); };
			editToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					new EditEmployee(employees[listView1.SelectedItems[0].Index]).Run();
				}
			};
			listView1.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						DeleteEmployee(employees[li.Index], null);
					}
				}
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				if (listView1.SelectedItems.Count > 0) {
					foreach (ListViewItem li in listView1.SelectedItems) {
						MakeInactiveEmployee(employees[li.Index], null);
					}
				}
			};
		}
		
		protected virtual void OnListEmployees(EventArgs e)
		{
			if (ListEmployees != null) ListEmployees(this, null);
		}
		
		public event EventHandler ListEmployees;
		public event EmployeeEventHandler DeleteEmployee;
		public event EmployeeEventHandler MakeInactiveEmployee;
	}
}
