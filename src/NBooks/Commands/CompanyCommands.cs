//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

using NBooks.Core.Repositories;
using NBooks.Core.Gui;
using NBooks.Core.Models;
using NBooks.Core.Util;
using NBooks.Core.Util.Databases;
using NBooks.Data.NHibernate;
using NBooks.Views;

namespace NBooks.Commands
{
	public class AddCompany : AbstractCommand
	{
		public override void Run()
		{
			CompanyForm f = new CompanyForm(new Company());
			f.CompanySave += delegate(object sender, CompanyEventArgs e) { 
				using (var d = new SaveFileDialog()) {
					d.Title = "Filename for New Company";
					d.FileName = f.Company.Name + ".sqlite";
					if (d.ShowDialog() == DialogResult.OK) {
						SQLiteConnection con = new SQLiteConnection("Data Source=" + d.FileName + ";Version=3");
						con.Open();
						SQLiteUtility.ExecuteNonQuery(con, new StreamReader(Path.Combine(ApplicationUtility.RootDirectory, "sqlscript.sql")).ReadToEnd());
						con.Close();
						
						NHibernateHelper.CloseSession();
						NHibernateHelper.Configuration = new SQLiteDatabase(con.ConnectionString).CreateConfiguration();
						
						new NHibernateCompanyDao().SaveOrUpdate(f.Company);
						new NHibernateUserDao().SaveOrUpdate(new User("admin", "root"));
					}
				}
			};
			WorkbenchSingleton.AddDialog(f);
		}
	}
	
	public class OpenCompany : AbstractCommand
	{
		public override void Run()
		{
//			using (var d = new OpenFileDialog()) {
//				d.Filter = "SQLite Files (*.sqlite) |*.sqlite";
//				d.Title = "Open a Company";
//				if (d.ShowDialog() == DialogResult.OK) {
//					CompanySingleton.Instance = Company.Read(1);
//					CompanySingleton.Instance.NameChanged += delegate { 
//						WorkbenchSingleton.MainForm.Text = ApplicationUtility.ProductNameAndVersion + " - " + CompanySingleton.Instance.Name;
//					};
//					WorkbenchSingleton.MainForm.Text = ApplicationUtility.ProductNameAndVersion + " - " + CompanySingleton.Instance.Name;
//					new Login2(CompanySingleton.Instance).Run();
//				}
//			} // TODO: open company.
		}
	}
	
	public class CloseCompany : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.Workbench.CloseAllChildren();
		}
	}
	
	public class EditCompany : AbstractCommand
	{
		Company company;
		
		public EditCompany(Company company)
		{
			this.company = company;
		}
		
		public override void Run()
		{
			CompanyForm form = new CompanyForm(company);
			ICompanyRepository companyDao = new NHibernateCompanyDao();
			ICountryRepository countryDao = new NHibernateCountryDao();
			
			form.CountriesList += delegate { form.Countries = countryDao.FindActive(); };
			form.LegalCountriesList += delegate { form.LegalCountries = countryDao.FindActive(); };
			form.CompanySave += delegate(object sender, CompanyEventArgs e) { 
				companyDao.SaveOrUpdate(e.Company);
				form.Close();
			};
			WorkbenchSingleton.AddDialog(form);
		}
	}
	
	public class ShowHomePage : AbstractCommand
	{
		public override void Run()
		{
			WebBrowserForm form = new WebBrowserForm(Path.Combine(ApplicationUtility.DocDirectory, "home.html"));
			form.Navigated += delegate(object sender, WebBrowserNavigatedEventArgs e) { 
				string fileName = Path.GetFileName(e.Url.ToString());
				switch (fileName) {
					case "home.html#EditCompany":
						new EditCompany(CompanySingleton.Instance).Run();
						break;
					case "home.html#ListItems":
						new ListItems().Run();
						break;
					case "home.html#ListVendors":
						new ListVendors().Run();
						break;
					case "home.html#ListCustomers":
						new ListCustomers().Run();
						break;
					case "home.html#AddPurchaseOrder":
						new AddPurchaseOrder().Run();
						break;
					default:
						break;
				}
			};
			WorkbenchSingleton.AddChild(form, "Home Page"); 
		}
	}
}
