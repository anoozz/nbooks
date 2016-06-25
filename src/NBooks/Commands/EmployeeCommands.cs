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
	public class ListEmployees : AbstractCommand
	{
		public override void Run()
		{
			try {
				EmployeeListForm form = new EmployeeListForm();
				IEmployeeRepository dao = new NHibernateEmployeeRepository();
				form.EmployeesList += delegate { form.Employees = dao.FindActive(); };
				form.EmployeeAdd += delegate { new AddEmployee().Run(); };
				form.EmployeeEdit += delegate(object sender, EmployeeEventArgs e) { 
					new EditEmployee(e.Employee).Run();
				};
				form.EmployeeDelete += delegate(object sender, EmployeeEventArgs e) { 
					dao.Delete(e.Employee);
				};
				form.EmployeeMakeInactive += delegate(object sender, EmployeeEventArgs e) { 
					dao.MakeInactive(e.Employee);
				};
				WorkbenchSingleton.AddChild(form);
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
			}
		}
	}
	
	public class AddEmployee : AbstractCommand
	{
		public override void Run()
		{
			try {
				EmployeeForm form = new EmployeeForm();
				IEmployeeRepository dao = new NHibernateEmployeeRepository();
				form.EmployeeSave += delegate(object sender, EmployeeEventArgs e) { 
					dao.SaveOrUpdate(e.Employee);
					form.Close();
				};
				WorkbenchSingleton.AddChild(form);
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
			}
		}
	}
	
	public class EditEmployee : AbstractCommand
	{
		Employee employee;
		
		public EditEmployee(Employee employee)
		{
			this.employee = employee;
		}
		
		public override void Run()
		{
			try {
				EmployeeForm form = new EmployeeForm(employee);
				IEmployeeRepository dao = new NHibernateEmployeeRepository();
				form.EmployeeSave += delegate(object sender, EmployeeEventArgs e) { 
					dao.SaveOrUpdate(e.Employee);
					form.Close();
				};
				WorkbenchSingleton.AddChild(form);
			} catch (Exception ex) {
				LoggingService.Error(ex.Message);
				MessageService.ShowError(ex.Message);
			}
		}
	}
}
