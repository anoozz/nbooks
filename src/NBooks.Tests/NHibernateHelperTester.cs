//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

namespace NBooks.Tests
{
	using System;
	using NBooks.Core.Models;
	using NBooks.Data.NHibernate;
	using NHibernate;
	using NHibernate.Cfg;
	using NUnit.Framework;
	
	[TestFixture]
	public class NHibernateHelperTester
	{
		[Test]
		public void TestMethod()
		{
			Configuration cfg = new Configuration();
			cfg.SetProperty("hibernate.dialect", "NHibernate.Dialect.SQLiteDialect");
			cfg.SetProperty("hibernate.connection.driver_class", "NHibernate.Driver.SQLite20Driver");
			cfg.SetProperty("hibernate.connection.provider", "NHibernate.Connection.DriverConnectionProvider");
			cfg.SetProperty("hibernate.query.substitutions", "true=1;false=0");
			cfg.SetProperty("hibernate.connection.connection_string", @"Data Source=C:\ian\projects\nbooks@codeplex\bin\test.sqlite;Version=3");
			
			NHibernateHelper.Configuration = cfg;
			
			User u = new User("test", "test");
//			u.SaveOrUpdate();
			Console.WriteLine(u.Id);
			
//			ITransaction trans = null;
//			try {
//				ISession session = cfg.Configure().BuildSessionFactory().OpenSession();
//				trans = session.BeginTransaction();
//				session.SaveOrUpdate(u);
//				Console.WriteLine(u.Id);
//				session.Flush();
//				trans.Commit();
//			} catch (Exception ex) {
//				Console.WriteLine(ex.Message);
//				trans.Rollback();
//			}
		}
	}
}
