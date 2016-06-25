//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using NBooks.Core.Models;
using NBooks.Core.Util;

namespace NBooks.Views
{
	public partial class EmployeeListForm : BaseForm
	{
		IList<Employee> employees;
		
		public Employee SelectedEmployee {
			get {
				if (listViewEmployees.SelectedItems.Count > 0) {
					return employees[listViewEmployees.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Employee> SelectedEmployees {
			get {
				IList<Employee> selectedEmployees = new List<Employee>();
				foreach (ListViewItem li in listViewEmployees.SelectedItems) {
					selectedEmployees.Add(employees[li.Index]);
				}
				return selectedEmployees;
			}
		}
		
		public IList<Employee> Employees {
			get { return employees; }
			set {
				employees = value;
				listViewEmployees.Items.Clear();
				foreach (Employee e in employees) {
					ListViewItem li = listViewEmployees.Items.Add(e.LegalName.ToString());
					SwfUtility.AlternateBackColor(li);
				}
				toolStripDropDownButtonEmployee.Text = string.Format("{0} Employees", employees.Count);
			}
		}
		
		public EmployeeListForm()
		{
			InitializeComponent();
			listViewEmployees.Resize += delegate { columnHeader1.Width = listViewEmployees.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnEmployeeAdd(null); };
			newToolStripMenuItem1.Click += delegate { newToolStripMenuItem.PerformClick(); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedEmployee != null) {
					OnEmployeeEdit(new EmployeeEventArgs(SelectedEmployee));
				}
			};
			editToolStripMenuItem1.Click += delegate { editToolStripMenuItem.PerformClick(); };
			listViewEmployees.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var employee in SelectedEmployees) {
					OnEmployeeDelete(new EmployeeEventArgs(employee));
				}
				OnActivated(null);
			};
			deleteToolStripMenuItem1.Click += delegate { deleteToolStripMenuItem.PerformClick(); };
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var employee in SelectedEmployees) {
					OnEmployeeMakeInactive(new EmployeeEventArgs(employee));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem1.Click += delegate { makeInactiveToolStripMenuItem.PerformClick(); };
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnEmployeesList(e);
		}
		
		public event EventHandler EmployeesList;
		
		protected virtual void OnEmployeesList(EventArgs e)
		{
			if (EmployeesList != null) {
				EmployeesList(this, e);
			}
		}
		public event EventHandler<EmployeeEventArgs> EmployeeDelete;
		
		protected virtual void OnEmployeeDelete(EmployeeEventArgs e)
		{
			if (EmployeeDelete != null) {
				EmployeeDelete(this, e);
			}
		}
		public event EventHandler<EmployeeEventArgs> EmployeeEdit;
		
		protected virtual void OnEmployeeEdit(EmployeeEventArgs e)
		{
			if (EmployeeEdit != null) {
				EmployeeEdit(this, e);
			}
		}
		public event EventHandler<EmployeeEventArgs> EmployeeMakeInactive;
		
		protected virtual void OnEmployeeMakeInactive(EmployeeEventArgs e)
		{
			if (EmployeeMakeInactive != null) {
				EmployeeMakeInactive(this, e);
			}
		}
		public event EventHandler EmployeeAdd;
		
		protected virtual void OnEmployeeAdd(EventArgs e)
		{
			if (EmployeeAdd != null) {
				EmployeeAdd(this, e);
			}
		}
	}
}
