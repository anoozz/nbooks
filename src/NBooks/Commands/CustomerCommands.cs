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
	public class ListCustomers : AbstractCommand
	{
		public override void Run()
		{
			CustomerListForm form = new CustomerListForm();
			ICustomerRepository dao = new NHibernateCustomerDao();
			form.CustomersList += delegate { form.Customers = dao.FindActive(); };
			form.CustomerAdd += delegate { new AddCustomer().Run(); };
			form.CustomerEdit += delegate(object sender, CustomerEventArgs e) { 
				new EditCustomer(e.Customer).Run();
			};
			form.CustomerDelete += delegate(object sender, CustomerEventArgs e) { 
				dao.Delete(e.Customer);
			};
			form.CustomerMakeInactive += delegate(object sender, CustomerEventArgs e) { 
				dao.MakeInactive(e.Customer);
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class ShowCustomerCenter : AbstractCommand
	{
		public override void Run()
		{
			CustomerCenterForm form = new CustomerCenterForm();
			ICustomerRepository customerDao = new NHibernateCustomerDao();
			form.CustomersList += delegate { form.Customers = customerDao.FindActive(); };
			form.CustomerAdd += delegate { new AddCustomer().Run(); };
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class AddCustomer : AbstractCommand
	{
		public override void Run()
		{
			CustomerForm form = new CustomerForm();
			ICustomerRepository dao = new NHibernateCustomerDao();
			form.CustomerSave += delegate(object sender, CustomerEventArgs e) { 
				dao.SaveOrUpdate(e.Customer);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditCustomer : AbstractCommand
	{
		Customer customer;
		
		public EditCustomer(Customer customer)
		{
			this.customer = customer;
		}
		
		public override void Run()
		{
//			var view = new CustomerForm(customer);
//			view.ListJobTypes += delegate { view.JobTypes = JobType.FindActive(); };
//			view.ListCustomerTypes += delegate { view.Types = CustomerType.FindActive(); };
//			view.ListTerms += delegate { view.Terms = Terms.FindActive(); };
//			view.ListPriceLevels += delegate { view.PriceLevels = PriceLevel.FindActive(); };
//			view.ListPaymentMethods += delegate { view.PaymentMethods = PaymentMethod.FindActive(); };
//			view.ListSalesTaxCodes += delegate { view.SalesTaxCodes = SalesTaxCode.FindActive(); };
//			view.SaveCustomer += delegate(Customer sender, EventArgs e) { 
//				sender.SaveOrUpdate();
//				view.Close();
//			};
//			WorkbenchSingleton.AddChild(view, "Edit Customer");
			CustomerForm form = new CustomerForm(customer);
			ICustomerRepository dao = new NHibernateCustomerDao();
			form.CustomerSave += delegate(object sender, CustomerEventArgs e) { 
				dao.SaveOrUpdate(e.Customer);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form, "Edit Customer");
		}
	}
}
