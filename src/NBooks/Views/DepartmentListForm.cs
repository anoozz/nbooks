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
	public partial class DepartmentListForm : BaseForm
	{
		IList<Department> departments;
		
		public Department SelectedDepartment {
			get {
				if (listViewDepartments.SelectedItems.Count > 0) {
					return departments[listViewDepartments.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		public IList<Department> SelectedDepartments {
			get {
				IList<Department> selectedDepartments = new List<Department>();
				foreach (ListViewItem li in listViewDepartments.SelectedItems) {
					selectedDepartments.Add(departments[li.Index]);
				}
				return selectedDepartments;
			}
		}
		
		public IList<Department> Departments {
			get { return departments; }
			set { 
				departments = value;
				listViewDepartments.Items.Clear();
				foreach (var d in departments) {
					ListViewItem li = listViewDepartments.Items.Add(d.Name);
					SwfUtility.AlternateBackColor(li);
				}
			}
		}
		
		public DepartmentListForm()
		{
			InitializeComponent();
			listViewDepartments.Resize += delegate { columnHeader1.Width = listViewDepartments.Width - 22; };
			refreshToolStripMenuItem.Click += delegate { OnActivated(null); };
			newToolStripMenuItem.Click += delegate { OnDepartmentAdd(null); };
			editToolStripMenuItem.Click += delegate { 
				if (SelectedDepartment != null) {
					OnDepartmentEdit(new DepartmentEventArgs(SelectedDepartment));
				}
			};
			listViewDepartments.DoubleClick += delegate { editToolStripMenuItem.PerformClick(); };
			deleteToolStripMenuItem.Click += delegate { 
				foreach (var department in SelectedDepartments) {
					OnDepartmentDelete(new DepartmentEventArgs(department));
				}
				OnActivated(null);
			};
			makeInactiveToolStripMenuItem.Click += delegate { 
				foreach (var department in SelectedDepartments) {
					OnDepartmentMakeInactive(new DepartmentEventArgs(department));
				}
				OnActivated(null);
			};
		}
		
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			OnDepartmentsList(e);
		}
		
		public event EventHandler DepartmentsList;
		
		protected virtual void OnDepartmentsList(EventArgs e)
		{
			if (DepartmentsList != null) {
				DepartmentsList(this, e);
			}
		}
		public event EventHandler DepartmentAdd;
		
		protected virtual void OnDepartmentAdd(EventArgs e)
		{
			if (DepartmentAdd != null) {
				DepartmentAdd(this, e);
			}
		}
		public event EventHandler<DepartmentEventArgs> DepartmentEdit;
		
		protected virtual void OnDepartmentEdit(DepartmentEventArgs e)
		{
			if (DepartmentEdit != null) {
				DepartmentEdit(this, e);
			}
		}
		public event EventHandler<DepartmentEventArgs> DepartmentDelete;
		
		protected virtual void OnDepartmentDelete(DepartmentEventArgs e)
		{
			if (DepartmentDelete != null) {
				DepartmentDelete(this, e);
			}
		}
		public event EventHandler<DepartmentEventArgs> DepartmentMakeInactive;
		
		protected virtual void OnDepartmentMakeInactive(DepartmentEventArgs e)
		{
			if (DepartmentMakeInactive != null) {
				DepartmentMakeInactive(this, e);
			}
		}
	}
}
