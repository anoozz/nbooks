//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class ListDepartments : AbstractCommand
	{
		public override void Run()
		{
			DepartmentListForm form = new DepartmentListForm();
			IDepartmentRepository dao = new NHibernateDepartmentDao();
			form.DepartmentsList += delegate { form.Departments = dao.FindActive(); };
			form.DepartmentAdd += delegate { new AddDepartment().Run(); };
			form.DepartmentEdit += delegate(object sender, DepartmentEventArgs e) { 
				new EditDepartment(e.Department).Run();
			};
			form.DepartmentDelete += delegate(object sender, DepartmentEventArgs e) { 
				dao.Delete(e.Department);
			};
			form.DepartmentMakeInactive += delegate(object sender, DepartmentEventArgs e) { 
				dao.MakeInactive(e.Department);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddDepartment : AbstractCommand
	{
		public override void Run()
		{
			DepartmentForm form = new DepartmentForm();
			IDepartmentRepository dao = new NHibernateDepartmentDao();
			form.DepartmentSave += delegate(object sender, DepartmentEventArgs e) { 
				dao.SaveOrUpdate(e.Department);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
			
		}
	}
	
	public class EditDepartment : AbstractCommand
	{
		Department department;
		
		public EditDepartment(Department department)
		{
			this.department = department;
		}
		
		public override void Run()
		{
			DepartmentForm form = new DepartmentForm(department);
			IDepartmentRepository dao = new NHibernateDepartmentDao();
			form.DepartmentSave += delegate(object sender, DepartmentEventArgs e) { 
				dao.SaveOrUpdate(e.Department);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Department");
		}
	}
}
