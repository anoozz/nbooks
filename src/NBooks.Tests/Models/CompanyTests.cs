//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NBooks.Core.Models;
using NUnit.Framework;

namespace NBooks.Tests.Models
{
	[TestFixture]
	public class CompanyTests
	{
		[Test]
        public void TestMethod()
        {
            foreach (var c in Company.FindRecent(@"D:\projects\nbooks\branches\0.1.0\config\companies.txt")) {
                Console.WriteLine(c.Database.ConnectionString);
            }
        }

        [Test]
        public void TestCompanyNameChanged()
        {
            CompanySingleton.Instance = new Company();
            CompanySingleton.Instance.NameChanged += delegate { Console.WriteLine("Name changed"); };
            CompanySingleton.Instance.Name = "ABC Company";

            CompanySingleton.Instance = new Company();
            CompanySingleton.Instance.Name = "DEF Company";
        }

        [Test]
        public void TestCreateCompany()
        {
        }

        [Test]
        public void TestMethod2()
        {
        }
	}
}
