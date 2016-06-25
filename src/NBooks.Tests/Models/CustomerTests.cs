//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using NBooks.Core.Repositories;
using NBooks.Core.Models;
using NUnit.Framework;

namespace NBooks.Tests.Models
{
	[TestFixture]
	public class CustomerTests
	{
		[Test]
        public void TestMethod()
        {
            Customer c = new Customer();
            c.Name = "Customer 1";

            ICustomerRepository d = new CustomerRepositoryStub();
            d.SaveOrUpdate(c);
        }

        [Test]
        public void TestOtherView()
        {
//        	ICustomerController controller = new CustomerController(
//        		new CustomerView(),
//        		new CustomerService(new NHibernateCustomerDao()),
//        		new CustomerTypeService(new NHibernateCustomerTypeDao()),
//        		new JobTypeService(new NHibernateJobTypeDao()),
//        		new TermsService(new NHibernateTermsDao()),
//        		new PriceLevelService(new NHibernatePriceLevelDao()),
//        		new PaymentMethodService(new NHibernatePaymentMethodDao()),
//        		new SalesTaxCodeService(new NHibernateSalesTaxCodeDao())
//        	);
        }
	}
	
	public class CustomerRepositoryStub : BaseRepositoryStub<Customer>, ICustomerRepository
    {
        public CustomerRepositoryStub()
        {
        }

        public void MakeInactive(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> FindActive()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet FindActiveDS()
        {
            throw new NotImplementedException();
        }
    }
}
