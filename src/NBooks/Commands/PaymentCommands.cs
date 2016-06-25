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
	public class AddPayment : AbstractCommand
	{
		public override void Run()
		{
			PaymentForm form = new PaymentForm();
			IPaymentRepository paymentDao = new NHibernatePaymentRepository();
			ICustomerRepository customerDao = new NHibernateCustomerRepository();
			IPaymentMethodRepository methodDao = new NHibernatePaymentMethodRepository();
			
			form.CustomersList += delegate { form.Customers = customerDao.FindActive(); };
			form.PaymentMethodsList += delegate { form.PaymentMethods = methodDao.FindActive(); };
			form.PaymentSaveAndClose += delegate(object sender, PaymentEventArgs e) { 
				paymentDao.SaveOrUpdate(e.Payment);
				form.Close();
			};
			WorkbenchSingleton.AddChild(form);
		}
	}
	
	public class EditPayment : AbstractCommand
	{
		Payment payment;
		
		public EditPayment(Payment payment)
		{
			this.payment = payment;
		}
		
		public override void Run()
		{
			var form = new PaymentForm(payment);
			WorkbenchSingleton.AddChild(form);
		}
	}
}
