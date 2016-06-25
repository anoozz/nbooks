//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;

namespace NBooks.Views
{
	public partial class DepartmentForm : BaseForm
	{
		Department department;
		
		public Department Department {
			get { 
				department.Name = textBoxName.Text;
				department.Inactive = checkBoxInactive.Checked;
				return department;
			}
			set { 
				department = value;
				textBoxName.Text = department.Name;
				checkBoxInactive.Checked = department.Inactive;
			}
		}
		
		public DepartmentForm() : this(new Department())
		{
		}
		
		public DepartmentForm(Department department)
		{
			InitializeComponent();
			this.Department = department;
		}
		
		public event EventHandler<DepartmentEventArgs> DepartmentSave;
		
		protected virtual void OnDepartmentSave(DepartmentEventArgs e)
		{
			if (DepartmentSave != null) {
				DepartmentSave(this, e);
			}
		}
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			OnDepartmentSave(new DepartmentEventArgs(Department));
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
