//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Collections.Generic;
using System.IO;

using NBooks.Core.Util;
using NBooks.Core.Util.Databases;
using NBooks.Data.NHibernate;

namespace NBooks.Core.Models
{
	public class Company : BaseModel<Company>
	{
		public virtual int FiscalYear { get; set; }
		public virtual int TaxYear { get; set; }
		public virtual int IncomeTaxForm { get; set; }
		public virtual Country Country { get; set; }
		public virtual Country LegalCountry { get; set; }
		public virtual State State { get; set; }
		public virtual string Address { get; set; }
		public virtual string Phone { get; set; }
		public virtual string Fax { get; set; }
		public virtual string Email { get; set; }
		public virtual string Website { get; set; }
		public virtual string LegalName { get; set; }
		public virtual Address LegalAddress { get; set; }
		public virtual string EIN { get; set; }
		public virtual string SSN { get; set; }
		public virtual string PayrollContact { get; set; }
		public virtual string PayrollTitle { get; set; }
		public virtual string PayrollPhone { get; set; }
		public virtual string ShipToName { get; set; }
		public virtual Database Database { get; set; }
		public virtual string ShipToAddress { get; set; }
		string name;
		
		public virtual string Name {
			get { return name; }
			set { 
				name = value; 
				if (NameChanged != null) NameChanged(this, null);
			}
		}
		
		public Company()
		{
		}
		
		public virtual void Open()
		{
			NHibernateHelper.Configuration = Database.CreateConfiguration();
		}
		
		public static IList<Company> FindRecent()
		{
			return FindRecent(Path.Combine(ApplicationUtility.ConfigDirectory, "companies.txt"));
		}
		
		public static IList<Company> FindRecent(string filename)
		{
			IList<Company> companies = new List<Company>();
			string config = new StreamReader(filename).ReadToEnd();
			foreach (string line in config.Split('\n')) {
				string[] company = line.Trim().Split('|');
				Company c = new Company();
				c.Database = Database.GetDatabase(company[0].Trim());
				c.Database.ConnectionString = company[1].Trim();
				companies.Add(c);
			}
			return companies;
		}
		
		public virtual event EventHandler NameChanged;
		
		public virtual void Create()
		{
			
		}
	}
	
	public class CompanySingleton
	{
		static Company instance = null;
		
		public static Company Instance {
			get { return instance; }
			set { instance = value; }
		}
		
		CompanySingleton()
		{
		}
	}
	
	public class CompanyEventArgs : EventArgs
	{
		public Company Company { get; set; }
		
		public CompanyEventArgs(Company company)
		{
			this.Company = company;
		}
	}
}
